﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;


namespace _23521525_Assignment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGetWeather_Click(object sender, EventArgs e)
        {
            string apiKey = "Nhap_api_key_o_day";//api key cua openweather
            string cityName = txtCityName.Text.Trim();

            if (string.IsNullOrEmpty(cityName)) {
                MessageBox.Show("Hãy nhập thành phố trước!");
                return; 
            }

            string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=metric";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode(); //kiểm tra HTTP có phản hồi thành công hay ko (200-299)
                    //nếu không thành công thì tạo ngoại lệ, chuyển sang catch

                    string responseBody = await response.Content.ReadAsStringAsync(); //đọc phản hồi và chuyển sang json
                    JObject weatherData = JObject.Parse(responseBody); // chuyển chuỗi json thành đối tượng jobject để dễ truy cập

                    //lấy mô tả, nhiệt độ, độ ấm
                    string description = weatherData["weather"][0]["description"].ToString();
                    string temp = weatherData["main"]["temp"].ToString();
                    string humidity = weatherData["main"]["humidity"].ToString();

                    //cập nhật thông tin vào label
                    lblWeatherInfo.Text = $"Thời tiết: {description}\nNhiệt độ: {temp}°C\nĐộ ẩm: {humidity}%";
                }
                catch (HttpRequestException ex)
                {
                    lblWeatherInfo.Text = "Không thể lấy thông tin thời tiết.";
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
