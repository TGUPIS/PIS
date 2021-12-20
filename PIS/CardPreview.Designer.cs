
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
            this.components = new System.ComponentModel.Container();
            this.catchDateBox = new System.Windows.Forms.Label();
            this.statusChangeDateBox = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.Label();
            this.areaBox = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.isPdfAttachedBox = new System.Windows.Forms.PictureBox();
            this.isCommentedBox = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.isPdfAttachedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isCommentedBox)).BeginInit();
            this.SuspendLayout();
            // 
            // catchDateValue
            // 
            this.catchDateBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.catchDateBox.AutoSize = true;
            this.catchDateBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.catchDateBox.Location = new System.Drawing.Point(503, 73);
            this.catchDateBox.Name = "catchDateValue";
            this.catchDateBox.Size = new System.Drawing.Size(76, 25);
            this.catchDateBox.TabIndex = 0;
            this.catchDateBox.Text = "02.2021";
            this.catchDateBox.Click += new System.EventHandler(this.CardPreview_Click);
            // 
            // statusDateValue
            // 
            this.statusChangeDateBox.AutoSize = true;
            this.statusChangeDateBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusChangeDateBox.Location = new System.Drawing.Point(12, 73);
            this.statusChangeDateBox.Name = "statusDateValue";
            this.statusChangeDateBox.Size = new System.Drawing.Size(100, 25);
            this.statusChangeDateBox.TabIndex = 3;
            this.statusChangeDateBox.Text = "12.02.2021";
            this.statusChangeDateBox.Click += new System.EventHandler(this.CardPreview_Click);
            // 
            // statusBox
            // 
            this.statusBox.AutoSize = true;
            this.statusBox.Location = new System.Drawing.Point(12, 51);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(332, 25);
            this.statusBox.TabIndex = 8;
            this.statusBox.Text = "Согласовано в организации по отлову";
            // 
            // areaBox
            // 
            this.areaBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.areaBox.AutoSize = true;
            this.areaBox.Location = new System.Drawing.Point(503, 51);
            this.areaBox.Name = "areaBox";
            this.areaBox.Size = new System.Drawing.Size(77, 25);
            this.areaBox.TabIndex = 9;
            this.areaBox.Text = "Тюмень";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idLabel.Location = new System.Drawing.Point(12, 12);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(62, 30);
            this.idLabel.TabIndex = 10;
            this.idLabel.Text = "#123";
            // 
            // isAttachedPdfBox
            // 
            this.isPdfAttachedBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.isPdfAttachedBox.Image = global::PIS.Properties.Resources.pdfFile;
            this.isPdfAttachedBox.Location = new System.Drawing.Point(521, 13);
            this.isPdfAttachedBox.Name = "isAttachedPdfBox";
            this.isPdfAttachedBox.Size = new System.Drawing.Size(26, 26);
            this.isPdfAttachedBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.isPdfAttachedBox.TabIndex = 11;
            this.isPdfAttachedBox.TabStop = false;
            this.toolTip1.SetToolTip(this.isPdfAttachedBox, "Есть PDF-файл");
            // 
            // isCommentedBox
            // 
            this.isCommentedBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.isCommentedBox.Image = global::PIS.Properties.Resources.comment;
            this.isCommentedBox.Location = new System.Drawing.Point(550, 14);
            this.isCommentedBox.Name = "isCommentedBox";
            this.isCommentedBox.Size = new System.Drawing.Size(24, 24);
            this.isCommentedBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.isCommentedBox.TabIndex = 12;
            this.isCommentedBox.TabStop = false;
            this.toolTip1.SetToolTip(this.isCommentedBox, "Есть замечания");
            // 
            // CardPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(235)))), ((int)(((byte)(213)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.isCommentedBox);
            this.Controls.Add(this.isPdfAttachedBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.areaBox);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.statusChangeDateBox);
            this.Controls.Add(this.catchDateBox);
            this.Name = "CardPreview";
            this.Size = new System.Drawing.Size(594, 113);
            ((System.ComponentModel.ISupportInitialize)(this.isPdfAttachedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isCommentedBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label catchDateBox;
        private System.Windows.Forms.Label statusChangeDateBox;
        private System.Windows.Forms.Label statusBox;
        private System.Windows.Forms.Label areaBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.PictureBox isPdfAttachedBox;
        private System.Windows.Forms.PictureBox isCommentedBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
