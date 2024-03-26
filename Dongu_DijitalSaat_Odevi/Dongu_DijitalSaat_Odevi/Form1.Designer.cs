namespace Dongu_DijitalSaat_Odevi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LbSaat = new System.Windows.Forms.Label();
            this.LbDakika = new System.Windows.Forms.Label();
            this.LbSaniye = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LbSaat
            // 
            this.LbSaat.AutoSize = true;
            this.LbSaat.Location = new System.Drawing.Point(46, 37);
            this.LbSaat.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LbSaat.Name = "LbSaat";
            this.LbSaat.Size = new System.Drawing.Size(47, 37);
            this.LbSaat.TabIndex = 0;
            this.LbSaat.Text = "00";
            // 
            // LbDakika
            // 
            this.LbDakika.AutoSize = true;
            this.LbDakika.Location = new System.Drawing.Point(113, 37);
            this.LbDakika.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LbDakika.Name = "LbDakika";
            this.LbDakika.Size = new System.Drawing.Size(47, 37);
            this.LbDakika.TabIndex = 1;
            this.LbDakika.Text = "00";
            // 
            // LbSaniye
            // 
            this.LbSaniye.AutoSize = true;
            this.LbSaniye.Location = new System.Drawing.Point(210, 37);
            this.LbSaniye.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LbSaniye.Name = "LbSaniye";
            this.LbSaniye.Size = new System.Drawing.Size(47, 37);
            this.LbSaniye.TabIndex = 2;
            this.LbSaniye.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 118);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbSaniye);
            this.Controls.Add(this.LbDakika);
            this.Controls.Add(this.LbSaat);
            this.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label LbSaat;
        private Label LbDakika;
        private Label LbSaniye;
        private Label label1;
        private Label label2;
    }
}