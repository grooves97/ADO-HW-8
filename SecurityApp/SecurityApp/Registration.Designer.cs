namespace SecurityApp
{
    partial class Registration
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
            this.textBoxFullname = new System.Windows.Forms.TextBox();
            this.textBoxPurpose = new System.Windows.Forms.TextBox();
            this.labelFullname = new System.Windows.Forms.Label();
            this.labelDocument = new System.Windows.Forms.Label();
            this.labelPurpose = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.maskedTextBoxDocument = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // textBoxFullname
            // 
            this.textBoxFullname.Location = new System.Drawing.Point(154, 40);
            this.textBoxFullname.Name = "textBoxFullname";
            this.textBoxFullname.Size = new System.Drawing.Size(100, 20);
            this.textBoxFullname.TabIndex = 0;
            // 
            // textBoxPurpose
            // 
            this.textBoxPurpose.Location = new System.Drawing.Point(154, 143);
            this.textBoxPurpose.Name = "textBoxPurpose";
            this.textBoxPurpose.Size = new System.Drawing.Size(100, 20);
            this.textBoxPurpose.TabIndex = 2;
            // 
            // labelFullname
            // 
            this.labelFullname.AutoSize = true;
            this.labelFullname.Location = new System.Drawing.Point(45, 40);
            this.labelFullname.Name = "labelFullname";
            this.labelFullname.Size = new System.Drawing.Size(49, 13);
            this.labelFullname.TabIndex = 3;
            this.labelFullname.Text = "Fullname";
            // 
            // labelDocument
            // 
            this.labelDocument.AutoSize = true;
            this.labelDocument.Location = new System.Drawing.Point(45, 95);
            this.labelDocument.Name = "labelDocument";
            this.labelDocument.Size = new System.Drawing.Size(96, 13);
            this.labelDocument.TabIndex = 4;
            this.labelDocument.Text = "Document Number";
            // 
            // labelPurpose
            // 
            this.labelPurpose.AutoSize = true;
            this.labelPurpose.Location = new System.Drawing.Point(45, 143);
            this.labelPurpose.Name = "labelPurpose";
            this.labelPurpose.Size = new System.Drawing.Size(79, 13);
            this.labelPurpose.TabIndex = 5;
            this.labelPurpose.Text = "Purpose of visit";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(48, 191);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 6;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // maskedTextBoxDocument
            // 
            this.maskedTextBoxDocument.Location = new System.Drawing.Point(154, 95);
            this.maskedTextBoxDocument.Mask = "000-000-000";
            this.maskedTextBoxDocument.Name = "maskedTextBoxDocument";
            this.maskedTextBoxDocument.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxDocument.TabIndex = 7;
            this.maskedTextBoxDocument.Tag = "ИИН";
            this.maskedTextBoxDocument.ValidatingType = typeof(int);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(293, 260);
            this.Controls.Add(this.maskedTextBoxDocument);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelPurpose);
            this.Controls.Add(this.labelDocument);
            this.Controls.Add(this.labelFullname);
            this.Controls.Add(this.textBoxPurpose);
            this.Controls.Add(this.textBoxFullname);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFullname;
        private System.Windows.Forms.TextBox textBoxPurpose;
        private System.Windows.Forms.Label labelFullname;
        private System.Windows.Forms.Label labelDocument;
        private System.Windows.Forms.Label labelPurpose;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDocument;
    }
}