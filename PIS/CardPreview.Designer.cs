
namespace PIS
{
    partial class CardPreview
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
            this.catchDateValue = new System.Windows.Forms.Label();
            this.areaLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusDateValue = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.areaBox = new System.Windows.Forms.TextBox();
            this.statusDateLabel = new System.Windows.Forms.Label();
            this.catchDateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // catchDateValue
            // 
            this.catchDateValue.AutoSize = true;
            this.catchDateValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.catchDateValue.Location = new System.Drawing.Point(582, 109);
            this.catchDateValue.Name = "catchDateValue";
            this.catchDateValue.Size = new System.Drawing.Size(82, 28);
            this.catchDateValue.TabIndex = 0;
            this.catchDateValue.Text = "02.2021";
            this.catchDateValue.Click += new System.EventHandler(this.CardPreview_Click);
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Location = new System.Drawing.Point(12, 84);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(162, 25);
            this.areaLabel.TabIndex = 1;
            this.areaLabel.Text = "Населенный пункт";
            this.areaLabel.Click += new System.EventHandler(this.CardPreview_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 11);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(63, 25);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "Статус";
            this.statusLabel.Click += new System.EventHandler(this.CardPreview_Click);
            // 
            // statusDateValue
            // 
            this.statusDateValue.AutoSize = true;
            this.statusDateValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusDateValue.Location = new System.Drawing.Point(553, 39);
            this.statusDateValue.Name = "statusDateValue";
            this.statusDateValue.Size = new System.Drawing.Size(108, 28);
            this.statusDateValue.TabIndex = 3;
            this.statusDateValue.Text = "12.02.2021";
            this.statusDateValue.Click += new System.EventHandler(this.CardPreview_Click);
            // 
            // statusBox
            // 
            this.statusBox.Location = new System.Drawing.Point(12, 39);
            this.statusBox.Name = "statusBox";
            this.statusBox.ReadOnly = true;
            this.statusBox.Size = new System.Drawing.Size(397, 31);
            this.statusBox.TabIndex = 4;
            this.statusBox.Text = "Согласован в организации по отлову";
            this.statusBox.Click += new System.EventHandler(this.CardPreview_Click);
            // 
            // areaBox
            // 
            this.areaBox.Location = new System.Drawing.Point(12, 112);
            this.areaBox.Name = "areaBox";
            this.areaBox.ReadOnly = true;
            this.areaBox.Size = new System.Drawing.Size(397, 31);
            this.areaBox.TabIndex = 5;
            this.areaBox.Text = "Тюмень";
            this.areaBox.Click += new System.EventHandler(this.CardPreview_Click);
            // 
            // statusDateLabel
            // 
            this.statusDateLabel.AutoSize = true;
            this.statusDateLabel.Location = new System.Drawing.Point(465, 11);
            this.statusDateLabel.Name = "statusDateLabel";
            this.statusDateLabel.Size = new System.Drawing.Size(199, 25);
            this.statusDateLabel.TabIndex = 6;
            this.statusDateLabel.Text = "Дата установки статуса";
            this.statusDateLabel.Click += new System.EventHandler(this.CardPreview_Click);
            // 
            // catchDateLabel
            // 
            this.catchDateLabel.AutoSize = true;
            this.catchDateLabel.Location = new System.Drawing.Point(553, 84);
            this.catchDateLabel.Name = "catchDateLabel";
            this.catchDateLabel.Size = new System.Drawing.Size(111, 25);
            this.catchDateLabel.TabIndex = 7;
            this.catchDateLabel.Text = "Дата отлова";
            this.catchDateLabel.Click += new System.EventHandler(this.CardPreview_Click);
            // 
            // CardPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.catchDateLabel);
            this.Controls.Add(this.statusDateLabel);
            this.Controls.Add(this.areaBox);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.statusDateValue);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.catchDateValue);
            this.Name = "CardPreview";
            this.Size = new System.Drawing.Size(678, 156);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label catchDateValue;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label statusDateValue;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.TextBox areaBox;
        private System.Windows.Forms.Label statusDateLabel;
        private System.Windows.Forms.Label catchDateLabel;
    }
}
