using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyControl_01.ControlUI
{
    public partial class SimpleChart : UserControl
    {
        private Font ChartFont = new Font("tahoma", 18f, FontStyle.Bold);
        private SimpleChartDataSource data;
        private float MaxData = 0;

        public SimpleChart()
        {
            this.data = new SimpleChartDataSource();

            InitializeComponent();
        }
        public void setDatasource(SimpleChartDataSource dataSource)
        {
            this.data = dataSource;
            this.RedrawChart();
        }
        public void RefreshChart()
        {
            this.RedrawChart();
        }
        private void RedrawChart()
        {
            this.tbChart.Controls.Clear();            
            this.tbChart.ColumnCount= 0;
            this.tbChart.ColumnCount = this.data.ItemsCount;            
            int iCurrentColumn = 0;

            foreach (SimpleChartItem item in this.data.items)
            {
                if (this.MaxData < item.Value) this.MaxData = item.Value;

                this.tbChart.ColumnStyles[iCurrentColumn] = new ColumnStyle(SizeType.Percent, 100f);

                this.tbChart.Controls.Add(this.createButtonData(item), iCurrentColumn, 0);
                this.tbChart.Controls.Add(this.createLabelData(item.Label), iCurrentColumn, 1);
                
                iCurrentColumn++;
            }

            this.redrawHeight();
        }
        private Label createLabelData(string caption)
        {
            Label result = new Label();
            result.Text = caption;
            result.Dock = DockStyle.Fill;
            result.AutoSize = false;
            result.TextAlign = ContentAlignment.MiddleCenter;
            result.Font = this.ChartFont;

            return result;
        }
        private Button createButtonData(SimpleChartItem item)
        {

            Button result = new Button();
            result.Dock = DockStyle.Bottom;
            result.Cursor = System.Windows.Forms.Cursors.Hand;
            result.FlatStyle = FlatStyle.Flat;
            result.TextAlign = ContentAlignment.TopCenter;
            result.Text = item.Value.ToString();
            result.BackColor = item.Color;
            result.Font = this.ChartFont;

            result.Tag = item.ID;

            if (item.OnClickItem != null)
            {
                result.Click += item.OnClickItem;
            }

            return result;
        }
        private void redrawHeight()
        {
            int iCurrentColumn = 0;
            int  iColumnHeigth = this.tbChart.GetRowHeights()[0];

            foreach (SimpleChartItem item in this.data.items)
            {
                Button currentButton = (Button)this.tbChart.GetControlFromPosition(iCurrentColumn, 0);

                int iButtonHeigth =(int) ((item.Value / this.MaxData) * iColumnHeigth);

                currentButton.Height = iButtonHeigth;

                iCurrentColumn++;
            }
            
        }
        private void SimpleChart_Resize(object sender, EventArgs e)
        {
            this.redrawHeight();
        }
    }
}
