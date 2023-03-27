namespace Calculator
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
            this.txt_x = new System.Windows.Forms.TextBox();
            this.txt_ans = new System.Windows.Forms.TextBox();
            this.txt_y = new System.Windows.Forms.TextBox();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_mul = new System.Windows.Forms.Button();
            this.btn_odd_even = new System.Windows.Forms.Button();
            this.btn_min_max = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_swap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ans";
            // 
            // txt_x
            // 
            this.txt_x.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_x.Location = new System.Drawing.Point(346, 88);
            this.txt_x.Name = "txt_x";
            this.txt_x.Size = new System.Drawing.Size(650, 50);
            this.txt_x.TabIndex = 3;
            // 
            // txt_ans
            // 
            this.txt_ans.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ans.Location = new System.Drawing.Point(346, 245);
            this.txt_ans.Name = "txt_ans";
            this.txt_ans.ReadOnly = true;
            this.txt_ans.Size = new System.Drawing.Size(650, 50);
            this.txt_ans.TabIndex = 4;
            // 
            // txt_y
            // 
            this.txt_y.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_y.Location = new System.Drawing.Point(346, 170);
            this.txt_y.Name = "txt_y";
            this.txt_y.Size = new System.Drawing.Size(650, 50);
            this.txt_y.TabIndex = 5;
            // 
            // btn_plus
            // 
            this.btn_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plus.Location = new System.Drawing.Point(198, 351);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(89, 68);
            this.btn_plus.TabIndex = 6;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minus.Location = new System.Drawing.Point(360, 351);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(89, 68);
            this.btn_minus.TabIndex = 7;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_div
            // 
            this.btn_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_div.Location = new System.Drawing.Point(679, 351);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(89, 68);
            this.btn_div.TabIndex = 9;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // btn_mul
            // 
            this.btn_mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mul.Location = new System.Drawing.Point(517, 351);
            this.btn_mul.Name = "btn_mul";
            this.btn_mul.Size = new System.Drawing.Size(89, 68);
            this.btn_mul.TabIndex = 8;
            this.btn_mul.Text = "*";
            this.btn_mul.UseVisualStyleBackColor = true;
            this.btn_mul.Click += new System.EventHandler(this.btn_mul_Click);
            // 
            // btn_odd_even
            // 
            this.btn_odd_even.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_odd_even.Location = new System.Drawing.Point(198, 455);
            this.btn_odd_even.Name = "btn_odd_even";
            this.btn_odd_even.Size = new System.Drawing.Size(251, 68);
            this.btn_odd_even.TabIndex = 10;
            this.btn_odd_even.Text = "Odd - Even";
            this.btn_odd_even.UseVisualStyleBackColor = true;
            this.btn_odd_even.Click += new System.EventHandler(this.btn_odd_even_Click);
            // 
            // btn_min_max
            // 
            this.btn_min_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_min_max.Location = new System.Drawing.Point(517, 455);
            this.btn_min_max.Name = "btn_min_max";
            this.btn_min_max.Size = new System.Drawing.Size(251, 68);
            this.btn_min_max.TabIndex = 11;
            this.btn_min_max.Text = "Min - Max";
            this.btn_min_max.UseVisualStyleBackColor = true;
            this.btn_min_max.Click += new System.EventHandler(this.btn_min_max_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(517, 551);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(251, 68);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_swap
            // 
            this.btn_swap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_swap.Location = new System.Drawing.Point(198, 551);
            this.btn_swap.Name = "btn_swap";
            this.btn_swap.Size = new System.Drawing.Size(251, 68);
            this.btn_swap.TabIndex = 12;
            this.btn_swap.Text = "Swap";
            this.btn_swap.UseVisualStyleBackColor = true;
            this.btn_swap.Click += new System.EventHandler(this.btn_swap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 662);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_swap);
            this.Controls.Add(this.btn_min_max);
            this.Controls.Add(this.btn_odd_even);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_mul);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.txt_y);
            this.Controls.Add(this.txt_ans);
            this.Controls.Add(this.txt_x);
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
        private System.Windows.Forms.TextBox txt_x;
        private System.Windows.Forms.TextBox txt_ans;
        private System.Windows.Forms.TextBox txt_y;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_mul;
        private System.Windows.Forms.Button btn_odd_even;
        private System.Windows.Forms.Button btn_min_max;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_swap;
    }
}

