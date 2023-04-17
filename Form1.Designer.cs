namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_ExitApp = new System.Windows.Forms.Button();
            this.button_GenerateNumber = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(268, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello World";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_ExitApp
            // 
            this.button_ExitApp.Location = new System.Drawing.Point(257, 245);
            this.button_ExitApp.Name = "button_ExitApp";
            this.button_ExitApp.Size = new System.Drawing.Size(245, 68);
            this.button_ExitApp.TabIndex = 1;
            this.button_ExitApp.Text = "Выйти из программы!";
            this.button_ExitApp.UseVisualStyleBackColor = true;
            this.button_ExitApp.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_GenerateNumber
            // 
            this.button_GenerateNumber.Location = new System.Drawing.Point(257, 81);
            this.button_GenerateNumber.Name = "button_GenerateNumber";
            this.button_GenerateNumber.Size = new System.Drawing.Size(245, 78);
            this.button_GenerateNumber.TabIndex = 2;
            this.button_GenerateNumber.Text = "Нажми на меня";
            this.button_GenerateNumber.UseVisualStyleBackColor = true;
            this.button_GenerateNumber.Click += new System.EventHandler(this.button_GenerateNumber_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ЗДЕСЬ БУДЕТ ЧИСЛО";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_GenerateNumber);
            this.Controls.Add(this.button_ExitApp);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ExitApp;
        private System.Windows.Forms.Button button_GenerateNumber;
        private System.Windows.Forms.Label label2;
    }
}

