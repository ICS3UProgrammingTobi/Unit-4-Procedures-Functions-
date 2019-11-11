namespace SwitchStatementTobi
{
    partial class frmSwitchStatement
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
            this.lblGradeLevel = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGradeLevel
            // 
            this.lblGradeLevel.AutoSize = true;
            this.lblGradeLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradeLevel.Location = new System.Drawing.Point(12, 43);
            this.lblGradeLevel.Name = "lblGradeLevel";
            this.lblGradeLevel.Size = new System.Drawing.Size(212, 25);
            this.lblGradeLevel.TabIndex = 0;
            this.lblGradeLevel.Text = "Enter a grade level";
            // 
            // txtGrade
            // 
            this.txtGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrade.Location = new System.Drawing.Point(262, 45);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(100, 24);
            this.txtGrade.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(116, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // frmSwitchStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 174);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.lblGradeLevel);
            this.Name = "frmSwitchStatement";
            this.Text = "Switch Statement Tobi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGradeLevel;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Button button1;
    }
}

