using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private DateTime date;

        private void MonitoringTemp_Load(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            var temp = tbTempOnTenMin.Text.Split(' ');
            if(temp.Length > 54 || temp.Length < 18)
            {
                throw new ArgumentOutOfRangeException();
            }

            int countWrongMin = 0;
            bool onMax = false;
            bool onMin = false;
            for(int i = 0; i <= temp.Length; i++)
            {
                int tempOnMin = Convert.ToInt32(temp[i]);
                if(tempOnMin > maxTemp)
                {
                    if (onMax)
                    {
                        onMax = false;
                        onMin = true;
                    }
                    countWrongMin += 10;
                }
            }
        }
    }
}
