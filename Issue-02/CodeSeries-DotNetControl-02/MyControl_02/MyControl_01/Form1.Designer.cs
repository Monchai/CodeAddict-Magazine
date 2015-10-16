namespace MyControl_01
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
            this.button1 = new System.Windows.Forms.Button();
            this.simpleChart1 = new MyControl_01.ControlUI.SimpleChart();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // simpleChart1
            // 
            this.simpleChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleChart1.BackColor = System.Drawing.Color.White;
            this.simpleChart1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.simpleChart1.Location = new System.Drawing.Point(60, 48);
            this.simpleChart1.Name = "simpleChart1";
            this.simpleChart1.Size = new System.Drawing.Size(321, 204);
            this.simpleChart1.TabIndex = 0;
            this.simpleChart1.onItemClick += new MyControl_01.ControlUI.SimpleChart.ItemClick(this.simpleChart1_onItemClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 350);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.simpleChart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ControlUI.SimpleChart simpleChart1;
        private System.Windows.Forms.Button button1;


    }
}

