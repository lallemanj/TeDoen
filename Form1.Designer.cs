namespace TeDoen
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbTitel = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tbForm = new System.Windows.Forms.TextBox();
            this.btn_VerwijderTaak = new System.Windows.Forms.Button();
            this.btn_Achteraan = new System.Windows.Forms.Button();
            this.btn_MessageBox = new System.Windows.Forms.Button();
            this.btn_Form = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOmschrijving = new System.Windows.Forms.TextBox();
            this.btn_Volgende = new System.Windows.Forms.Button();
            this.dtp_Datum = new System.Windows.Forms.DateTimePicker();
            this.btn_Opslaan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titel / Omschrijving";
            // 
            // tbTitel
            // 
            this.tbTitel.Location = new System.Drawing.Point(168, 93);
            this.tbTitel.Name = "tbTitel";
            this.tbTitel.Size = new System.Drawing.Size(374, 23);
            this.tbTitel.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(172, 274);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(156, 19);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Moet gedaan worden op";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tbForm
            // 
            this.tbForm.Location = new System.Drawing.Point(168, 350);
            this.tbForm.Multiline = true;
            this.tbForm.Name = "tbForm";
            this.tbForm.ReadOnly = true;
            this.tbForm.Size = new System.Drawing.Size(445, 222);
            this.tbForm.TabIndex = 3;
            // 
            // btn_VerwijderTaak
            // 
            this.btn_VerwijderTaak.Location = new System.Drawing.Point(692, 93);
            this.btn_VerwijderTaak.Name = "btn_VerwijderTaak";
            this.btn_VerwijderTaak.Size = new System.Drawing.Size(140, 33);
            this.btn_VerwijderTaak.TabIndex = 4;
            this.btn_VerwijderTaak.Text = "verwijder taak";
            this.btn_VerwijderTaak.UseVisualStyleBackColor = true;
            this.btn_VerwijderTaak.Click += new System.EventHandler(this.btn_VerwijderTaak_Click);
            // 
            // btn_Achteraan
            // 
            this.btn_Achteraan.Location = new System.Drawing.Point(692, 194);
            this.btn_Achteraan.Name = "btn_Achteraan";
            this.btn_Achteraan.Size = new System.Drawing.Size(140, 33);
            this.btn_Achteraan.TabIndex = 6;
            this.btn_Achteraan.Text = "zet achteraan";
            this.btn_Achteraan.UseVisualStyleBackColor = true;
            this.btn_Achteraan.Click += new System.EventHandler(this.btn_Achteraan_Click);
            // 
            // btn_MessageBox
            // 
            this.btn_MessageBox.BackColor = System.Drawing.Color.Red;
            this.btn_MessageBox.Location = new System.Drawing.Point(692, 396);
            this.btn_MessageBox.Name = "btn_MessageBox";
            this.btn_MessageBox.Size = new System.Drawing.Size(140, 41);
            this.btn_MessageBox.TabIndex = 7;
            this.btn_MessageBox.Text = "MessageBox UIT";
            this.btn_MessageBox.UseVisualStyleBackColor = false;
            this.btn_MessageBox.Click += new System.EventHandler(this.btn_MessageBox_Click);
            // 
            // btn_Form
            // 
            this.btn_Form.BackColor = System.Drawing.Color.Red;
            this.btn_Form.Location = new System.Drawing.Point(692, 456);
            this.btn_Form.Name = "btn_Form";
            this.btn_Form.Size = new System.Drawing.Size(140, 36);
            this.btn_Form.TabIndex = 8;
            this.btn_Form.Text = "Toon in form UIT";
            this.btn_Form.UseVisualStyleBackColor = false;
            this.btn_Form.Click += new System.EventHandler(this.btn_Form_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Taak in form";
            // 
            // tbOmschrijving
            // 
            this.tbOmschrijving.Location = new System.Drawing.Point(169, 122);
            this.tbOmschrijving.Multiline = true;
            this.tbOmschrijving.Name = "tbOmschrijving";
            this.tbOmschrijving.Size = new System.Drawing.Size(373, 133);
            this.tbOmschrijving.TabIndex = 10;
            // 
            // btn_Volgende
            // 
            this.btn_Volgende.Location = new System.Drawing.Point(692, 142);
            this.btn_Volgende.Name = "btn_Volgende";
            this.btn_Volgende.Size = new System.Drawing.Size(140, 35);
            this.btn_Volgende.TabIndex = 5;
            this.btn_Volgende.Text = "volgende";
            this.btn_Volgende.UseVisualStyleBackColor = true;
            this.btn_Volgende.Click += new System.EventHandler(this.btn_Volgende_Click);
            // 
            // dtp_Datum
            // 
            this.dtp_Datum.CustomFormat = "HH:mm // dd-MM-yyyy ";
            this.dtp_Datum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Datum.Location = new System.Drawing.Point(334, 270);
            this.dtp_Datum.Name = "dtp_Datum";
            this.dtp_Datum.Size = new System.Drawing.Size(200, 23);
            this.dtp_Datum.TabIndex = 11;
            // 
            // btn_Opslaan
            // 
            this.btn_Opslaan.Location = new System.Drawing.Point(552, 266);
            this.btn_Opslaan.Name = "btn_Opslaan";
            this.btn_Opslaan.Size = new System.Drawing.Size(106, 33);
            this.btn_Opslaan.TabIndex = 12;
            this.btn_Opslaan.Text = "opslaan taak";
            this.btn_Opslaan.UseVisualStyleBackColor = true;
            this.btn_Opslaan.Click += new System.EventHandler(this.btn_Opslaan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 621);
            this.Controls.Add(this.btn_Opslaan);
            this.Controls.Add(this.dtp_Datum);
            this.Controls.Add(this.tbOmschrijving);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Form);
            this.Controls.Add(this.btn_MessageBox);
            this.Controls.Add(this.btn_Achteraan);
            this.Controls.Add(this.btn_Volgende);
            this.Controls.Add(this.btn_VerwijderTaak);
            this.Controls.Add(this.tbForm);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tbTitel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTitel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox tbForm;
        private System.Windows.Forms.Button btn_VerwijderTaak;
        private System.Windows.Forms.Button btn_Achteraan;
        private System.Windows.Forms.Button btn_MessageBox;
        private System.Windows.Forms.Button btn_Form;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOmschrijving;
        private System.Windows.Forms.Button btn_Volgende;
        private System.Windows.Forms.DateTimePicker dtp_Datum;
        private System.Windows.Forms.Button btn_Opslaan;
    }
}

