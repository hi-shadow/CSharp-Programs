namespace ValueSwap
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
            this.txt_1st = new System.Windows.Forms.TextBox();
            this.txt_2nd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_1st
            // 
            this.txt_1st.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_1st.Location = new System.Drawing.Point(343, 99);
            this.txt_1st.Name = "txt_1st";
            this.txt_1st.Size = new System.Drawing.Size(380, 47);
            this.txt_1st.TabIndex = 0;
            this.txt_1st.Text = "Welcome";
            this.txt_1st.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_1st.Enter += new System.EventHandler(this.txt_1st_Enter);
            // 
            // txt_2nd
            // 
            this.txt_2nd.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_2nd.Location = new System.Drawing.Point(343, 315);
            this.txt_2nd.Name = "txt_2nd";
            this.txt_2nd.Size = new System.Drawing.Size(380, 47);
            this.txt_2nd.TabIndex = 1;
            this.txt_2nd.Text = "Bye";
            this.txt_2nd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_2nd.Enter += new System.EventHandler(this.txt_2nd_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 666);
            this.Controls.Add(this.txt_2nd);
            this.Controls.Add(this.txt_1st);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_1st;
        private System.Windows.Forms.TextBox txt_2nd;
    }
}

