namespace LibertyTreeTavern
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
            this.checkBoxLincoln = new System.Windows.Forms.CheckBox();
            this.checkBoxContinental = new System.Windows.Forms.CheckBox();
            this.checkBoxJefferson = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNights = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxGuests = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxBreakfast = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxLincoln
            // 
            this.checkBoxLincoln.AutoSize = true;
            this.checkBoxLincoln.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxLincoln.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxLincoln.Location = new System.Drawing.Point(413, 123);
            this.checkBoxLincoln.Name = "checkBoxLincoln";
            this.checkBoxLincoln.Size = new System.Drawing.Size(15, 14);
            this.checkBoxLincoln.TabIndex = 0;
            this.checkBoxLincoln.UseVisualStyleBackColor = true;
            this.checkBoxLincoln.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxContinental
            // 
            this.checkBoxContinental.AutoSize = true;
            this.checkBoxContinental.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxContinental.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxContinental.Location = new System.Drawing.Point(413, 176);
            this.checkBoxContinental.Name = "checkBoxContinental";
            this.checkBoxContinental.Size = new System.Drawing.Size(15, 14);
            this.checkBoxContinental.TabIndex = 0;
            this.checkBoxContinental.UseVisualStyleBackColor = true;
            this.checkBoxContinental.CheckedChanged += new System.EventHandler(this.checkBoxContinental_CheckedChanged);
            // 
            // checkBoxJefferson
            // 
            this.checkBoxJefferson.AutoSize = true;
            this.checkBoxJefferson.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxJefferson.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxJefferson.Location = new System.Drawing.Point(413, 234);
            this.checkBoxJefferson.Name = "checkBoxJefferson";
            this.checkBoxJefferson.Size = new System.Drawing.Size(15, 14);
            this.checkBoxJefferson.TabIndex = 0;
            this.checkBoxJefferson.UseVisualStyleBackColor = true;
            this.checkBoxJefferson.CheckedChanged += new System.EventHandler(this.checkBoxJefferson_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liberty Tree Tavern\r\nBed and Breakfast";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxNights
            // 
            this.textBoxNights.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxNights.Location = new System.Drawing.Point(346, 352);
            this.textBoxNights.Name = "textBoxNights";
            this.textBoxNights.Size = new System.Drawing.Size(71, 29);
            this.textBoxNights.TabIndex = 2;
            this.textBoxNights.Text = "1";
            this.textBoxNights.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxNights.TextChanged += new System.EventHandler(this.textBoxNights_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(12, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "How many nights you want to stay?";
            // 
            // textBoxGuests
            // 
            this.textBoxGuests.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxGuests.Location = new System.Drawing.Point(346, 392);
            this.textBoxGuests.Name = "textBoxGuests";
            this.textBoxGuests.Size = new System.Drawing.Size(71, 29);
            this.textBoxGuests.TabIndex = 2;
            this.textBoxGuests.Text = "1";
            this.textBoxGuests.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxGuests.TextChanged += new System.EventHandler(this.textBoxGuests_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(12, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "How many individuals will be staying?";
            // 
            // listBoxBreakfast
            // 
            this.listBoxBreakfast.FormattingEnabled = true;
            this.listBoxBreakfast.ItemHeight = 22;
            this.listBoxBreakfast.Items.AddRange(new object[] {
            "Continental – free",
            "Full Breakfast - $6.99 per guest",
            "Deluxe Breakfast - $10.99 per guest"});
            this.listBoxBreakfast.Location = new System.Drawing.Point(54, 472);
            this.listBoxBreakfast.Name = "listBoxBreakfast";
            this.listBoxBreakfast.Size = new System.Drawing.Size(305, 70);
            this.listBoxBreakfast.TabIndex = 4;
            this.listBoxBreakfast.SelectedIndexChanged += new System.EventHandler(this.listBoxBreakfast_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(12, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Breakfast Options:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(222, 586);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(0, 22);
            this.labelTotal.TabIndex = 6;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(23, 118);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(311, 22);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "The Lincoln Suite - $110.00 per night";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.Red;
            this.linkLabel2.Location = new System.Drawing.Point(23, 171);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(355, 22);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "The Continental Room  - $120.00 per night";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.LinkColor = System.Drawing.Color.Red;
            this.linkLabel3.Location = new System.Drawing.Point(30, 229);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(330, 22);
            this.linkLabel3.TabIndex = 7;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "The Jefferson Cabin - $150.00 per night";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 586);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(478, 679);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.listBoxBreakfast);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxGuests);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNights);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxJefferson);
            this.Controls.Add(this.checkBoxContinental);
            this.Controls.Add(this.checkBoxLincoln);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Liberty Tree Tavern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxLincoln;
        private System.Windows.Forms.CheckBox checkBoxContinental;
        private System.Windows.Forms.CheckBox checkBoxJefferson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNights;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxGuests;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxBreakfast;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label label5;
    }
}

