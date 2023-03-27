namespace LIztBox_Demo
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
            this.txt_city = new System.Windows.Forms.TextBox();
            this.btn_city = new System.Windows.Forms.Button();
            this.first_left = new System.Windows.Forms.ListBox();
            this.second_right = new System.Windows.Forms.ListBox();
            this.btn_all = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "city";
            // 
            // txt_city
            // 
            this.txt_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_city.Location = new System.Drawing.Point(366, 86);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(395, 44);
            this.txt_city.TabIndex = 1;
            // 
            // btn_city
            // 
            this.btn_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_city.Location = new System.Drawing.Point(539, 162);
            this.btn_city.Name = "btn_city";
            this.btn_city.Size = new System.Drawing.Size(232, 59);
            this.btn_city.TabIndex = 2;
            this.btn_city.Text = "Add City";
            this.btn_city.UseVisualStyleBackColor = true;
            this.btn_city.Click += new System.EventHandler(this.btn_city_Click);
            // 
            // first_left
            // 
            this.first_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_left.FormattingEnabled = true;
            this.first_left.ItemHeight = 37;
            this.first_left.Location = new System.Drawing.Point(12, 251);
            this.first_left.Name = "first_left";
            this.first_left.Size = new System.Drawing.Size(355, 226);
            this.first_left.TabIndex = 3;
            // 
            // second_right
            // 
            this.second_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.second_right.FormattingEnabled = true;
            this.second_right.ItemHeight = 37;
            this.second_right.Location = new System.Drawing.Point(576, 251);
            this.second_right.Name = "second_right";
            this.second_right.Size = new System.Drawing.Size(400, 226);
            this.second_right.TabIndex = 4;
            // 
            // btn_all
            // 
            this.btn_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_all.Location = new System.Drawing.Point(373, 251);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(197, 61);
            this.btn_all.TabIndex = 5;
            this.btn_all.Text = "all";
            this.btn_all.UseVisualStyleBackColor = true;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 613);
            this.Controls.Add(this.btn_all);
            this.Controls.Add(this.second_right);
            this.Controls.Add(this.first_left);
            this.Controls.Add(this.btn_city);
            this.Controls.Add(this.txt_city);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.Button btn_city;
        private System.Windows.Forms.ListBox first_left;
        private System.Windows.Forms.ListBox second_right;
        private System.Windows.Forms.Button btn_all;
    }
}

