namespace WindowsFormsAppMultiThread
{
    partial class frmMulti
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
            this.butnBasicThread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butnBasicThread
            // 
            this.butnBasicThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnBasicThread.Location = new System.Drawing.Point(32, 412);
            this.butnBasicThread.Name = "butnBasicThread";
            this.butnBasicThread.Size = new System.Drawing.Size(130, 49);
            this.butnBasicThread.TabIndex = 0;
            this.butnBasicThread.Text = "Thread ";
            this.butnBasicThread.UseVisualStyleBackColor = true;
            this.butnBasicThread.Click += new System.EventHandler(this.butnBasicThread_Click);
            // 
            // frmMulti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 495);
            this.Controls.Add(this.butnBasicThread);
            this.Name = "frmMulti";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butnBasicThread;
    }
}

