using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CA.POS.UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void cmdPOS_Click(object sender, EventArgs e)
        {
            using (UI.POS pos = new POS())
            {
                pos.ShowDialog();
            }
        }

        private void cmdStock_Click(object sender, EventArgs e)
        {
            using (UI.Stock stock = new UI.Stock())
            {
                stock.ShowDialog();
            }
        }
        private void cmdProductReceive_Click(object sender, EventArgs e)
        {
            using (UI.ProductReceive pReceive = new UI.ProductReceive())
            {
                pReceive.ShowDialog();
            }
        }
        private void cmdProductType_Click(object sender, EventArgs e)
        {
            using (UI.ProductType productType = new UI.ProductType())
            {
                productType.ShowDialog();
            }
        }

        List<CA.POS.ProductType> productType = null;

        private void Main_Load(object sender, EventArgs e)
        {
            using(POSDBEntities db = new POSDBEntities())
            {
                this.productType = db.ProductTypes.ToList();
                dataGridView1.DataSource = this.productType;
            }
        }
    }
}
