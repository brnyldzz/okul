namespace WindowsFormsApp1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gosterbutton = new System.Windows.Forms.Button();
            this.guncellebutton = new System.Windows.Forms.Button();
            this.silbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gsmtextBox = new System.Windows.Forms.TextBox();
            this.adtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idcomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.soyadtextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.gosterbutton);
            this.groupBox1.Controls.Add(this.guncellebutton);
            this.groupBox1.Controls.Add(this.silbutton);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.gsmtextBox);
            this.groupBox1.Controls.Add(this.soyadtextBox);
            this.groupBox1.Controls.Add(this.adtextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.idcomboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(8, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1327, 538);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(380, 31);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(924, 463);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // gosterbutton
            // 
            this.gosterbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gosterbutton.Location = new System.Drawing.Point(229, 464);
            this.gosterbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gosterbutton.Name = "gosterbutton";
            this.gosterbutton.Size = new System.Drawing.Size(100, 28);
            this.gosterbutton.TabIndex = 6;
            this.gosterbutton.Text = "Listele";
            this.gosterbutton.UseVisualStyleBackColor = true;
            this.gosterbutton.Click += new System.EventHandler(this.gosterbutton_Click);
            // 
            // guncellebutton
            // 
            this.guncellebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncellebutton.Location = new System.Drawing.Point(73, 464);
            this.guncellebutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guncellebutton.Name = "guncellebutton";
            this.guncellebutton.Size = new System.Drawing.Size(100, 28);
            this.guncellebutton.TabIndex = 5;
            this.guncellebutton.Text = "Güncelle";
            this.guncellebutton.UseVisualStyleBackColor = true;
            this.guncellebutton.Click += new System.EventHandler(this.guncellebutton_Click);
            // 
            // silbutton
            // 
            this.silbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silbutton.Location = new System.Drawing.Point(229, 410);
            this.silbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.silbutton.Name = "silbutton";
            this.silbutton.Size = new System.Drawing.Size(100, 28);
            this.silbutton.TabIndex = 4;
            this.silbutton.Text = "Sil";
            this.silbutton.UseVisualStyleBackColor = true;
            this.silbutton.Click += new System.EventHandler(this.silbutton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button1.Location = new System.Drawing.Point(73, 410);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gsmtextBox
            // 
            this.gsmtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gsmtextBox.Location = new System.Drawing.Point(169, 356);
            this.gsmtextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gsmtextBox.Name = "gsmtextBox";
            this.gsmtextBox.Size = new System.Drawing.Size(160, 23);
            this.gsmtextBox.TabIndex = 2;
            // 
            // adtextBox
            // 
            this.adtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adtextBox.Location = new System.Drawing.Point(169, 191);
            this.adtextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adtextBox.Name = "adtextBox";
            this.adtextBox.Size = new System.Drawing.Size(160, 23);
            this.adtextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 356);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "GSM:";
            // 
            // idcomboBox
            // 
            this.idcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.idcomboBox.FormattingEnabled = true;
            this.idcomboBox.Location = new System.Drawing.Point(169, 115);
            this.idcomboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idcomboBox.Name = "idcomboBox";
            this.idcomboBox.Size = new System.Drawing.Size(160, 25);
            this.idcomboBox.TabIndex = 1;
            this.idcomboBox.SelectedIndexChanged += new System.EventHandler(this.idcomboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Öğrenci ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 267);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Soyad:";
            // 
            // soyadtextBox
            // 
            this.soyadtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyadtextBox.Location = new System.Drawing.Point(169, 267);
            this.soyadtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.soyadtextBox.Name = "soyadtextBox";
            this.soyadtextBox.Size = new System.Drawing.Size(160, 23);
            this.soyadtextBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 635);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox gsmtextBox;
        private System.Windows.Forms.TextBox adtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox idcomboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button silbutton;
        private System.Windows.Forms.Button guncellebutton;
        private System.Windows.Forms.Button gosterbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox soyadtextBox;
        private System.Windows.Forms.Label label5;
    }
}

