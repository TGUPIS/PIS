
namespace PIS
{
    partial class Paginator
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
            this.pageNumberPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // pageNumberPanel
            // 
            this.pageNumberPanel.AutoSize = true;
            this.pageNumberPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pageNumberPanel.Location = new System.Drawing.Point(0, 0);
            this.pageNumberPanel.Margin = new System.Windows.Forms.Padding(0);
            this.pageNumberPanel.Name = "pageNumberPanel";
            this.pageNumberPanel.Size = new System.Drawing.Size(0, 0);
            this.pageNumberPanel.TabIndex = 0;
            // 
            // Paginator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.pageNumberPanel);
            this.Name = "Paginator";
            this.Size = new System.Drawing.Size(0, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pageNumberPanel;
    }
}
