namespace CA.POS.UI
{
    partial class Main
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
            this.cmdPOS = new System.Windows.Forms.Button();
            this.cmdStock = new System.Windows.Forms.Button();
            this.cmdProductReceive = new System.Windows.Forms.Button();
            this.cmdProductType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdPOS
            // 
            this.cmdPOS.Location = new System.Drawing.Point(53, 76);
            this.cmdPOS.Name = "cmdPOS";
            this.cmdPOS.Size = new System.Drawing.Size(140, 52);
            this.cmdPOS.TabIndex = 0;
            this.cmdPOS.Text = "POS";
            this.cmdPOS.UseVisualStyleBackColor = true;
            this.cmdPOS.Click += new System.EventHandler(this.cmdPOS_Click);
            // 
            // cmdStock
            // 
            this.cmdStock.Location = new System.Drawing.Point(53, 169);
            this.cmdStock.Name = "cmdStock";
            this.cmdStock.Size = new System.Drawing.Size(140, 52);
            this.cmdStock.TabIndex = 1;
            this.cmdStock.Text = "Stock";
            this.cmdStock.UseVisualStyleBackColor = true;
            this.cmdStock.Click += new System.EventHandler(this.cmdStock_Click);
            // 
            // cmdProductReceive
            // 
            this.cmdProductReceive.Location = new System.Drawing.Point(111, 236);
            this.cmdProductReceive.Name = "cmdProductReceive";
            this.cmdProductReceive.Size = new System.Drawing.Size(140, 52);
            this.cmdProductReceive.TabIndex = 2;
            this.cmdProductReceive.Text = "Product Receive";
            this.cmdProductReceive.UseVisualStyleBackColor = true;
            this.cmdProductReceive.Click += new System.EventHandler(this.cmdProductReceive_Click);
            // 
            // cmdProductType
            // 
            this.cmdProductType.Location = new System.Drawing.Point(111, 294);
            this.cmdProductType.Name = "cmdProductType";
            this.cmdProductType.Size = new System.Drawing.Size(140, 52);
            this.cmdProductType.TabIndex = 3;
            this.cmdProductType.Text = "Product Type";
            this.cmdProductType.UseVisualStyleBackColor = true;
            this.cmdProductType.Click += new System.EventHandler(this.cmdProductType_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 466);
            this.Controls.Add(this.cmdProductType);
            this.Controls.Add(this.cmdProductReceive);
            this.Controls.Add(this.cmdStock);
            this.Controls.Add(this.cmdPOS);
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdPOS;
        private System.Windows.Forms.Button cmdStock;
        private System.Windows.Forms.Button cmdProductReceive;
        private System.Windows.Forms.Button cmdProductType;
    }
}