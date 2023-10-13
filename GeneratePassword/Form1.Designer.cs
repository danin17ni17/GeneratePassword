namespace GeneratePassword
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1_OK = new System.Windows.Forms.Button();
            this.button2_EXIT = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Генератор Паролей";
            // 
            // button1_OK
            // 
            this.button1_OK.BackColor = System.Drawing.Color.White;
            this.button1_OK.Location = new System.Drawing.Point(143, 183);
            this.button1_OK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1_OK.Name = "button1_OK";
            this.button1_OK.Size = new System.Drawing.Size(100, 28);
            this.button1_OK.TabIndex = 1;
            this.button1_OK.Text = "OK";
            this.button1_OK.UseVisualStyleBackColor = false;
            this.button1_OK.Click += new System.EventHandler(this.button1_OK_Click);
            // 
            // button2_EXIT
            // 
            this.button2_EXIT.BackColor = System.Drawing.Color.White;
            this.button2_EXIT.Location = new System.Drawing.Point(263, 278);
            this.button2_EXIT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2_EXIT.Name = "button2_EXIT";
            this.button2_EXIT.Size = new System.Drawing.Size(100, 28);
            this.button2_EXIT.TabIndex = 2;
            this.button2_EXIT.Text = "Выход";
            this.button2_EXIT.UseVisualStyleBackColor = false;
            this.button2_EXIT.Click += new System.EventHandler(this.button2_EXIT_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 135);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 22);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2_EXIT);
            this.Controls.Add(this.button1_OK);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1_OK;
        private System.Windows.Forms.Button button2_EXIT;
        private System.Windows.Forms.TextBox textBox1;
    }
}

