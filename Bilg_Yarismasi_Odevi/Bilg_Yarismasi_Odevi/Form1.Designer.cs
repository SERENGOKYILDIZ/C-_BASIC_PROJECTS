namespace Bilg_Yarismasi_Odevi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LbSoruno = new System.Windows.Forms.Label();
            this.LbDogru = new System.Windows.Forms.Label();
            this.LbYanlis = new System.Windows.Forms.Label();
            this.BtnSoru = new System.Windows.Forms.Button();
            this.BtnA = new System.Windows.Forms.Button();
            this.BtnB = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnD = new System.Windows.Forms.Button();
            this.PicbYanlis = new System.Windows.Forms.PictureBox();
            this.PicbDogru = new System.Windows.Forms.PictureBox();
            this.TxtSoru = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicbYanlis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicbDogru)).BeginInit();
            this.SuspendLayout();
            // 
            // LbSoruno
            // 
            this.LbSoruno.AutoSize = true;
            this.LbSoruno.BackColor = System.Drawing.Color.DimGray;
            this.LbSoruno.ForeColor = System.Drawing.Color.White;
            this.LbSoruno.Location = new System.Drawing.Point(713, 215);
            this.LbSoruno.Name = "LbSoruno";
            this.LbSoruno.Size = new System.Drawing.Size(113, 28);
            this.LbSoruno.TabIndex = 1;
            this.LbSoruno.Text = "Soru No: 0";
            // 
            // LbDogru
            // 
            this.LbDogru.AutoSize = true;
            this.LbDogru.BackColor = System.Drawing.Color.DimGray;
            this.LbDogru.ForeColor = System.Drawing.Color.White;
            this.LbDogru.Location = new System.Drawing.Point(674, 260);
            this.LbDogru.Name = "LbDogru";
            this.LbDogru.Size = new System.Drawing.Size(152, 28);
            this.LbDogru.TabIndex = 2;
            this.LbDogru.Text = "Doğru Sayısı: 0";
            // 
            // LbYanlis
            // 
            this.LbYanlis.AutoSize = true;
            this.LbYanlis.BackColor = System.Drawing.Color.DimGray;
            this.LbYanlis.ForeColor = System.Drawing.Color.White;
            this.LbYanlis.Location = new System.Drawing.Point(679, 312);
            this.LbYanlis.Name = "LbYanlis";
            this.LbYanlis.Size = new System.Drawing.Size(147, 28);
            this.LbYanlis.TabIndex = 3;
            this.LbYanlis.Text = "Yanlış Sayısı: 0";
            // 
            // BtnSoru
            // 
            this.BtnSoru.Location = new System.Drawing.Point(682, 377);
            this.BtnSoru.Name = "BtnSoru";
            this.BtnSoru.Size = new System.Drawing.Size(144, 81);
            this.BtnSoru.TabIndex = 4;
            this.BtnSoru.Text = "BAŞLA";
            this.BtnSoru.UseVisualStyleBackColor = true;
            this.BtnSoru.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnA
            // 
            this.BtnA.Enabled = false;
            this.BtnA.Location = new System.Drawing.Point(12, 518);
            this.BtnA.Name = "BtnA";
            this.BtnA.Size = new System.Drawing.Size(299, 45);
            this.BtnA.TabIndex = 5;
            this.BtnA.Text = "A";
            this.BtnA.UseVisualStyleBackColor = true;
            this.BtnA.Click += new System.EventHandler(this.BtnA_Click);
            // 
            // BtnB
            // 
            this.BtnB.Enabled = false;
            this.BtnB.Location = new System.Drawing.Point(317, 518);
            this.BtnB.Name = "BtnB";
            this.BtnB.Size = new System.Drawing.Size(299, 45);
            this.BtnB.TabIndex = 6;
            this.BtnB.Text = "B";
            this.BtnB.UseVisualStyleBackColor = true;
            this.BtnB.Click += new System.EventHandler(this.BtnB_Click);
            // 
            // BtnC
            // 
            this.BtnC.Enabled = false;
            this.BtnC.Location = new System.Drawing.Point(12, 569);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(299, 45);
            this.BtnC.TabIndex = 7;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = true;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // BtnD
            // 
            this.BtnD.Enabled = false;
            this.BtnD.Location = new System.Drawing.Point(317, 569);
            this.BtnD.Name = "BtnD";
            this.BtnD.Size = new System.Drawing.Size(299, 45);
            this.BtnD.TabIndex = 8;
            this.BtnD.Text = "D";
            this.BtnD.UseVisualStyleBackColor = true;
            this.BtnD.Click += new System.EventHandler(this.BtnD_Click);
            // 
            // PicbYanlis
            // 
            this.PicbYanlis.Image = ((System.Drawing.Image)(resources.GetObject("PicbYanlis.Image")));
            this.PicbYanlis.Location = new System.Drawing.Point(770, 524);
            this.PicbYanlis.Name = "PicbYanlis";
            this.PicbYanlis.Size = new System.Drawing.Size(94, 90);
            this.PicbYanlis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicbYanlis.TabIndex = 9;
            this.PicbYanlis.TabStop = false;
            this.PicbYanlis.Visible = false;
            // 
            // PicbDogru
            // 
            this.PicbDogru.Image = ((System.Drawing.Image)(resources.GetObject("PicbDogru.Image")));
            this.PicbDogru.Location = new System.Drawing.Point(670, 524);
            this.PicbDogru.Name = "PicbDogru";
            this.PicbDogru.Size = new System.Drawing.Size(94, 90);
            this.PicbDogru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicbDogru.TabIndex = 10;
            this.PicbDogru.TabStop = false;
            this.PicbDogru.Visible = false;
            // 
            // TxtSoru
            // 
            this.TxtSoru.Location = new System.Drawing.Point(12, 198);
            this.TxtSoru.Name = "TxtSoru";
            this.TxtSoru.Size = new System.Drawing.Size(604, 301);
            this.TxtSoru.TabIndex = 11;
            this.TxtSoru.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(777, 43);
            this.label1.TabIndex = 12;
            this.label1.Text = "BİLGİ YARIŞMASINA HOŞGELDİNİZ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(876, 640);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSoru);
            this.Controls.Add(this.PicbDogru);
            this.Controls.Add(this.PicbYanlis);
            this.Controls.Add(this.BtnD);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnB);
            this.Controls.Add(this.BtnA);
            this.Controls.Add(this.BtnSoru);
            this.Controls.Add(this.LbYanlis);
            this.Controls.Add(this.LbDogru);
            this.Controls.Add(this.LbSoruno);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Bilgi Yarışması Oyunu";
            ((System.ComponentModel.ISupportInitialize)(this.PicbYanlis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicbDogru)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label LbSoruno;
        private Label LbDogru;
        private Label LbYanlis;
        private Button BtnSoru;
        private Button BtnA;
        private Button BtnB;
        private Button BtnC;
        private Button BtnD;
        private PictureBox PicbYanlis;
        private PictureBox PicbDogru;
        private RichTextBox TxtSoru;
        private Label label1;
    }
}