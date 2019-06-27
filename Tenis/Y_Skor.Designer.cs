namespace Tenis
{
    partial class Y_Skor
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
            NesneTut = new System.Windows.Forms.Form();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            NesneTut.SuspendLayout();
          
            // 
            // NesneTut
            // 
            NesneTut.ClientSize = new System.Drawing.Size(284, 261);
            NesneTut.Controls.Add(this.button1);
            NesneTut.Controls.Add(this.textBox1);
            NesneTut.Location = new System.Drawing.Point(78, 78);
            NesneTut.Name = "NesneTut";
            NesneTut.Text = "Y_Skor";
            NesneTut.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 20);
            this.textBox1.TabIndex = 0;
            // 
            button1.Click += button1_Click;
            // Y_Skor
            // 
            NesneTut.ClientSize = new System.Drawing.Size(284, 261);
            NesneTut.Name = "Y_Skor";
            NesneTut.ResumeLayout(false);
            NesneTut.PerformLayout();
            NesneTut.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}