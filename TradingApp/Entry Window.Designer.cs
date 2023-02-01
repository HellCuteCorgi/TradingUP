namespace TradingApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.enterBtn = new System.Windows.Forms.Button();
            this.passSeeBtn = new System.Windows.Forms.Button();
            this.passTB = new System.Windows.Forms.TextBox();
            this.passL = new System.Windows.Forms.Label();
            this.logTB = new System.Windows.Forms.TextBox();
            this.logL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterBtn
            // 
            this.enterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.enterBtn.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterBtn.Location = new System.Drawing.Point(99, 109);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(81, 23);
            this.enterBtn.TabIndex = 27;
            this.enterBtn.Text = "Вход";
            this.enterBtn.UseVisualStyleBackColor = false;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // passSeeBtn
            // 
            this.passSeeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.passSeeBtn.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.passSeeBtn.Location = new System.Drawing.Point(224, 66);
            this.passSeeBtn.Name = "passSeeBtn";
            this.passSeeBtn.Size = new System.Drawing.Size(64, 41);
            this.passSeeBtn.TabIndex = 28;
            this.passSeeBtn.Text = "Показать пароль";
            this.passSeeBtn.UseVisualStyleBackColor = false;
            this.passSeeBtn.Click += new System.EventHandler(this.passSeeBtn_Click);
            // 
            // passTB
            // 
            this.passTB.BackColor = System.Drawing.Color.White;
            this.passTB.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passTB.Location = new System.Drawing.Point(82, 66);
            this.passTB.MaxLength = 255;
            this.passTB.Name = "passTB";
            this.passTB.Size = new System.Drawing.Size(124, 23);
            this.passTB.TabIndex = 25;
            this.passTB.UseSystemPasswordChar = true;
            // 
            // passL
            // 
            this.passL.AutoSize = true;
            this.passL.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passL.Location = new System.Drawing.Point(19, 69);
            this.passL.Name = "passL";
            this.passL.Size = new System.Drawing.Size(57, 15);
            this.passL.TabIndex = 26;
            this.passL.Text = "Password:";
            // 
            // logTB
            // 
            this.logTB.BackColor = System.Drawing.Color.White;
            this.logTB.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logTB.Location = new System.Drawing.Point(82, 23);
            this.logTB.MaxLength = 255;
            this.logTB.Name = "logTB";
            this.logTB.Size = new System.Drawing.Size(124, 23);
            this.logTB.TabIndex = 24;
            // 
            // logL
            // 
            this.logL.AutoSize = true;
            this.logL.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logL.Location = new System.Drawing.Point(38, 26);
            this.logL.Name = "logL";
            this.logL.Size = new System.Drawing.Size(38, 15);
            this.logL.TabIndex = 23;
            this.logL.Text = "Login:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 154);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.passSeeBtn);
            this.Controls.Add(this.passTB);
            this.Controls.Add(this.passL);
            this.Controls.Add(this.logTB);
            this.Controls.Add(this.logL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно входа";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Button passSeeBtn;
        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.Label passL;
        private System.Windows.Forms.TextBox logTB;
        private System.Windows.Forms.Label logL;
    }
}

