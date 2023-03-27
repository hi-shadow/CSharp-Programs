namespace CRUD
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
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_uname = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 645);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "                    ";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(353, 350);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(137, 46);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(679, 350);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(137, 46);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(353, 441);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(137, 46);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(525, 350);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(137, 46);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(145, 126);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(50, 37);
            this.ID.TabIndex = 5;
            this.ID.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "UName";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(353, 126);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(472, 44);
            this.txt_id.TabIndex = 8;
            // 
            // txt_uname
            // 
            this.txt_uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uname.Location = new System.Drawing.Point(353, 192);
            this.txt_uname.Name = "txt_uname";
            this.txt_uname.Size = new System.Drawing.Size(472, 44);
            this.txt_uname.TabIndex = 9;
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(353, 264);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(472, 44);
            this.txt_pass.TabIndex = 10;
            // 
            // btn_truncate
            // 
//            this.btn_truncate.Location = new System.Drawing.Point(525, 441);
//            this.btn_truncate.Name = "btn_truncate";
       //     this.btn_truncate.Size = new System.Drawing.Size(137, 46);
       //     this.btn_truncate.TabIndex = 11;
       //     this.btn_truncate.Text = "Truncate";
        //    this.btn_truncate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 683);
//            this.Controls.Add(this.btn_truncate);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_uname);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_uname;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button btn_truncate;
    }
}

