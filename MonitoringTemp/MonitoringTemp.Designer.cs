namespace MonitoringTemp
{
    partial class MonitoringTemp
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
            this.lbMaxTemp = new System.Windows.Forms.Label();
            this.tbMaxTemp = new System.Windows.Forms.TextBox();
            this.tbMaxTime = new System.Windows.Forms.TextBox();
            this.lbMaxTime = new System.Windows.Forms.Label();
            this.tbMinTime = new System.Windows.Forms.TextBox();
            this.lbMinTime = new System.Windows.Forms.Label();
            this.tbMinTemp = new System.Windows.Forms.TextBox();
            this.lbMinTemp = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.tbTempOnTenMin = new System.Windows.Forms.TextBox();
            this.lbTempOnTenMin = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMaxTemp
            // 
            this.lbMaxTemp.AutoSize = true;
            this.lbMaxTemp.Location = new System.Drawing.Point(55, 176);
            this.lbMaxTemp.Name = "lbMaxTemp";
            this.lbMaxTemp.Size = new System.Drawing.Size(335, 17);
            this.lbMaxTemp.TabIndex = 0;
            this.lbMaxTemp.Text = "Максимально допустимая температура хранения";
            // 
            // tbMaxTemp
            // 
            this.tbMaxTemp.Location = new System.Drawing.Point(58, 200);
            this.tbMaxTemp.Name = "tbMaxTemp";
            this.tbMaxTemp.Size = new System.Drawing.Size(409, 22);
            this.tbMaxTemp.TabIndex = 1;
            // 
            // tbMaxTime
            // 
            this.tbMaxTime.Location = new System.Drawing.Point(58, 271);
            this.tbMaxTime.Name = "tbMaxTime";
            this.tbMaxTime.Size = new System.Drawing.Size(409, 22);
            this.tbMaxTime.TabIndex = 3;
            // 
            // lbMaxTime
            // 
            this.lbMaxTime.AutoSize = true;
            this.lbMaxTime.Location = new System.Drawing.Point(55, 247);
            this.lbMaxTime.Name = "lbMaxTime";
            this.lbMaxTime.Size = new System.Drawing.Size(412, 17);
            this.lbMaxTime.TabIndex = 2;
            this.lbMaxTime.Text = "Допустимое время превышения максимальной температуры\r\n";
            // 
            // tbMinTime
            // 
            this.tbMinTime.Location = new System.Drawing.Point(537, 271);
            this.tbMinTime.Name = "tbMinTime";
            this.tbMinTime.Size = new System.Drawing.Size(409, 22);
            this.tbMinTime.TabIndex = 7;
            // 
            // lbMinTime
            // 
            this.lbMinTime.AutoSize = true;
            this.lbMinTime.Location = new System.Drawing.Point(534, 247);
            this.lbMinTime.Name = "lbMinTime";
            this.lbMinTime.Size = new System.Drawing.Size(396, 17);
            this.lbMinTime.TabIndex = 6;
            this.lbMinTime.Text = "Допустимое время нарушения минимальной температуры";
            // 
            // tbMinTemp
            // 
            this.tbMinTemp.Location = new System.Drawing.Point(537, 200);
            this.tbMinTemp.Name = "tbMinTemp";
            this.tbMinTemp.Size = new System.Drawing.Size(409, 22);
            this.tbMinTemp.TabIndex = 5;
            // 
            // lbMinTemp
            // 
            this.lbMinTemp.AutoSize = true;
            this.lbMinTemp.Location = new System.Drawing.Point(534, 176);
            this.lbMinTemp.Name = "lbMinTemp";
            this.lbMinTemp.Size = new System.Drawing.Size(329, 17);
            this.lbMinTemp.TabIndex = 4;
            this.lbMinTemp.Text = "Минимально допустимая температура хранения";
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(58, 100);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(409, 22);
            this.tbDate.TabIndex = 9;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(55, 76);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(214, 17);
            this.lbDate.TabIndex = 8;
            this.lbDate.Text = "Дата/время начала измерения";
            // 
            // tbTempOnTenMin
            // 
            this.tbTempOnTenMin.Location = new System.Drawing.Point(58, 360);
            this.tbTempOnTenMin.Multiline = true;
            this.tbTempOnTenMin.Name = "tbTempOnTenMin";
            this.tbTempOnTenMin.Size = new System.Drawing.Size(888, 106);
            this.tbTempOnTenMin.TabIndex = 11;
            // 
            // lbTempOnTenMin
            // 
            this.lbTempOnTenMin.AutoSize = true;
            this.lbTempOnTenMin.Location = new System.Drawing.Point(55, 336);
            this.lbTempOnTenMin.Name = "lbTempOnTenMin";
            this.lbTempOnTenMin.Size = new System.Drawing.Size(252, 17);
            this.lbTempOnTenMin.TabIndex = 10;
            this.lbTempOnTenMin.Text = "Температура (от 18 до 54 значений)";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Black;
            this.btnCheck.ForeColor = System.Drawing.Color.Transparent;
            this.btnCheck.Location = new System.Drawing.Point(58, 511);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(888, 63);
            this.btnCheck.TabIndex = 12;
            this.btnCheck.Text = "Проверить условия хранения";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(58, 603);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(888, 63);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Получить более подробный отчет в файл";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // MonitoringTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 689);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.tbTempOnTenMin);
            this.Controls.Add(this.lbTempOnTenMin);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.tbMinTime);
            this.Controls.Add(this.lbMinTime);
            this.Controls.Add(this.tbMinTemp);
            this.Controls.Add(this.lbMinTemp);
            this.Controls.Add(this.tbMaxTime);
            this.Controls.Add(this.lbMaxTime);
            this.Controls.Add(this.tbMaxTemp);
            this.Controls.Add(this.lbMaxTemp);
            this.Name = "MonitoringTemp";
            this.Text = "MonitoringTemperature";
            this.Load += new System.EventHandler(this.MonitoringTemp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaxTemp;
        private System.Windows.Forms.TextBox tbMaxTemp;
        private System.Windows.Forms.TextBox tbMaxTime;
        private System.Windows.Forms.Label lbMaxTime;
        private System.Windows.Forms.TextBox tbMinTime;
        private System.Windows.Forms.Label lbMinTime;
        private System.Windows.Forms.TextBox tbMinTemp;
        private System.Windows.Forms.Label lbMinTemp;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.TextBox tbTempOnTenMin;
        private System.Windows.Forms.Label lbTempOnTenMin;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnSave;
    }
}

