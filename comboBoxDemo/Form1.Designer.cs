namespace comboBoxDemo
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
            this.lbl_city = new System.Windows.Forms.Label();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.cmb_city = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_city.Location = new System.Drawing.Point(80, 152);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(98, 52);
            this.lbl_city.TabIndex = 0;
            this.lbl_city.Text = "City";
            // 
            // txt_city
            // 
            this.txt_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_city.Location = new System.Drawing.Point(267, 152);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(547, 57);
            this.txt_city.TabIndex = 1;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(207, 241);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(234, 69);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Add";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.Location = new System.Drawing.Point(472, 241);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(251, 69);
            this.btn_remove.TabIndex = 3;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click_1);
            // 
            // cmb_city
            // 
            this.cmb_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_city.FormattingEnabled = true;
            this.cmb_city.Location = new System.Drawing.Point(89, 358);
            this.cmb_city.Name = "cmb_city";
            this.cmb_city.Size = new System.Drawing.Size(725, 60);
            this.cmb_city.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 621);
            this.Controls.Add(this.cmb_city);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_city);
            this.Controls.Add(this.lbl_city);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.ComboBox cmb_city;
    }
}

