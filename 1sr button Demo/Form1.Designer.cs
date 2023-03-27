namespace _1sr_button_Demo
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
            this.txt_full = new System.Windows.Forms.TextBox();
            this.btn_get = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Full Name";
            // 
            // txt_fname
            // 
            this.txt_fname.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fname.Location = new System.Drawing.Point(351, 94);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(473, 43);
            this.txt_fname.TabIndex = 3;
            // 
            // txt_lname
            // 
            this.txt_lname.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lname.Location = new System.Drawing.Point(351, 198);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(473, 43);
            this.txt_lname.TabIndex = 4;
            // 
            // txt_full
            // 
            this.txt_full.Enabled = false;
            this.txt_full.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_full.Location = new System.Drawing.Point(351, 411);
            this.txt_full.Name = "txt_full";
            this.txt_full.Size = new System.Drawing.Size(473, 43);
            this.txt_full.TabIndex = 5;
            // 
            // btn_get
            // 
            this.btn_get.Location = new System.Drawing.Point(450, 305);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(175, 47);
            this.btn_get.TabIndex = 6;
            this.btn_get.Text = "Get";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 658);
            this.Controls.Add(this.btn_get);
            this.Controls.Add(this.txt_full);
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
        private System.Windows.Forms.TextBox txt_full;
        private System.Windows.Forms.Button btn_get;
    }
}

