namespace WindowsFormsAppImplicitExplicit
{
    partial class frmImplicitExplicit
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
            this.butnImplicit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butnImplicit
            // 
            this.butnImplicit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnImplicit.Location = new System.Drawing.Point(34, 12);
            this.butnImplicit.Name = "butnImplicit";
            this.butnImplicit.Size = new System.Drawing.Size(130, 69);
            this.butnImplicit.TabIndex = 0;
            this.butnImplicit.Text = "Implicit Conversion";
            this.butnImplicit.UseVisualStyleBackColor = true;
            this.butnImplicit.Click += new System.EventHandler(this.butnImplicit_Click);
            // 
            // frmImplicitExplicit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 580);
            this.Controls.Add(this.butnImplicit);
            this.Name = "frmImplicitExplicit";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butnImplicit;
    }
}

