namespace WindowsFormsAppMyFirstApplication
{
    partial class frmMyFristApp
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
            this.butnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butnOK
            // 
            this.butnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnOK.Location = new System.Drawing.Point(775, 403);
            this.butnOK.Name = "butnOK";
            this.butnOK.Size = new System.Drawing.Size(107, 53);
            this.butnOK.TabIndex = 0;
            this.butnOK.Text = "OK";
            this.butnOK.UseVisualStyleBackColor = true;
            this.butnOK.Click += new System.EventHandler(this.butnOK_Click);
            // 
            // frmMyFristApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 468);
            this.Controls.Add(this.butnOK);
            this.Name = "frmMyFristApp";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butnOK;
    }
}

