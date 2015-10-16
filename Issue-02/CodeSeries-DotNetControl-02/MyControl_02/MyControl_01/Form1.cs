using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyControl_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ControlUI.SimpleChartDataSource datas= new ControlUI.SimpleChartDataSource();

            datas.items.Add(new ControlUI.SimpleChartItem { 
                ID = 1, Label = "Data 1", Value = 100, Color = System.Drawing.Color.Green 
            });
            datas.items.Add(new ControlUI.SimpleChartItem {
                ID = 2, Label = "Data 2", Value = 50 
            });
            datas.items.Add(new ControlUI.SimpleChartItem {
                ID = 3, Label = "Data 3", Value = 75, Color = System.Drawing.Color.Red
            });
            datas.items.Add(new ControlUI.SimpleChartItem { 
                ID = 4, Label = "Data 4", Value = 25 
            });

            this.simpleChart1.setDatasource(datas);
            this.simpleChart1.RefreshChart();

        }

        private void data_Click(object sender, EventArgs e)
        {
            Button cmd = (Button)sender;

            MessageBox.Show(cmd.Tag.ToString());
        }

        private void simpleChart1_onItemClick(ControlUI.SimpleChartItem item)
        {
            string message = "ID : " + item.ID.ToString();
            message += Environment.NewLine + "Label : " + item.Label;
            message += Environment.NewLine + "Value : " + item.Value;

            MessageBox.Show(message);
        }



    }
}
