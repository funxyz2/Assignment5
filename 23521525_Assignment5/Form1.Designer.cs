namespace _23521525_Assignment5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCityName = new System.Windows.Forms.MaskedTextBox();
            this.btnGetWeather = new System.Windows.Forms.Button();
            this.lblWeatherInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(188, 19);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(197, 22);
            this.txtCityName.TabIndex = 0;
            // 
            // btnGetWeather
            // 
            this.btnGetWeather.Location = new System.Drawing.Point(395, 18);
            this.btnGetWeather.Name = "btnGetWeather";
            this.btnGetWeather.Size = new System.Drawing.Size(140, 25);
            this.btnGetWeather.TabIndex = 1;
            this.btnGetWeather.Text = "Lấy dữ liệu thời tiết";
            this.btnGetWeather.UseVisualStyleBackColor = true;
            this.btnGetWeather.Click += new System.EventHandler(this.btnGetWeather_Click);
            // 
            // lblWeatherInfo
            // 
            this.lblWeatherInfo.AutoSize = true;
            this.lblWeatherInfo.Location = new System.Drawing.Point(13, 91);
            this.lblWeatherInfo.Name = "lblWeatherInfo";
            this.lblWeatherInfo.Size = new System.Drawing.Size(60, 48);
            this.lblWeatherInfo.TabIndex = 2;
            this.lblWeatherInfo.Text = "Thời tiết:\r\nNhiệt độ:\r\nĐộ ẩm:\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vui lòng Nhập thành phố:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thông tin thời tiết hiện tại:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 238);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWeatherInfo);
            this.Controls.Add(this.btnGetWeather);
            this.Controls.Add(this.txtCityName);
            this.Name = "Form1";
            this.Text = "Dự báo Thời tiết sử dụng OpenWeatherAPI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtCityName;
        private System.Windows.Forms.Button btnGetWeather;
        private System.Windows.Forms.Label lblWeatherInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

