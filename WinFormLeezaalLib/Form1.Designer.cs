namespace WinFormLeezaalLib
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
            this.grpReader = new System.Windows.Forms.GroupBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblHat = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstReaders = new System.Windows.Forms.ListBox();
            this.grpCount = new System.Windows.Forms.GroupBox();
            this.lblBothCount = new System.Windows.Forms.Label();
            this.lblMagazine = new System.Windows.Forms.Label();
            this.lblHatCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbMagazineColors = new System.Windows.Forms.ComboBox();
            this.cmbHats = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddReader = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grpReader.SuspendLayout();
            this.grpCount.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpReader
            // 
            this.grpReader.Controls.Add(this.lblColor);
            this.grpReader.Controls.Add(this.lblHat);
            this.grpReader.Controls.Add(this.lblAge);
            this.grpReader.Controls.Add(this.label5);
            this.grpReader.Controls.Add(this.label4);
            this.grpReader.Controls.Add(this.label3);
            this.grpReader.Controls.Add(this.label2);
            this.grpReader.Controls.Add(this.label1);
            this.grpReader.Controls.Add(this.lstReaders);
            this.grpReader.Location = new System.Drawing.Point(12, 12);
            this.grpReader.Name = "grpReader";
            this.grpReader.Size = new System.Drawing.Size(630, 260);
            this.grpReader.TabIndex = 0;
            this.grpReader.TabStop = false;
            this.grpReader.Text = "Select Reader";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblColor.Location = new System.Drawing.Point(402, 220);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(49, 20);
            this.lblColor.TabIndex = 8;
            this.lblColor.Text = "Color";
            // 
            // lblHat
            // 
            this.lblHat.AutoSize = true;
            this.lblHat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblHat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHat.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblHat.Location = new System.Drawing.Point(402, 133);
            this.lblHat.Name = "lblHat";
            this.lblHat.Size = new System.Drawing.Size(36, 20);
            this.lblHat.TabIndex = 7;
            this.lblHat.Text = "Hat";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblAge.Location = new System.Drawing.Point(402, 97);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(38, 20);
            this.lblAge.TabIndex = 6;
            this.lblAge.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(216, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kleur :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "TijdSchrift :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "HoofdDeksel :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Leeftijd :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Persoon :";
            // 
            // lstReaders
            // 
            this.lstReaders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstReaders.FormattingEnabled = true;
            this.lstReaders.ItemHeight = 25;
            this.lstReaders.Location = new System.Drawing.Point(25, 73);
            this.lstReaders.Name = "lstReaders";
            this.lstReaders.Size = new System.Drawing.Size(144, 154);
            this.lstReaders.TabIndex = 0;
            this.lstReaders.SelectedIndexChanged += new System.EventHandler(this.lstReaders_click);
            // 
            // grpCount
            // 
            this.grpCount.Controls.Add(this.lblBothCount);
            this.grpCount.Controls.Add(this.lblMagazine);
            this.grpCount.Controls.Add(this.lblHatCount);
            this.grpCount.Controls.Add(this.label8);
            this.grpCount.Controls.Add(this.cmbMagazineColors);
            this.grpCount.Controls.Add(this.cmbHats);
            this.grpCount.Controls.Add(this.label7);
            this.grpCount.Controls.Add(this.label6);
            this.grpCount.Location = new System.Drawing.Point(12, 287);
            this.grpCount.Name = "grpCount";
            this.grpCount.Size = new System.Drawing.Size(630, 181);
            this.grpCount.TabIndex = 1;
            this.grpCount.TabStop = false;
            this.grpCount.Text = "Counts";
            // 
            // lblBothCount
            // 
            this.lblBothCount.AutoSize = true;
            this.lblBothCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBothCount.Location = new System.Drawing.Point(374, 149);
            this.lblBothCount.Name = "lblBothCount";
            this.lblBothCount.Size = new System.Drawing.Size(44, 20);
            this.lblBothCount.TabIndex = 11;
            this.lblBothCount.Text = "Both";
            this.lblBothCount.Click += new System.EventHandler(this.lblBothCount_Click);
            // 
            // lblMagazine
            // 
            this.lblMagazine.AutoSize = true;
            this.lblMagazine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMagazine.Location = new System.Drawing.Point(374, 109);
            this.lblMagazine.Name = "lblMagazine";
            this.lblMagazine.Size = new System.Drawing.Size(41, 20);
            this.lblMagazine.TabIndex = 10;
            this.lblMagazine.Text = "Mag";
            // 
            // lblHatCount
            // 
            this.lblHatCount.AutoSize = true;
            this.lblHatCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHatCount.Location = new System.Drawing.Point(374, 58);
            this.lblHatCount.Name = "lblHatCount";
            this.lblHatCount.Size = new System.Drawing.Size(36, 20);
            this.lblHatCount.TabIndex = 9;
            this.lblHatCount.Text = "Hat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(187, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Beide :";
            // 
            // cmbMagazineColors
            // 
            this.cmbMagazineColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMagazineColors.FormattingEnabled = true;
            this.cmbMagazineColors.Location = new System.Drawing.Point(191, 109);
            this.cmbMagazineColors.Name = "cmbMagazineColors";
            this.cmbMagazineColors.Size = new System.Drawing.Size(139, 24);
            this.cmbMagazineColors.TabIndex = 7;
            this.cmbMagazineColors.SelectedIndexChanged += new System.EventHandler(this.cmbMagazineColors_SelectedIndexChanged);
            // 
            // cmbHats
            // 
            this.cmbHats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHats.DropDownWidth = 176;
            this.cmbHats.FormattingEnabled = true;
            this.cmbHats.Location = new System.Drawing.Point(192, 59);
            this.cmbHats.Name = "cmbHats";
            this.cmbHats.Size = new System.Drawing.Size(138, 24);
            this.cmbHats.TabIndex = 6;
            this.cmbHats.SelectedIndexChanged += new System.EventHandler(this.cmbHats_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Kleur Tijdschrift :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "HoofdDeksel :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddReader);
            this.groupBox3.Controls.Add(this.txtAmount);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(12, 474);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(630, 165);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Reader(s)";
            // 
            // btnAddReader
            // 
            this.btnAddReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReader.Location = new System.Drawing.Point(416, 78);
            this.btnAddReader.Name = "btnAddReader";
            this.btnAddReader.Size = new System.Drawing.Size(127, 36);
            this.btnAddReader.TabIndex = 2;
            this.btnAddReader.Text = "Add";
            this.btnAddReader.UseVisualStyleBackColor = true;
            this.btnAddReader.Click += new System.EventHandler(this.btnAddReader_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(191, 80);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(147, 22);
            this.txtAmount.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Lezer Toevoegen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(780, 651);
            this.Controls.Add(this.grpReader);
            this.Controls.Add(this.grpCount);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "WpfLeesZaal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpReader.ResumeLayout(false);
            this.grpReader.PerformLayout();
            this.grpCount.ResumeLayout(false);
            this.grpCount.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpReader;
        private System.Windows.Forms.GroupBox grpCount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblHat;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstReaders;
        private System.Windows.Forms.Label lblBothCount;
        private System.Windows.Forms.Label lblMagazine;
        private System.Windows.Forms.Label lblHatCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbMagazineColors;
        private System.Windows.Forms.ComboBox cmbHats;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddReader;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label9;
    }
}

