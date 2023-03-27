namespace Calculate_Simple_Interest
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
            this.label4 = new System.Windows.Forms.Label();
            this.txt_p = new System.Windows.Forms.TextBox();
            this.txt_r = new System.Windows.Forms.TextBox();
            this.txt_n = new System.Windows.Forms.TextBox();
            this.txt_si = new System.Windows.Forms.TextBox();
            this.btn_si = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 59);
            this.label2.TabIndex = 1;
            this.label2.Text = "N";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 59);
            this.label3.TabIndex = 2;
            this.label3.Text = "P";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(233, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 59);
            this.label4.TabIndex = 3;
            this.label4.Text = "SI";
            // 
            // txt_p
            // 
            this.txt_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p.Location = new System.Drawing.Point(384, 63);
            this.txt_p.Name = "txt_p";
            this.txt_p.Size = new System.Drawing.Size(546, 53);
            this.txt_p.TabIndex = 4;
            // 
            // txt_r
            // 
            this.txt_r.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_r.Location = new System.Drawing.Point(384, 150);
            this.txt_r.Name = "txt_r";
            this.txt_r.Size = new System.Drawing.Size(546, 53);
            this.txt_r.TabIndex = 5;
            // 
            // txt_n
            // 
            this.txt_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_n.Location = new System.Drawing.Point(384, 234);
            this.txt_n.Name = "txt_n";
            this.txt_n.Size = new System.Drawing.Size(546, 53);
            this.txt_n.TabIndex = 6;
            // 
            // txt_si
            // 
            this.txt_si.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_si.Location = new System.Drawing.Point(384, 338);
            this.txt_si.Name = "txt_si";
            this.txt_si.ReadOnly = true;
            this.txt_si.Size = new System.Drawing.Size(546, 53);
            this.txt_si.TabIndex = 7;
            // 
            // btn_si
            // 
            this.btn_si.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_si.Location = new System.Drawing.Point(470, 440);
            this.btn_si.Name = "btn_si";
            this.btn_si.Size = new System.Drawing.Size(317, 71);
            this.btn_si.TabIndex = 8;
            this.btn_si.Text = "Get SI";
            this.btn_si.UseVisualStyleBackColor = true;
            this.btn_si.Click += new System.EventHandler(this.btn_si_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 643);
            this.Controls.Add(this.btn_si);
            this.Controls.Add(this.txt_si);
            this.Controls.Add(this.txt_n);
            this.Controls.Add(this.txt_r);
            this.Controls.Add(this.txt_p);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_p;
        private System.Windows.Forms.TextBox txt_r;
        private System.Windows.Forms.TextBox txt_n;
        private System.Windows.Forms.TextBox txt_si;
        private System.Windows.Forms.Button btn_si;
    }
}

