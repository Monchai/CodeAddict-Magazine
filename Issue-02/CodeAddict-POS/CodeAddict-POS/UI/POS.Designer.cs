namespace CA.POS.UI
{
    partial class POS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pDetail = new System.Windows.Forms.Panel();
            this.pHeader = new System.Windows.Forms.Panel();
            this.pFooter = new System.Windows.Forms.Panel();
            this.pHotItem = new System.Windows.Forms.Panel();
            this.dgOrderDetail = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductSummary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.cmdCash = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdNewOrder = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.pDetail.SuspendLayout();
            this.pHeader.SuspendLayout();
            this.pFooter.SuspendLayout();
            this.pHotItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // pDetail
            // 
            this.pDetail.Controls.Add(this.dgOrderDetail);
            this.pDetail.Controls.Add(this.pHotItem);
            this.pDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDetail.Location = new System.Drawing.Point(0, 78);
            this.pDetail.Name = "pDetail";
            this.pDetail.Size = new System.Drawing.Size(714, 292);
            this.pDetail.TabIndex = 0;
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pHeader.Controls.Add(this.button7);
            this.pHeader.Controls.Add(this.label1);
            this.pHeader.Controls.Add(this.textBox1);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(714, 78);
            this.pHeader.TabIndex = 1;
            // 
            // pFooter
            // 
            this.pFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pFooter.Controls.Add(this.cmdExit);
            this.pFooter.Controls.Add(this.cmdNewOrder);
            this.pFooter.Controls.Add(this.cmdCancel);
            this.pFooter.Controls.Add(this.cmdCash);
            this.pFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pFooter.Location = new System.Drawing.Point(0, 370);
            this.pFooter.Name = "pFooter";
            this.pFooter.Size = new System.Drawing.Size(714, 76);
            this.pFooter.TabIndex = 2;
            // 
            // pHotItem
            // 
            this.pHotItem.AutoScroll = true;
            this.pHotItem.Controls.Add(this.button6);
            this.pHotItem.Controls.Add(this.button5);
            this.pHotItem.Controls.Add(this.button4);
            this.pHotItem.Controls.Add(this.button3);
            this.pHotItem.Controls.Add(this.button2);
            this.pHotItem.Controls.Add(this.button1);
            this.pHotItem.Dock = System.Windows.Forms.DockStyle.Right;
            this.pHotItem.Location = new System.Drawing.Point(515, 0);
            this.pHotItem.Name = "pHotItem";
            this.pHotItem.Size = new System.Drawing.Size(199, 292);
            this.pHotItem.TabIndex = 5;
            // 
            // dgOrderDetail
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgOrderDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductCode,
            this.ProductName,
            this.ProductPrice,
            this.ProductQTY,
            this.ProductSummary});
            this.dgOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOrderDetail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgOrderDetail.Location = new System.Drawing.Point(0, 0);
            this.dgOrderDetail.Name = "dgOrderDetail";
            this.dgOrderDetail.RowHeadersVisible = false;
            this.dgOrderDetail.Size = new System.Drawing.Size(515, 292);
            this.dgOrderDetail.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Coke";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Pepsi";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(0, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "Corn puff";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Location = new System.Drawing.Point(0, 138);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(199, 46);
            this.button4.TabIndex = 3;
            this.button4.Text = "Party";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.Location = new System.Drawing.Point(0, 184);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(199, 46);
            this.button5.TabIndex = 4;
            this.button5.Text = "Ichiton";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.Location = new System.Drawing.Point(0, 230);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(199, 46);
            this.button6.TabIndex = 5;
            this.button6.Text = "Oichi";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // ProductCode
            // 
            this.ProductCode.Frozen = true;
            this.ProductCode.HeaderText = "Code";
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            this.ProductCode.Width = 200;
            // 
            // ProductName
            // 
            this.ProductName.Frozen = true;
            this.ProductName.HeaderText = "Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 300;
            // 
            // ProductPrice
            // 
            this.ProductPrice.Frozen = true;
            this.ProductPrice.HeaderText = "Price";
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.ReadOnly = true;
            // 
            // ProductQTY
            // 
            this.ProductQTY.Frozen = true;
            this.ProductQTY.HeaderText = "QTY";
            this.ProductQTY.Name = "ProductQTY";
            this.ProductQTY.ReadOnly = true;
            // 
            // ProductSummary
            // 
            this.ProductSummary.Frozen = true;
            this.ProductSummary.HeaderText = "Summary";
            this.ProductSummary.Name = "ProductSummary";
            this.ProductSummary.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox1.Location = new System.Drawing.Point(129, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 29);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Code";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(427, 31);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 2;
            this.button7.Text = "Add";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // cmdCash
            // 
            this.cmdCash.Location = new System.Drawing.Point(597, 25);
            this.cmdCash.Name = "cmdCash";
            this.cmdCash.Size = new System.Drawing.Size(75, 23);
            this.cmdCash.TabIndex = 3;
            this.cmdCash.Text = "Cash";
            this.cmdCash.UseVisualStyleBackColor = true;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(468, 25);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(123, 23);
            this.cmdCancel.TabIndex = 4;
            this.cmdCancel.Text = "Cancel Order";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdNewOrder
            // 
            this.cmdNewOrder.Location = new System.Drawing.Point(179, 25);
            this.cmdNewOrder.Name = "cmdNewOrder";
            this.cmdNewOrder.Size = new System.Drawing.Size(123, 23);
            this.cmdNewOrder.TabIndex = 5;
            this.cmdNewOrder.Text = "New Order";
            this.cmdNewOrder.UseVisualStyleBackColor = true;
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(29, 25);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(75, 23);
            this.cmdExit.TabIndex = 6;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 446);
            this.Controls.Add(this.pDetail);
            this.Controls.Add(this.pFooter);
            this.Controls.Add(this.pHeader);
            this.Name = "POS";
            this.Text = "POS";
            this.pDetail.ResumeLayout(false);
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            this.pFooter.ResumeLayout(false);
            this.pHotItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pDetail;
        private System.Windows.Forms.DataGridView dgOrderDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSummary;
        private System.Windows.Forms.Panel pHotItem;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pFooter;
        private System.Windows.Forms.Button cmdNewOrder;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdCash;
        private System.Windows.Forms.Button cmdExit;
    }
}