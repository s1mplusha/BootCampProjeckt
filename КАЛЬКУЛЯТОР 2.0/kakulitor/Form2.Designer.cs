
namespace kakulitor
{
    partial class PASSWORD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PASSWORD));
            this.LBLPSS = new System.Windows.Forms.Label();
            this.BTNVV = new System.Windows.Forms.Button();
            this.TXTBPPS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LBLPSS
            // 
            this.LBLPSS.AutoSize = true;
            this.LBLPSS.Font = new System.Drawing.Font("Microsoft YaHei", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLPSS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBLPSS.Location = new System.Drawing.Point(43, 59);
            this.LBLPSS.Name = "LBLPSS";
            this.LBLPSS.Size = new System.Drawing.Size(301, 40);
            this.LBLPSS.TabIndex = 0;
            this.LBLPSS.Text = "ВВЕДИ ПАРОЛЬ!!!";
            // 
            // BTNVV
            // 
            this.BTNVV.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTNVV.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNVV.Location = new System.Drawing.Point(127, 207);
            this.BTNVV.Name = "BTNVV";
            this.BTNVV.Size = new System.Drawing.Size(121, 32);
            this.BTNVV.TabIndex = 1;
            this.BTNVV.Text = "ВВОД";
            this.BTNVV.UseVisualStyleBackColor = true;
            // 
            // TXTBPPS
            // 
            this.TXTBPPS.Location = new System.Drawing.Point(104, 157);
            this.TXTBPPS.Name = "TXTBPPS";
            this.TXTBPPS.PasswordChar = '#';
            this.TXTBPPS.Size = new System.Drawing.Size(168, 20);
            this.TXTBPPS.TabIndex = 2;
            this.TXTBPPS.TextChanged += new System.EventHandler(this.TXTBPPS_TextChanged);
            // 
            // PASSWORD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(384, 271);
            this.Controls.Add(this.TXTBPPS);
            this.Controls.Add(this.BTNVV);
            this.Controls.Add(this.LBLPSS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PASSWORD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АУТИФИКАЦИЯ";
            this.Load += new System.EventHandler(this.PASSWORD_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PASSWORD_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLPSS;
        private System.Windows.Forms.Button BTNVV;
        private System.Windows.Forms.TextBox TXTBPPS;
    }
}