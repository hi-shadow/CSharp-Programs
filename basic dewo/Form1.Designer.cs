namespace basic_dewo
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.txt_mname = new System.Windows.Forms.TextBox();
            this.txt_full = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Middle Name";
            // 
            // txt_fname
            // 
            this.txt_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fname.Location = new System.Drawing.Point(255, 70);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(658, 39);
            this.txt_fname.TabIndex = 3;
            // 
            // txt_lname
            // 
            this.txt_lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lname.Location = new System.Drawing.Point(255, 229);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(658, 39);
            this.txt_lname.TabIndex = 4;
            // 
            // txt_mname
            // 
            this.txt_mname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mname.Location = new System.Drawing.Point(255, 146);
            this.txt_mname.Name = "txt_mname";
            this.txt_mname.Size = new System.Drawing.Size(658, 39);
            this.txt_mname.TabIndex = 5;
            // 
            // txt_full
            // 
            this.txt_full.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_full.Location = new System.Drawing.Point(43, 423);
            this.txt_full.Name = "txt_full";
            this.txt_full.ReadOnly = true;
            this.txt_full.Size = new System.Drawing.Size(968, 57);
            this.txt_full.TabIndex = 6;
            this.txt_full.Enter += new System.EventHandler(this.txt_full_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 612);
            this.Controls.Add(this.txt_full);
            this.Controls.Add(this.txt_mname);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.txt_fname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.TextBox txt_mname;
        private System.Windows.Forms.TextBox txt_full;
    }
}

