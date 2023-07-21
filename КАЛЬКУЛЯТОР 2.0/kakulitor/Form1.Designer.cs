
namespace kakulitor
{
    partial class MENU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MENU));
            this.LBL1 = new System.Windows.Forms.Label();
            this.LLKALKUL = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LBL1
            // 
            this.LBL1.AutoSize = true;
            this.LBL1.Font = new System.Drawing.Font("Wide Latin", 25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL1.Location = new System.Drawing.Point(164, 133);
            this.LBL1.Name = "LBL1";
            this.LBL1.Size = new System.Drawing.Size(462, 42);
            this.LBL1.TabIndex = 0;
            this.LBL1.Text = "ДОБРО ПОЖАЛОВАТЬ!!!";
            // 
            // LLKALKUL
            // 
            this.LLKALKUL.ActiveLinkColor = System.Drawing.Color.Lime;
            this.LLKALKUL.AutoSize = true;
            this.LLKALKUL.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLKALKUL.LinkColor = System.Drawing.Color.DarkViolet;
            this.LLKALKUL.Location = new System.Drawing.Point(245, 359);
            this.LLKALKUL.Name = "LLKALKUL";
            this.LLKALKUL.Size = new System.Drawing.Size(248, 35);
            this.LLKALKUL.TabIndex = 1;
            this.LLKALKUL.TabStop = true;
            this.LLKALKUL.Text = "КАЛЬКУЛЯТОР";
            this.LLKALKUL.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LLKALKUL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLKALKUL_LinkClicked);
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.LLKALKUL);
            this.Controls.Add(this.LBL1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MENU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.MENU_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL1;
        private System.Windows.Forms.LinkLabel LLKALKUL;
    }
}