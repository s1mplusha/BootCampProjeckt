
namespace kakulitor
{
    partial class Form3
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1number = new System.Windows.Forms.Label();
            this.label2number = new System.Windows.Forms.Label();
            this.lblres = new System.Windows.Forms.Label();
            this.txtB1 = new System.Windows.Forms.TextBox();
            this.txtB2 = new System.Windows.Forms.TextBox();
            this.btnplus = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btninkris = new System.Windows.Forms.Button();
            this.btndivide = new System.Windows.Forms.Button();
            this.lblresalt = new System.Windows.Forms.Label();
            this.btnexet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1number
            // 
            this.label1number.AutoSize = true;
            this.label1number.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1number.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1number.ForeColor = System.Drawing.Color.Black;
            this.label1number.Location = new System.Drawing.Point(9, 29);
            this.label1number.Name = "label1number";
            this.label1number.Size = new System.Drawing.Size(159, 33);
            this.label1number.TabIndex = 0;
            this.label1number.Text = "первое число:";
            // 
            // label2number
            // 
            this.label2number.AutoSize = true;
            this.label2number.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2number.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2number.ForeColor = System.Drawing.Color.Black;
            this.label2number.Location = new System.Drawing.Point(9, 100);
            this.label2number.Name = "label2number";
            this.label2number.Size = new System.Drawing.Size(166, 33);
            this.label2number.TabIndex = 1;
            this.label2number.Text = "второе число:";
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblres.Font = new System.Drawing.Font("Monotype Corsiva", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblres.ForeColor = System.Drawing.Color.Black;
            this.lblres.Location = new System.Drawing.Point(5, 430);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(85, 41);
            this.lblres.TabIndex = 2;
            this.lblres.Text = "итог";
            // 
            // txtB1
            // 
            this.txtB1.BackColor = System.Drawing.Color.Gold;
            this.txtB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB1.Location = new System.Drawing.Point(297, 29);
            this.txtB1.Name = "txtB1";
            this.txtB1.Size = new System.Drawing.Size(116, 22);
            this.txtB1.TabIndex = 3;
            this.txtB1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtB1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txtB2
            // 
            this.txtB2.BackColor = System.Drawing.Color.Gold;
            this.txtB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB2.Location = new System.Drawing.Point(297, 111);
            this.txtB2.Name = "txtB2";
            this.txtB2.Size = new System.Drawing.Size(116, 22);
            this.txtB2.TabIndex = 4;
            this.txtB2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtB2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // btnplus
            // 
            this.btnplus.BackColor = System.Drawing.Color.Yellow;
            this.btnplus.FlatAppearance.BorderSize = 0;
            this.btnplus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplus.Location = new System.Drawing.Point(15, 189);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(75, 125);
            this.btnplus.TabIndex = 5;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = false;
            this.btnplus.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnminus
            // 
            this.btnminus.BackColor = System.Drawing.Color.Yellow;
            this.btnminus.FlatAppearance.BorderSize = 0;
            this.btnminus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminus.Location = new System.Drawing.Point(139, 189);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(75, 125);
            this.btnminus.TabIndex = 6;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = false;
            this.btnminus.Click += new System.EventHandler(this.btn_Click);
            // 
            // btninkris
            // 
            this.btninkris.BackColor = System.Drawing.Color.Yellow;
            this.btninkris.FlatAppearance.BorderSize = 0;
            this.btninkris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninkris.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninkris.Location = new System.Drawing.Point(264, 189);
            this.btninkris.Name = "btninkris";
            this.btninkris.Size = new System.Drawing.Size(75, 125);
            this.btninkris.TabIndex = 7;
            this.btninkris.Text = "*";
            this.btninkris.UseVisualStyleBackColor = false;
            this.btninkris.Click += new System.EventHandler(this.btn_Click);
            // 
            // btndivide
            // 
            this.btndivide.BackColor = System.Drawing.Color.Yellow;
            this.btndivide.FlatAppearance.BorderSize = 0;
            this.btndivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndivide.Location = new System.Drawing.Point(386, 189);
            this.btndivide.Name = "btndivide";
            this.btndivide.Size = new System.Drawing.Size(75, 125);
            this.btndivide.TabIndex = 8;
            this.btndivide.Text = "/";
            this.btndivide.UseVisualStyleBackColor = false;
            this.btndivide.Click += new System.EventHandler(this.btn_Click);
            // 
            // lblresalt
            // 
            this.lblresalt.AutoSize = true;
            this.lblresalt.BackColor = System.Drawing.Color.Yellow;
            this.lblresalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresalt.Location = new System.Drawing.Point(158, 386);
            this.lblresalt.Name = "lblresalt";
            this.lblresalt.Size = new System.Drawing.Size(78, 85);
            this.lblresalt.TabIndex = 9;
            this.lblresalt.Text = "0";
           
            // 
            // btnexet
            // 
            this.btnexet.BackColor = System.Drawing.Color.Red;
            this.btnexet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexet.ForeColor = System.Drawing.Color.White;
            this.btnexet.Location = new System.Drawing.Point(386, 430);
            this.btnexet.Name = "btnexet";
            this.btnexet.Size = new System.Drawing.Size(75, 41);
            this.btnexet.TabIndex = 10;
            this.btnexet.Text = "выход";
            this.btnexet.UseVisualStyleBackColor = false;
            this.btnexet.Click += new System.EventHandler(this.btn_Exit);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::kakulitor.Properties.Resources._3c980dd2e9c909ada7377cc89885231b;
            this.ClientSize = new System.Drawing.Size(484, 500);
            this.Controls.Add(this.btnexet);
            this.Controls.Add(this.lblresalt);
            this.Controls.Add(this.btndivide);
            this.Controls.Add(this.btninkris);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.txtB2);
            this.Controls.Add(this.txtB1);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.label2number);
            this.Controls.Add(this.label1number);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1number;
        private System.Windows.Forms.Label label2number;
        private System.Windows.Forms.Label lblres;
        private System.Windows.Forms.TextBox txtB1;
        private System.Windows.Forms.TextBox txtB2;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btnminus;
        private System.Windows.Forms.Button btninkris;
        private System.Windows.Forms.Button btndivide;
        private System.Windows.Forms.Label lblresalt;
        private System.Windows.Forms.Button btnexet;
    }
}

