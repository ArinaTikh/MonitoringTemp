using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MonitoringTemp
{
    public partial class MonitoringTemp : Form
    {
        public MonitoringTemp()
        {
            InitializeComponent();
        }

        private int minTemp;
        private int maxTemp;

        private int minTime;
        private int maxTime;

        private bool allWorkCorrect = false;

        private DateTime date;
        string results = null;

        private void MonitoringTemp_Load(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                var temp = tbTempOnTenMin.Text.Split(' ');

                date = Convert.ToDateTime(tbDate.Text);
                maxTemp = Convert.ToInt32(tbMaxTemp.Text);
                maxTime = Convert.ToInt32(tbMaxTime.Text);

                bool notCheckMin = false;
                if(tbMinTemp.Text == null || tbMinTime.Text == null)
                {
                    notCheckMin = true;
                }
                else
                {
                    minTime = Convert.ToInt32(tbMinTime.Text);
                    minTemp = Convert.ToInt32(tbMinTemp.Text);
                }


                if (temp.Length > 54 || temp.Length < 18)
                {
                    MessageBox.Show("Введите температуру за каждые 10 минут в диапозоне от 180 до 540 минут");
                    throw new ArgumentOutOfRangeException();
                }

                int countMinut = 0;
                int countWrongMaxTempMinunt = 0;
                int countWrongMinTempMinunt = 0;

                bool onMax = false;
                bool onMin = false;
                for (int i = 0; i < temp.Length; i++)
                {   
                    int tempOnMin = Convert.ToInt32(temp[i]);
                    if (tempOnMin > maxTemp)
                    {
                        if (onMin)
                        {
                            onMin = false;
                            countMinut = 0;
                        }

                        onMax = true;
                        countMinut += 10;

                        if (countMinut > maxTime)
                        {
                            countWrongMaxTempMinunt = countMinut;
                            
                        }
                        results += $"Дата: {date} Факт: {tempOnMin} Норма: {maxTemp} Отклонение от нормы: {tempOnMin - maxTemp}\n";
                    }

                    if (tempOnMin < minTemp && !notCheckMin)
                    {
                        if (onMax)
                        {
                            onMax = false;
                            countMinut = 0;
                        }

                        onMin = true;
                        countMinut += 10;

                        if (countMinut > minTime)
                        {
                            countWrongMinTempMinunt = countMinut;
                            
                        }
                        results += $"Дата: {date} Факт: {tempOnMin} Норма: {minTemp} Отклонение от нормы: {tempOnMin - minTemp}\n";
                    }
                    date = date.AddMinutes(10);
                }
                if (countWrongMaxTempMinunt > 0)
                {
                    MessageBox.Show($"Порог максимально допустимой температуры превышен на {countWrongMaxTempMinunt} минут");
                }
                if (countWrongMinTempMinunt > 0)
                {
                    MessageBox.Show($"Порог минимально допустимой температуры превышен на { countWrongMinTempMinunt} минут");
                }
                allWorkCorrect = true;
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Заполните все необходимые поля");
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (allWorkCorrect)
            {
                string path = "file.txt";

                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    sw.Write(results);
                }
            }
        }
    }
}
