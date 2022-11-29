namespace Exercize_2_WinForms
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
            this.MValueTextBox = new System.Windows.Forms.TextBox();
            this.GetAnswerButton = new System.Windows.Forms.Button();
            this.AnswerTextBox = new System.Windows.Forms.RichTextBox();
            this.NValueTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите число M:";
            // 
            // MValueTextBox
            // 
            this.MValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MValueTextBox.Location = new System.Drawing.Point(165, 10);
            this.MValueTextBox.Name = "MValueTextBox";
            this.MValueTextBox.Size = new System.Drawing.Size(120, 26);
            this.MValueTextBox.TabIndex = 1;
            // 
            // GetAnswerButton
            // 
            this.GetAnswerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetAnswerButton.Location = new System.Drawing.Point(74, 74);
            this.GetAnswerButton.Name = "GetAnswerButton";
            this.GetAnswerButton.Size = new System.Drawing.Size(154, 27);
            this.GetAnswerButton.TabIndex = 2;
            this.GetAnswerButton.Text = "Получить ответ";
            this.GetAnswerButton.UseVisualStyleBackColor = true;
            this.GetAnswerButton.Click += new System.EventHandler(this.GetAnswerButton_Click);
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerTextBox.Location = new System.Drawing.Point(17, 114);
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(268, 130);
            this.AnswerTextBox.TabIndex = 3;
            this.AnswerTextBox.Text = "";
            // 
            // NValueTextBox
            // 
            this.NValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NValueTextBox.Location = new System.Drawing.Point(165, 42);
            this.NValueTextBox.Name = "NValueTextBox";
            this.NValueTextBox.Size = new System.Drawing.Size(120, 26);
            this.NValueTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите число N:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 256);
            this.Controls.Add(this.NValueTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AnswerTextBox);
            this.Controls.Add(this.GetAnswerButton);
            this.Controls.Add(this.MValueTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MValueTextBox;
        private System.Windows.Forms.Button GetAnswerButton;
        private System.Windows.Forms.RichTextBox AnswerTextBox;
        private System.Windows.Forms.TextBox NValueTextBox;
        private System.Windows.Forms.Label label2;
    }
}

