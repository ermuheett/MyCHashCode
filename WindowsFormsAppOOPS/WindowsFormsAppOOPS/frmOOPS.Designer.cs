namespace WindowsFormsAppOOPS
{
    partial class frmOOPS
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
            this.butnStaticVar = new System.Windows.Forms.Button();
            this.butnStaticFunc = new System.Windows.Forms.Button();
            this.butnInherit = new System.Windows.Forms.Button();
            this.butnMultiInher = new System.Windows.Forms.Button();
            this.butnPolyMor = new System.Windows.Forms.Button();
            this.butnStaticClass = new System.Windows.Forms.Button();
            this.butnParClass = new System.Windows.Forms.Button();
            this.butnAilas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butnStaticVar
            // 
            this.butnStaticVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnStaticVar.Location = new System.Drawing.Point(12, 12);
            this.butnStaticVar.Name = "butnStaticVar";
            this.butnStaticVar.Size = new System.Drawing.Size(129, 60);
            this.butnStaticVar.TabIndex = 0;
            this.butnStaticVar.Text = "Static Variables";
            this.butnStaticVar.UseVisualStyleBackColor = true;
            this.butnStaticVar.Click += new System.EventHandler(this.butnStaticVar_Click);
            // 
            // butnStaticFunc
            // 
            this.butnStaticFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnStaticFunc.Location = new System.Drawing.Point(12, 78);
            this.butnStaticFunc.Name = "butnStaticFunc";
            this.butnStaticFunc.Size = new System.Drawing.Size(129, 60);
            this.butnStaticFunc.TabIndex = 1;
            this.butnStaticFunc.Text = "Static Function";
            this.butnStaticFunc.UseVisualStyleBackColor = true;
            this.butnStaticFunc.Click += new System.EventHandler(this.butnStaticFunc_Click);
            // 
            // butnInherit
            // 
            this.butnInherit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnInherit.Location = new System.Drawing.Point(12, 144);
            this.butnInherit.Name = "butnInherit";
            this.butnInherit.Size = new System.Drawing.Size(129, 60);
            this.butnInherit.TabIndex = 2;
            this.butnInherit.Text = "Inheritance";
            this.butnInherit.UseVisualStyleBackColor = true;
            this.butnInherit.Click += new System.EventHandler(this.butnInherit_Click);
            // 
            // butnMultiInher
            // 
            this.butnMultiInher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnMultiInher.Location = new System.Drawing.Point(12, 210);
            this.butnMultiInher.Name = "butnMultiInher";
            this.butnMultiInher.Size = new System.Drawing.Size(129, 60);
            this.butnMultiInher.TabIndex = 3;
            this.butnMultiInher.Text = "Multi Inheritance";
            this.butnMultiInher.UseVisualStyleBackColor = true;
            this.butnMultiInher.Click += new System.EventHandler(this.butnMultiInher_Click);
            // 
            // butnPolyMor
            // 
            this.butnPolyMor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnPolyMor.Location = new System.Drawing.Point(12, 276);
            this.butnPolyMor.Name = "butnPolyMor";
            this.butnPolyMor.Size = new System.Drawing.Size(129, 60);
            this.butnPolyMor.TabIndex = 4;
            this.butnPolyMor.Text = "Polymorphism";
            this.butnPolyMor.UseVisualStyleBackColor = true;
            this.butnPolyMor.Click += new System.EventHandler(this.butnPolyMor_Click);
            // 
            // butnStaticClass
            // 
            this.butnStaticClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnStaticClass.Location = new System.Drawing.Point(12, 342);
            this.butnStaticClass.Name = "butnStaticClass";
            this.butnStaticClass.Size = new System.Drawing.Size(129, 60);
            this.butnStaticClass.TabIndex = 5;
            this.butnStaticClass.Text = "Static Class";
            this.butnStaticClass.UseVisualStyleBackColor = true;
            this.butnStaticClass.Click += new System.EventHandler(this.butnStaticClass_Click);
            // 
            // butnParClass
            // 
            this.butnParClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnParClass.Location = new System.Drawing.Point(147, 12);
            this.butnParClass.Name = "butnParClass";
            this.butnParClass.Size = new System.Drawing.Size(129, 60);
            this.butnParClass.TabIndex = 6;
            this.butnParClass.Text = "Partial Class";
            this.butnParClass.UseVisualStyleBackColor = true;
            this.butnParClass.Click += new System.EventHandler(this.butnParClass_Click);
            // 
            // butnAilas
            // 
            this.butnAilas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnAilas.Location = new System.Drawing.Point(147, 78);
            this.butnAilas.Name = "butnAilas";
            this.butnAilas.Size = new System.Drawing.Size(129, 60);
            this.butnAilas.TabIndex = 7;
            this.butnAilas.Text = "Alias";
            this.butnAilas.UseVisualStyleBackColor = true;
            this.butnAilas.Click += new System.EventHandler(this.butnAilas_Click);
            // 
            // frmOOPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 714);
            this.Controls.Add(this.butnAilas);
            this.Controls.Add(this.butnParClass);
            this.Controls.Add(this.butnStaticClass);
            this.Controls.Add(this.butnPolyMor);
            this.Controls.Add(this.butnMultiInher);
            this.Controls.Add(this.butnInherit);
            this.Controls.Add(this.butnStaticFunc);
            this.Controls.Add(this.butnStaticVar);
            this.Name = "frmOOPS";
            this.Text = "Working with OOPS";
            this.Load += new System.EventHandler(this.frmOOPS_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butnStaticVar;
        private System.Windows.Forms.Button butnStaticFunc;
        private System.Windows.Forms.Button butnInherit;
        private System.Windows.Forms.Button butnMultiInher;
        private System.Windows.Forms.Button butnPolyMor;
        private System.Windows.Forms.Button butnStaticClass;
        private System.Windows.Forms.Button butnParClass;
        private System.Windows.Forms.Button butnAilas;
    }
}

