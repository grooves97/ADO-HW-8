namespace SecurityApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonIn = new System.Windows.Forms.Button();
            this.buttonOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonIn
            // 
            this.buttonIn.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonIn.Location = new System.Drawing.Point(35, 126);
            this.buttonIn.Name = "buttonIn";
            this.buttonIn.Size = new System.Drawing.Size(176, 128);
            this.buttonIn.TabIndex = 0;
            this.buttonIn.Text = "button In";
            this.buttonIn.UseVisualStyleBackColor = false;
            this.buttonIn.Click += new System.EventHandler(this.ButtonIn_Click);
            // 
            // buttonOut
            // 
            this.buttonOut.BackColor = System.Drawing.Color.Red;
            this.buttonOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOut.Location = new System.Drawing.Point(271, 126);
            this.buttonOut.Name = "buttonOut";
            this.buttonOut.Size = new System.Drawing.Size(176, 128);
            this.buttonOut.TabIndex = 1;
            this.buttonOut.Text = "button Out";
            this.buttonOut.UseVisualStyleBackColor = false;
            this.buttonOut.Click += new System.EventHandler(this.ButtonOut_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(488, 345);
            this.Controls.Add(this.buttonOut);
            this.Controls.Add(this.buttonIn);
            this.Name = "MainForm";
            this.Text = "MainWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonIn;
        private System.Windows.Forms.Button buttonOut;
    }
}

