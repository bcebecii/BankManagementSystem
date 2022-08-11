namespace den_2
{
    partial class krediOdeme
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
            this.components = new System.ComponentModel.Container();
            this.labelTarih = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.faiz = new System.Windows.Forms.TextBox();
            this.gfaiz = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.aylıkB = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.tarihSon = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTarih
            // 
            this.labelTarih.AutoSize = true;
            this.labelTarih.Location = new System.Drawing.Point(684, 9);
            this.labelTarih.Name = "labelTarih";
            this.labelTarih.Size = new System.Drawing.Size(44, 16);
            this.labelTarih.TabIndex = 0;
            this.labelTarih.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(75, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(544, 191);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(109, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ödemek İstediğiniz kredıyi seçiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ödenecek Miktar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ödeme tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Aylık Borç";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 63);
            this.button1.TabIndex = 6;
            this.button1.Text = "Borç Ödeme";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(640, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 88);
            this.button2.TabIndex = 7;
            this.button2.Text = "Toplu Borç Ödeme";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(663, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(663, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(663, 95);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(663, 123);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(179, 274);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowCheckBox = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(131, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(179, 315);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(131, 22);
            this.textBox5.TabIndex = 13;
            this.textBox5.Text = "0";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(179, 375);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(131, 22);
            this.textBox6.TabIndex = 14;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(640, 292);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(104, 22);
            this.textBox7.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(538, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Toplam Borc";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(508, 471);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(271, 157);
            this.dataGridView2.TabIndex = 17;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // faiz
            // 
            this.faiz.Location = new System.Drawing.Point(267, 606);
            this.faiz.Name = "faiz";
            this.faiz.Size = new System.Drawing.Size(110, 22);
            this.faiz.TabIndex = 18;
            // 
            // gfaiz
            // 
            this.gfaiz.Location = new System.Drawing.Point(392, 606);
            this.gfaiz.Name = "gfaiz";
            this.gfaiz.Size = new System.Drawing.Size(110, 22);
            this.gfaiz.TabIndex = 19;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(679, 151);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 22);
            this.textBox8.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(625, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Vade";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(631, 320);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(99, 22);
            this.textBox9.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(551, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Faiz Borç";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(679, 228);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 22);
            this.textBox10.TabIndex = 24;
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(217, 443);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(196, 147);
            this.dataGridView3.TabIndex = 25;
            // 
            // dataGridView4
            // 
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(41, 443);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(147, 123);
            this.dataGridView4.TabIndex = 26;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(41, 586);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(116, 22);
            this.textBox11.TabIndex = 27;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(324, 376);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 24;
            this.dataGridView5.Size = new System.Drawing.Size(89, 61);
            this.dataGridView5.TabIndex = 28;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(432, 381);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(119, 22);
            this.textBox12.TabIndex = 29;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(687, 179);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 22);
            this.textBox13.TabIndex = 30;
            // 
            // aylıkB
            // 
            this.aylıkB.AutoSize = true;
            this.aylıkB.Location = new System.Drawing.Point(628, 185);
            this.aylıkB.Name = "aylıkB";
            this.aylıkB.Size = new System.Drawing.Size(44, 16);
            this.aylıkB.TabIndex = 31;
            this.aylıkB.Text = "label8";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(385, 273);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(101, 22);
            this.textBox14.TabIndex = 32;
            // 
            // dataGridView6
            // 
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(860, 228);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.RowHeadersWidth = 51;
            this.dataGridView6.RowTemplate.Height = 24;
            this.dataGridView6.Size = new System.Drawing.Size(204, 156);
            this.dataGridView6.TabIndex = 33;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(857, 406);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(108, 22);
            this.textBox15.TabIndex = 34;
            // 
            // tarihSon
            // 
            this.tarihSon.Location = new System.Drawing.Point(865, 155);
            this.tarihSon.Name = "tarihSon";
            this.tarihSon.Size = new System.Drawing.Size(113, 22);
            this.tarihSon.TabIndex = 35;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(41, 637);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 32);
            this.button3.TabIndex = 36;
            this.button3.Text = "Geri";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // krediOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(200)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1102, 695);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tarihSon);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.dataGridView6);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.aylıkB);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.gfaiz);
            this.Controls.Add(this.faiz);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelTarih);
            this.Name = "krediOdeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "krediOdeme";
            this.Load += new System.EventHandler(this.krediOdeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelTarih;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox faiz;
        private System.Windows.Forms.TextBox gfaiz;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label aylıkB;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox tarihSon;
        private System.Windows.Forms.Button button3;
    }
}