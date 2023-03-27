namespace Exam
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.grpbox_bc = new System.Windows.Forms.GroupBox();
            this.rdo_bg_blue = new System.Windows.Forms.RadioButton();
            this.rdo_bg_yellow = new System.Windows.Forms.RadioButton();
            this.rdo_bg_red = new System.Windows.Forms.RadioButton();
            this.grpbox_fc = new System.Windows.Forms.GroupBox();
            this.rdo_fc_blue = new System.Windows.Forms.RadioButton();
            this.rdo_fc_yellow = new System.Windows.Forms.RadioButton();
            this.rdo_fc_red = new System.Windows.Forms.RadioButton();
            this.grpbox_bc.SuspendLayout();
            this.grpbox_fc.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "City";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(281, 85);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(461, 39);
            this.txt_name.TabIndex = 2;
            // 
            // txt_city
            // 
            this.txt_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_city.Location = new System.Drawing.Point(281, 139);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(461, 39);
            this.txt_city.TabIndex = 3;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(404, 450);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(140, 45);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // grpbox_bc
            // 
            this.grpbox_bc.Controls.Add(this.rdo_bg_blue);
            this.grpbox_bc.Controls.Add(this.rdo_bg_yellow);
            this.grpbox_bc.Controls.Add(this.rdo_bg_red);
            this.grpbox_bc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbox_bc.Location = new System.Drawing.Point(149, 216);
            this.grpbox_bc.Name = "grpbox_bc";
            this.grpbox_bc.Size = new System.Drawing.Size(292, 197);
            this.grpbox_bc.TabIndex = 5;
            this.grpbox_bc.TabStop = false;
            this.grpbox_bc.Text = "BG-Color";
            // 
            // rdo_bg_blue
            // 
            this.rdo_bg_blue.AutoSize = true;
            this.rdo_bg_blue.Location = new System.Drawing.Point(29, 134);
            this.rdo_bg_blue.Name = "rdo_bg_blue";
            this.rdo_bg_blue.Size = new System.Drawing.Size(97, 36);
            this.rdo_bg_blue.TabIndex = 2;
            this.rdo_bg_blue.TabStop = true;
            this.rdo_bg_blue.Text = "Blue";
            this.rdo_bg_blue.UseVisualStyleBackColor = true;
            // 
            // rdo_bg_yellow
            // 
            this.rdo_bg_yellow.AutoSize = true;
            this.rdo_bg_yellow.Location = new System.Drawing.Point(29, 92);
            this.rdo_bg_yellow.Name = "rdo_bg_yellow";
            this.rdo_bg_yellow.Size = new System.Drawing.Size(124, 36);
            this.rdo_bg_yellow.TabIndex = 1;
            this.rdo_bg_yellow.TabStop = true;
            this.rdo_bg_yellow.Text = "Yellow";
            this.rdo_bg_yellow.UseVisualStyleBackColor = true;
            // 
            // rdo_bg_red
            // 
            this.rdo_bg_red.AutoSize = true;
            this.rdo_bg_red.Location = new System.Drawing.Point(29, 50);
            this.rdo_bg_red.Name = "rdo_bg_red";
            this.rdo_bg_red.Size = new System.Drawing.Size(91, 36);
            this.rdo_bg_red.TabIndex = 0;
            this.rdo_bg_red.TabStop = true;
            this.rdo_bg_red.Text = "Red";
            this.rdo_bg_red.UseVisualStyleBackColor = true;
            // 
            // grpbox_fc
            // 
            this.grpbox_fc.Controls.Add(this.rdo_fc_blue);
            this.grpbox_fc.Controls.Add(this.rdo_fc_yellow);
            this.grpbox_fc.Controls.Add(this.rdo_fc_red);
            this.grpbox_fc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbox_fc.Location = new System.Drawing.Point(512, 216);
            this.grpbox_fc.Name = "grpbox_fc";
            this.grpbox_fc.Size = new System.Drawing.Size(292, 197);
            this.grpbox_fc.TabIndex = 6;
            this.grpbox_fc.TabStop = false;
            this.grpbox_fc.Text = "Fore-Color";
            // 
            // rdo_fc_blue
            // 
            this.rdo_fc_blue.AutoSize = true;
            this.rdo_fc_blue.Location = new System.Drawing.Point(32, 134);
            this.rdo_fc_blue.Name = "rdo_fc_blue";
            this.rdo_fc_blue.Size = new System.Drawing.Size(97, 36);
            this.rdo_fc_blue.TabIndex = 3;
            this.rdo_fc_blue.TabStop = true;
            this.rdo_fc_blue.Text = "Blue";
            this.rdo_fc_blue.UseVisualStyleBackColor = true;
            // 
            // rdo_fc_yellow
            // 
            this.rdo_fc_yellow.AutoSize = true;
            this.rdo_fc_yellow.Location = new System.Drawing.Point(32, 92);
            this.rdo_fc_yellow.Name = "rdo_fc_yellow";
            this.rdo_fc_yellow.Size = new System.Drawing.Size(124, 36);
            this.rdo_fc_yellow.TabIndex = 2;
            this.rdo_fc_yellow.TabStop = true;
            this.rdo_fc_yellow.Text = "Yellow";
            this.rdo_fc_yellow.UseVisualStyleBackColor = true;
            // 
            // rdo_fc_red
            // 
            this.rdo_fc_red.AutoSize = true;
            this.rdo_fc_red.Location = new System.Drawing.Point(32, 50);
            this.rdo_fc_red.Name = "rdo_fc_red";
            this.rdo_fc_red.Size = new System.Drawing.Size(91, 36);
            this.rdo_fc_red.TabIndex = 1;
            this.rdo_fc_red.TabStop = true;
            this.rdo_fc_red.Text = "Red";
            this.rdo_fc_red.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 619);
            this.Controls.Add(this.grpbox_fc);
            this.Controls.Add(this.grpbox_bc);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_city);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpbox_bc.ResumeLayout(false);
            this.grpbox_bc.PerformLayout();
            this.grpbox_fc.ResumeLayout(false);
            this.grpbox_fc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.GroupBox grpbox_bc;
        private System.Windows.Forms.GroupBox grpbox_fc;
        private System.Windows.Forms.RadioButton rdo_bg_blue;
        private System.Windows.Forms.RadioButton rdo_bg_yellow;
        private System.Windows.Forms.RadioButton rdo_bg_red;
        private System.Windows.Forms.RadioButton rdo_fc_blue;
        private System.Windows.Forms.RadioButton rdo_fc_yellow;
        private System.Windows.Forms.RadioButton rdo_fc_red;
    }
}

