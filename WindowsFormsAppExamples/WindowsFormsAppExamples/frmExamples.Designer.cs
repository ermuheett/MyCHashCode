namespace WindowsFormsAppExamples
{
    partial class frmExamples
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
            this.butnAccessSpecifier = new System.Windows.Forms.Button();
            this.butnSimpleClass = new System.Windows.Forms.Button();
            this.butnAccSpec = new System.Windows.Forms.Button();
            this.butnPrivate = new System.Windows.Forms.Button();
            this.butnProTect = new System.Windows.Forms.Button();
            this.butnStruc = new System.Windows.Forms.Button();
            this.butnEnum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butnAccessSpecifier
            // 
            this.butnAccessSpecifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnAccessSpecifier.Location = new System.Drawing.Point(12, 12);
            this.butnAccessSpecifier.Name = "butnAccessSpecifier";
            this.butnAccessSpecifier.Size = new System.Drawing.Size(118, 53);
            this.butnAccessSpecifier.TabIndex = 0;
            this.butnAccessSpecifier.Text = "Name Spaces ";
            this.butnAccessSpecifier.UseVisualStyleBackColor = true;
            this.butnAccessSpecifier.Click += new System.EventHandler(this.butnAccessSpecifier_Click);
            // 
            // butnSimpleClass
            // 
            this.butnSimpleClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnSimpleClass.Location = new System.Drawing.Point(12, 71);
            this.butnSimpleClass.Name = "butnSimpleClass";
            this.butnSimpleClass.Size = new System.Drawing.Size(118, 53);
            this.butnSimpleClass.TabIndex = 1;
            this.butnSimpleClass.Text = "Simple Class";
            this.butnSimpleClass.UseVisualStyleBackColor = true;
            this.butnSimpleClass.Click += new System.EventHandler(this.butnSimpleClass_Click);
            // 
            // butnAccSpec
            // 
            this.butnAccSpec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnAccSpec.Location = new System.Drawing.Point(12, 130);
            this.butnAccSpec.Name = "butnAccSpec";
            this.butnAccSpec.Size = new System.Drawing.Size(118, 53);
            this.butnAccSpec.TabIndex = 2;
            this.butnAccSpec.Text = "Access Specifier";
            this.butnAccSpec.UseVisualStyleBackColor = true;
            this.butnAccSpec.Click += new System.EventHandler(this.butnAccSpec_Click);
            // 
            // butnPrivate
            // 
            this.butnPrivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnPrivate.Location = new System.Drawing.Point(12, 189);
            this.butnPrivate.Name = "butnPrivate";
            this.butnPrivate.Size = new System.Drawing.Size(118, 53);
            this.butnPrivate.TabIndex = 3;
            this.butnPrivate.Text = "Private";
            this.butnPrivate.UseVisualStyleBackColor = true;
            this.butnPrivate.Click += new System.EventHandler(this.butnPrivate_Click);
            // 
            // butnProTect
            // 
            this.butnProTect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnProTect.Location = new System.Drawing.Point(12, 248);
            this.butnProTect.Name = "butnProTect";
            this.butnProTect.Size = new System.Drawing.Size(118, 53);
            this.butnProTect.TabIndex = 4;
            this.butnProTect.Text = "Protected";
            this.butnProTect.UseVisualStyleBackColor = true;
            this.butnProTect.Click += new System.EventHandler(this.butnProTect_Click);
            // 
            // butnStruc
            // 
            this.butnStruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnStruc.Location = new System.Drawing.Point(12, 307);
            this.butnStruc.Name = "butnStruc";
            this.butnStruc.Size = new System.Drawing.Size(118, 53);
            this.butnStruc.TabIndex = 5;
            this.butnStruc.Text = "Structures";
            this.butnStruc.UseVisualStyleBackColor = true;
            this.butnStruc.Click += new System.EventHandler(this.button1_Click);
            // 
            // butnEnum
            // 
            this.butnEnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnEnum.Location = new System.Drawing.Point(136, 12);
            this.butnEnum.Name = "butnEnum";
            this.butnEnum.Size = new System.Drawing.Size(118, 53);
            this.butnEnum.TabIndex = 6;
            this.butnEnum.Text = "Enumerator";
            this.butnEnum.UseVisualStyleBackColor = true;
            this.butnEnum.Click += new System.EventHandler(this.butnEnum_Click);
            // 
            // frmExamples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 481);
            this.Controls.Add(this.butnEnum);
            this.Controls.Add(this.butnStruc);
            this.Controls.Add(this.butnProTect);
            this.Controls.Add(this.butnPrivate);
            this.Controls.Add(this.butnAccSpec);
            this.Controls.Add(this.butnSimpleClass);
            this.Controls.Add(this.butnAccessSpecifier);
            this.Name = "frmExamples";
            this.Text = "Working with Classes";
            this.Load += new System.EventHandler(this.frmExamples_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butnAccessSpecifier;
        private System.Windows.Forms.Button butnSimpleClass;
        private System.Windows.Forms.Button butnAccSpec;
        private System.Windows.Forms.Button butnPrivate;
        private System.Windows.Forms.Button butnProTect;
        private System.Windows.Forms.Button butnStruc;
        private System.Windows.Forms.Button butnEnum;
    }
}

