namespace den_2
{
    partial class MusteriEkle_BM
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
            this.texttemsilci = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtTemID = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.tBoxEPosta = new System.Windows.Forms.TextBox();
            this.tBoxNameSurname = new System.Windows.Forms.TextBox();
            this.tBoxTC = new System.Windows.Forms.TextBox();
            this.tBoxPhone = new System.Windows.Forms.TextBox();
            this.tBoxAddress = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.musteriEkleBTN = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // texttemsilci
            // 
            this.texttemsilci.Location = new System.Drawing.Point(415, 385);
            this.texttemsilci.Name = "texttemsilci";
            this.texttemsilci.Size = new System.Drawing.Size(113, 22);
            this.texttemsilci.TabIndex = 32;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(21, 530);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 32);
            this.button2.TabIndex = 31;
            this.button2.Text = "Geri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtTemID
            // 
            this.txtTemID.AutoSize = true;
            this.txtTemID.Location = new System.Drawing.Point(273, 521);
            this.txtTemID.Name = "txtTemID";
            this.txtTemID.Size = new System.Drawing.Size(60, 16);
            this.txtTemID.TabIndex = 30;
            this.txtTemID.Text = "txtTemID";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(42, 427);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(456, 44);
            this.dataGridView2.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(124, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(298, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Müşteri Kayıt bilgilerini giriniz.";
            // 
            // tBoxEPosta
            // 
            this.tBoxEPosta.Location = new System.Drawing.Point(207, 305);
            this.tBoxEPosta.Name = "tBoxEPosta";
            this.tBoxEPosta.Size = new System.Drawing.Size(244, 22);
            this.tBoxEPosta.TabIndex = 27;
            // 
            // tBoxNameSurname
            // 
            this.tBoxNameSurname.Location = new System.Drawing.Point(207, 59);
            this.tBoxNameSurname.Name = "tBoxNameSurname";
            this.tBoxNameSurname.Size = new System.Drawing.Size(244, 22);
            this.tBoxNameSurname.TabIndex = 26;
            this.tBoxNameSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxNameSurname_KeyPress);
            // 
            // tBoxTC
            // 
            this.tBoxTC.Location = new System.Drawing.Point(207, 122);
            this.tBoxTC.Name = "tBoxTC";
            this.tBoxTC.Size = new System.Drawing.Size(244, 22);
            this.tBoxTC.TabIndex = 25;
            this.tBoxTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxTC_KeyPress);
            // 
            // tBoxPhone
            // 
            this.tBoxPhone.Location = new System.Drawing.Point(207, 87);
            this.tBoxPhone.Name = "tBoxPhone";
            this.tBoxPhone.Size = new System.Drawing.Size(244, 22);
            this.tBoxPhone.TabIndex = 24;
            this.tBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxPhone_KeyPress);
            // 
            // tBoxAddress
            // 
            this.tBoxAddress.Location = new System.Drawing.Point(207, 160);
            this.tBoxAddress.Name = "tBoxAddress";
            this.tBoxAddress.Size = new System.Drawing.Size(244, 99);
            this.tBoxAddress.TabIndex = 23;
            this.tBoxAddress.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(47, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 22);
            this.label5.TabIndex = 22;
            this.label5.Text = "E-Posta :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(47, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Adres :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(47, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "TC :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(47, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Telefon Numarası :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(47, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ad Soyad :";
            // 
            // musteriEkleBTN
            // 
            this.musteriEkleBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriEkleBTN.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.musteriEkleBTN.Location = new System.Drawing.Point(193, 371);
            this.musteriEkleBTN.Name = "musteriEkleBTN";
            this.musteriEkleBTN.Size = new System.Drawing.Size(126, 36);
            this.musteriEkleBTN.TabIndex = 17;
            this.musteriEkleBTN.Text = "Ekle";
            this.musteriEkleBTN.UseVisualStyleBackColor = true;
            this.musteriEkleBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(454, -15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 18);
            this.label7.TabIndex = 33;
            this.label7.Text = "label7";
            // 
            // MusteriEkle_BM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(200)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(559, 590);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.texttemsilci);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtTemID);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tBoxEPosta);
            this.Controls.Add(this.tBoxNameSurname);
            this.Controls.Add(this.tBoxTC);
            this.Controls.Add(this.tBoxPhone);
            this.Controls.Add(this.tBoxAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.musteriEkleBTN);
            this.Name = "MusteriEkle_BM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusteriEkleMudur";
            this.Load += new System.EventHandler(this.MusteriEkleMudur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox texttemsilci;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label txtTemID;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBoxEPosta;
        private System.Windows.Forms.TextBox tBoxNameSurname;
        private System.Windows.Forms.TextBox tBoxTC;
        private System.Windows.Forms.TextBox tBoxPhone;
        private System.Windows.Forms.RichTextBox tBoxAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button musteriEkleBTN;
        public System.Windows.Forms.Label label7;
    }
}