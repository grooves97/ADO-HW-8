namespace SecurityApp
{
    partial class UnRegistration
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
            this.labelDocument = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.maskedTextBoxDocument = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // labelDocument
            // 
            this.labelDocument.AutoSize = true;
            this.labelDocument.Location = new System.Drawing.Point(47, 79);
            this.labelDocument.Name = "labelDocument";
            this.labelDocument.Size = new System.Drawing.Size(94, 13);
            this.labelDocument.TabIndex = 0;
            this.labelDocument.Text = "Document number";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(50, 138);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 2;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // maskedTextBoxDocument
            // 
            this.maskedTextBoxDocument.Location = new System.Drawing.Point(162, 76);
            this.maskedTextBoxDocument.Mask = "000-000-000";
            this.maskedTextBoxDocument.Name = "maskedTextBoxDocument";
            this.maskedTextBoxDocument.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxDocument.TabIndex = 3;
            this.maskedTextBoxDocument.ValidatingType = typeof(int);
            // 
            // UnRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 232);
            this.Controls.Add(this.maskedTextBoxDocument);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelDocument);
            this.Name = "UnRegistration";
            this.Text = "UnRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDocument;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDocument;
    }
}