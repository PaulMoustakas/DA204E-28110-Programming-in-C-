namespace Assignment5
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
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.TBFeePerP = new System.Windows.Forms.TextBox();
            this.TBCostPerP = new System.Windows.Forms.TextBox();
            this.TBEventTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBoxParticipant = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnAddParticipant = new System.Windows.Forms.Button();
            this.CBCountry = new System.Windows.Forms.ComboBox();
            this.TBZipCode = new System.Windows.Forms.TextBox();
            this.TBCity = new System.Windows.Forms.TextBox();
            this.TBStreet = new System.Windows.Forms.TextBox();
            this.TBLastName = new System.Windows.Forms.TextBox();
            this.TBFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LBParticipants = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnChangeParticipant = new System.Windows.Forms.Button();
            this.BtnDeleteParticipant = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.LBSurplusDef = new System.Windows.Forms.Label();
            this.LBTotalFeesE = new System.Windows.Forms.Label();
            this.LBTotalCostE = new System.Windows.Forms.Label();
            this.LBNumOfParticipant = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.GroupBoxParticipant.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateEvent);
            this.groupBox1.Controls.Add(this.TBFeePerP);
            this.groupBox1.Controls.Add(this.TBCostPerP);
            this.groupBox1.Controls.Add(this.TBEventTitle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 243);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Event";
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.Location = new System.Drawing.Point(114, 193);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(203, 40);
            this.btnCreateEvent.TabIndex = 6;
            this.btnCreateEvent.Text = "Create Event";
            this.btnCreateEvent.UseVisualStyleBackColor = true;
            this.btnCreateEvent.Click += new System.EventHandler(this.BtnCreateEvent_Click);
            // 
            // TBFeePerP
            // 
            this.TBFeePerP.Location = new System.Drawing.Point(211, 122);
            this.TBFeePerP.Name = "TBFeePerP";
            this.TBFeePerP.Size = new System.Drawing.Size(169, 31);
            this.TBFeePerP.TabIndex = 5;
            // 
            // TBCostPerP
            // 
            this.TBCostPerP.Location = new System.Drawing.Point(211, 84);
            this.TBCostPerP.Name = "TBCostPerP";
            this.TBCostPerP.Size = new System.Drawing.Size(168, 31);
            this.TBCostPerP.TabIndex = 4;
            // 
            // TBEventTitle
            // 
            this.TBEventTitle.Location = new System.Drawing.Point(211, 47);
            this.TBEventTitle.Name = "TBEventTitle";
            this.TBEventTitle.Size = new System.Drawing.Size(169, 31);
            this.TBEventTitle.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fee per participant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cost per participant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event title";
            // 
            // GroupBoxParticipant
            // 
            this.GroupBoxParticipant.Controls.Add(this.label9);
            this.GroupBoxParticipant.Controls.Add(this.label8);
            this.GroupBoxParticipant.Controls.Add(this.label7);
            this.GroupBoxParticipant.Controls.Add(this.label6);
            this.GroupBoxParticipant.Controls.Add(this.BtnAddParticipant);
            this.GroupBoxParticipant.Controls.Add(this.CBCountry);
            this.GroupBoxParticipant.Controls.Add(this.TBZipCode);
            this.GroupBoxParticipant.Controls.Add(this.TBCity);
            this.GroupBoxParticipant.Controls.Add(this.TBStreet);
            this.GroupBoxParticipant.Controls.Add(this.TBLastName);
            this.GroupBoxParticipant.Controls.Add(this.TBFirstName);
            this.GroupBoxParticipant.Controls.Add(this.label5);
            this.GroupBoxParticipant.Controls.Add(this.label4);
            this.GroupBoxParticipant.Location = new System.Drawing.Point(37, 398);
            this.GroupBoxParticipant.Name = "GroupBoxParticipant";
            this.GroupBoxParticipant.Size = new System.Drawing.Size(410, 357);
            this.GroupBoxParticipant.TabIndex = 1;
            this.GroupBoxParticipant.TabStop = false;
            this.GroupBoxParticipant.Text = "Add participant";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Country";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Zip Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Street";
            // 
            // BtnAddParticipant
            // 
            this.BtnAddParticipant.Location = new System.Drawing.Point(114, 293);
            this.BtnAddParticipant.Name = "BtnAddParticipant";
            this.BtnAddParticipant.Size = new System.Drawing.Size(203, 44);
            this.BtnAddParticipant.TabIndex = 8;
            this.BtnAddParticipant.Text = "Add";
            this.BtnAddParticipant.UseVisualStyleBackColor = true;
            this.BtnAddParticipant.Click += new System.EventHandler(this.BtnAddParticipant_Click);
            // 
            // CBCountry
            // 
            this.CBCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCountry.FormattingEnabled = true;
            this.CBCountry.Location = new System.Drawing.Point(212, 231);
            this.CBCountry.Name = "CBCountry";
            this.CBCountry.Size = new System.Drawing.Size(168, 33);
            this.CBCountry.TabIndex = 7;
            // 
            // TBZipCode
            // 
            this.TBZipCode.Location = new System.Drawing.Point(211, 194);
            this.TBZipCode.Name = "TBZipCode";
            this.TBZipCode.Size = new System.Drawing.Size(169, 31);
            this.TBZipCode.TabIndex = 6;
            // 
            // TBCity
            // 
            this.TBCity.Location = new System.Drawing.Point(211, 157);
            this.TBCity.Name = "TBCity";
            this.TBCity.Size = new System.Drawing.Size(169, 31);
            this.TBCity.TabIndex = 5;
            // 
            // TBStreet
            // 
            this.TBStreet.Location = new System.Drawing.Point(212, 119);
            this.TBStreet.Name = "TBStreet";
            this.TBStreet.Size = new System.Drawing.Size(168, 31);
            this.TBStreet.TabIndex = 4;
            // 
            // TBLastName
            // 
            this.TBLastName.Location = new System.Drawing.Point(212, 82);
            this.TBLastName.Name = "TBLastName";
            this.TBLastName.Size = new System.Drawing.Size(168, 31);
            this.TBLastName.TabIndex = 3;
            // 
            // TBFirstName
            // 
            this.TBFirstName.Location = new System.Drawing.Point(211, 45);
            this.TBFirstName.Name = "TBFirstName";
            this.TBFirstName.Size = new System.Drawing.Size(168, 31);
            this.TBFirstName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "LastName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "First Name";
            // 
            // LBParticipants
            // 
            this.LBParticipants.FormattingEnabled = true;
            this.LBParticipants.ItemHeight = 25;
            this.LBParticipants.Location = new System.Drawing.Point(491, 90);
            this.LBParticipants.Name = "LBParticipants";
            this.LBParticipants.Size = new System.Drawing.Size(813, 279);
            this.LBParticipants.TabIndex = 2;
            this.LBParticipants.SelectedIndexChanged += new System.EventHandler(this.LBParticipants_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(522, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = " Participant";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(867, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 25);
            this.label11.TabIndex = 4;
            this.label11.Text = "Address";
            // 
            // BtnChangeParticipant
            // 
            this.BtnChangeParticipant.Location = new System.Drawing.Point(671, 380);
            this.BtnChangeParticipant.Name = "BtnChangeParticipant";
            this.BtnChangeParticipant.Size = new System.Drawing.Size(187, 43);
            this.BtnChangeParticipant.TabIndex = 5;
            this.BtnChangeParticipant.Text = "Change";
            this.BtnChangeParticipant.UseVisualStyleBackColor = true;
            this.BtnChangeParticipant.Click += new System.EventHandler(this.BtnChangeParticipant_Click);
            // 
            // BtnDeleteParticipant
            // 
            this.BtnDeleteParticipant.Location = new System.Drawing.Point(915, 380);
            this.BtnDeleteParticipant.Name = "BtnDeleteParticipant";
            this.BtnDeleteParticipant.Size = new System.Drawing.Size(187, 43);
            this.BtnDeleteParticipant.TabIndex = 6;
            this.BtnDeleteParticipant.Text = "Delete";
            this.BtnDeleteParticipant.UseVisualStyleBackColor = true;
            this.BtnDeleteParticipant.Click += new System.EventHandler(this.Btn_DeleteParticipant_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.LBSurplusDef);
            this.groupBox2.Controls.Add(this.LBTotalFeesE);
            this.groupBox2.Controls.Add(this.LBTotalCostE);
            this.groupBox2.Controls.Add(this.LBNumOfParticipant);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(671, 463);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 235);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Event economy";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Green;
            this.label15.Location = new System.Drawing.Point(6, 174);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(151, 25);
            this.label15.TabIndex = 8;
            this.label15.Text = "Surplus/Deficit";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Green;
            this.label14.Location = new System.Drawing.Point(6, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 25);
            this.label14.TabIndex = 7;
            this.label14.Text = "Total fees";
            // 
            // LBSurplusDef
            // 
            this.LBSurplusDef.AutoSize = true;
            this.LBSurplusDef.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LBSurplusDef.ForeColor = System.Drawing.Color.Green;
            this.LBSurplusDef.Location = new System.Drawing.Point(275, 172);
            this.LBSurplusDef.MinimumSize = new System.Drawing.Size(150, 0);
            this.LBSurplusDef.Name = "LBSurplusDef";
            this.LBSurplusDef.Size = new System.Drawing.Size(150, 27);
            this.LBSurplusDef.TabIndex = 6;
            this.LBSurplusDef.Text = "label14";
            // 
            // LBTotalFeesE
            // 
            this.LBTotalFeesE.AutoSize = true;
            this.LBTotalFeesE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LBTotalFeesE.ForeColor = System.Drawing.Color.Green;
            this.LBTotalFeesE.Location = new System.Drawing.Point(275, 135);
            this.LBTotalFeesE.MinimumSize = new System.Drawing.Size(150, 0);
            this.LBTotalFeesE.Name = "LBTotalFeesE";
            this.LBTotalFeesE.Size = new System.Drawing.Size(150, 27);
            this.LBTotalFeesE.TabIndex = 5;
            this.LBTotalFeesE.Text = "label14";
            // 
            // LBTotalCostE
            // 
            this.LBTotalCostE.AutoSize = true;
            this.LBTotalCostE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LBTotalCostE.ForeColor = System.Drawing.Color.Green;
            this.LBTotalCostE.Location = new System.Drawing.Point(275, 96);
            this.LBTotalCostE.MinimumSize = new System.Drawing.Size(150, 0);
            this.LBTotalCostE.Name = "LBTotalCostE";
            this.LBTotalCostE.Size = new System.Drawing.Size(150, 27);
            this.LBTotalCostE.TabIndex = 4;
            this.LBTotalCostE.Text = "label14";
            // 
            // LBNumOfParticipant
            // 
            this.LBNumOfParticipant.AutoSize = true;
            this.LBNumOfParticipant.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LBNumOfParticipant.ForeColor = System.Drawing.Color.Green;
            this.LBNumOfParticipant.Location = new System.Drawing.Point(275, 58);
            this.LBNumOfParticipant.MinimumSize = new System.Drawing.Size(150, 0);
            this.LBNumOfParticipant.Name = "LBNumOfParticipant";
            this.LBNumOfParticipant.Size = new System.Drawing.Size(150, 27);
            this.LBNumOfParticipant.TabIndex = 3;
            this.LBNumOfParticipant.Text = "NumOfPart";
            this.LBNumOfParticipant.Click += new System.EventHandler(this.LBNumOfParticipant_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Green;
            this.label13.Location = new System.Drawing.Point(6, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 25);
            this.label13.TabIndex = 1;
            this.label13.Text = "Total Cost";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Green;
            this.label12.Location = new System.Drawing.Point(6, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(228, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "Number of participants";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 814);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnDeleteParticipant);
            this.Controls.Add(this.BtnChangeParticipant);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LBParticipants);
            this.Controls.Add(this.GroupBoxParticipant);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Event Manager by Paul Moustakas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GroupBoxParticipant.ResumeLayout(false);
            this.GroupBoxParticipant.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBEventTitle;
        private System.Windows.Forms.TextBox TBFeePerP;
        private System.Windows.Forms.TextBox TBCostPerP;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.GroupBox GroupBoxParticipant;
        private System.Windows.Forms.Button BtnAddParticipant;
        private System.Windows.Forms.ComboBox CBCountry;
        private System.Windows.Forms.TextBox TBZipCode;
        private System.Windows.Forms.TextBox TBCity;
        private System.Windows.Forms.TextBox TBStreet;
        private System.Windows.Forms.TextBox TBLastName;
        private System.Windows.Forms.TextBox TBFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox LBParticipants;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnChangeParticipant;
        private System.Windows.Forms.Button BtnDeleteParticipant;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LBNumOfParticipant;
        private System.Windows.Forms.Label LBTotalCostE;
        private System.Windows.Forms.Label LBSurplusDef;
        private System.Windows.Forms.Label LBTotalFeesE;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}

