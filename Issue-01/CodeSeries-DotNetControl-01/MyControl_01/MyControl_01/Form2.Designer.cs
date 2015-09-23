namespace MyControl_01
{
    partial class Form2
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
            this.simpleChart1 = new MyControl_01.ControlUI.SimpleChart();
            this.SuspendLayout();
            // 
            // simpleChart1
            // 
            this.simpleChart1.BackColor = System.Drawing.Color.White;
            this.simpleChart1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.simpleChart1.Location = new System.Drawing.Point(50, 53);
            this.simpleChart1.Name = "simpleChart1";
            this.simpleChart1.Size = new System.Drawing.Size(250, 159);
            this.simpleChart1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 280);
            this.Controls.Add(this.simpleChart1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private ControlUI.SimpleChart simpleChart1;

    }
}