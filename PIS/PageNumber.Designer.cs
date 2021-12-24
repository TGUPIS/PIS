
namespace PIS
{
    partial class PageNumber
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pageNumberBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pageNumberBox
            // 
            this.pageNumberBox.AutoSize = true;
            this.pageNumberBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageNumberBox.Location = new System.Drawing.Point(0, 0);
            this.pageNumberBox.Margin = new System.Windows.Forms.Padding(0);
            this.pageNumberBox.Name = "pageNumberBox";
            this.pageNumberBox.Padding = new System.Windows.Forms.Padding(5);
            this.pageNumberBox.Size = new System.Drawing.Size(34, 37);
            this.pageNumberBox.TabIndex = 0;
            this.pageNumberBox.Text = "1";
            this.pageNumberBox.Click += new System.EventHandler(this.pageNumberBox_Click);
            // 
            // PageNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.pageNumberBox);
            this.Name = "PageNumber";
            this.Size = new System.Drawing.Size(34, 37);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pageNumberBox;
    }
}
