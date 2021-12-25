
namespace PIS
{
    partial class Card
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
            this.cardIdLabel = new System.Windows.Forms.Label();
            this.cardIdValue = new System.Windows.Forms.Label();
            this.areaLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.statusEditButton = new System.Windows.Forms.Button();
            this.statusSaveButton = new System.Windows.Forms.Button();
            this.pdfLoadButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.PictureBox();
            this.readButton = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.PictureBox();
            this.exportButton = new System.Windows.Forms.Button();
            this.cardDeleteButton = new System.Windows.Forms.Button();
            this.userBox = new System.Windows.Forms.TextBox();
            this.catchDatePicker = new System.Windows.Forms.DateTimePicker();
            this.catchDateLabel = new System.Windows.Forms.Label();
            this.statusDateLabel = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userLabel = new System.Windows.Forms.Label();
            this.statusDateValue = new System.Windows.Forms.Label();
            this.pdfDeleteButton = new System.Windows.Forms.Button();
            this.pdfOpenButton = new System.Windows.Forms.Button();
            this.areaEditBox = new System.Windows.Forms.ComboBox();
            this.areaReadBox = new System.Windows.Forms.TextBox();
            this.statusBox1 = new PIS.StatusBox();
            ((System.ComponentModel.ISupportInitialize)(this.editButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnButton)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardIdLabel
            // 
            this.cardIdLabel.AutoSize = true;
            this.cardIdLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cardIdLabel.Location = new System.Drawing.Point(71, 9);
            this.cardIdLabel.Name = "cardIdLabel";
            this.cardIdLabel.Size = new System.Drawing.Size(186, 30);
            this.cardIdLabel.TabIndex = 0;
            this.cardIdLabel.Text = "Номер карточки:";
            // 
            // cardIdValue
            // 
            this.cardIdValue.AutoSize = true;
            this.cardIdValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cardIdValue.Location = new System.Drawing.Point(248, 8);
            this.cardIdValue.Name = "cardIdValue";
            this.cardIdValue.Size = new System.Drawing.Size(53, 32);
            this.cardIdValue.TabIndex = 1;
            this.cardIdValue.Text = "123";
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Location = new System.Drawing.Point(43, 216);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(162, 25);
            this.areaLabel.TabIndex = 3;
            this.areaLabel.Text = "Населенный пункт";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(43, 69);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(63, 25);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Статус";
            // 
            // statusBox
            // 
            this.statusBox.Location = new System.Drawing.Point(43, 97);
            this.statusBox.Name = "statusBox";
            this.statusBox.ReadOnly = true;
            this.statusBox.Size = new System.Drawing.Size(380, 31);
            this.statusBox.TabIndex = 6;
            this.statusBox.Text = "Согласован в организации по отлову";
            // 
            // statusEditButton
            // 
            this.statusEditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.statusEditButton.Location = new System.Drawing.Point(272, 705);
            this.statusEditButton.Name = "statusEditButton";
            this.statusEditButton.Size = new System.Drawing.Size(292, 34);
            this.statusEditButton.TabIndex = 7;
            this.statusEditButton.Text = "Изменить";
            this.statusEditButton.UseVisualStyleBackColor = false;
            this.statusEditButton.Click += new System.EventHandler(this.statusEditButton_Click);
            // 
            // statusSaveButton
            // 
            this.statusSaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.statusSaveButton.Enabled = false;
            this.statusSaveButton.Location = new System.Drawing.Point(578, 705);
            this.statusSaveButton.Name = "statusSaveButton";
            this.statusSaveButton.Size = new System.Drawing.Size(292, 34);
            this.statusSaveButton.TabIndex = 8;
            this.statusSaveButton.Text = "Сохранить";
            this.statusSaveButton.UseVisualStyleBackColor = false;
            this.statusSaveButton.Click += new System.EventHandler(this.statusSaveButton_Click);
            // 
            // pdfLoadButton
            // 
            this.pdfLoadButton.Location = new System.Drawing.Point(452, 264);
            this.pdfLoadButton.Name = "pdfLoadButton";
            this.pdfLoadButton.Size = new System.Drawing.Size(199, 34);
            this.pdfLoadButton.TabIndex = 9;
            this.pdfLoadButton.Text = "Загрузить PDF файл";
            this.pdfLoadButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Image = global::PIS.Properties.Resources.edit;
            this.editButton.Location = new System.Drawing.Point(968, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(40, 40);
            this.editButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.editButton.TabIndex = 10;
            this.editButton.TabStop = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // readButton
            // 
            this.readButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.readButton.Image = global::PIS.Properties.Resources.eye;
            this.readButton.Location = new System.Drawing.Point(968, 3);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(40, 40);
            this.readButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.readButton.TabIndex = 11;
            this.readButton.TabStop = false;
            this.readButton.Visible = false;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Image = global::PIS.Properties.Resources.save;
            this.saveButton.Location = new System.Drawing.Point(968, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(40, 40);
            this.saveButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.saveButton.TabIndex = 12;
            this.saveButton.TabStop = false;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(452, 165);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(199, 34);
            this.exportButton.TabIndex = 13;
            this.exportButton.Text = "Экспортировать план";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // cardDeleteButton
            // 
            this.cardDeleteButton.Location = new System.Drawing.Point(452, 215);
            this.cardDeleteButton.Name = "cardDeleteButton";
            this.cardDeleteButton.Size = new System.Drawing.Size(199, 34);
            this.cardDeleteButton.TabIndex = 14;
            this.cardDeleteButton.Text = "Удалить карточку";
            this.cardDeleteButton.UseVisualStyleBackColor = true;
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(43, 168);
            this.userBox.Name = "userBox";
            this.userBox.ReadOnly = true;
            this.userBox.Size = new System.Drawing.Size(380, 31);
            this.userBox.TabIndex = 15;
            this.userBox.Text = "Иванов Иван Иванович";
            // 
            // catchDatePicker
            // 
            this.catchDatePicker.CustomFormat = "MM/yyyy";
            this.catchDatePicker.Enabled = false;
            this.catchDatePicker.Location = new System.Drawing.Point(43, 317);
            this.catchDatePicker.Name = "catchDatePicker";
            this.catchDatePicker.Size = new System.Drawing.Size(380, 31);
            this.catchDatePicker.TabIndex = 16;
            // 
            // catchDateLabel
            // 
            this.catchDateLabel.AutoSize = true;
            this.catchDateLabel.Location = new System.Drawing.Point(43, 289);
            this.catchDateLabel.Name = "catchDateLabel";
            this.catchDateLabel.Size = new System.Drawing.Size(111, 25);
            this.catchDateLabel.TabIndex = 17;
            this.catchDateLabel.Text = "Дата отлова";
            // 
            // statusDateLabel
            // 
            this.statusDateLabel.AutoSize = true;
            this.statusDateLabel.Location = new System.Drawing.Point(452, 69);
            this.statusDateLabel.Name = "statusDateLabel";
            this.statusDateLabel.Size = new System.Drawing.Size(199, 25);
            this.statusDateLabel.TabIndex = 18;
            this.statusDateLabel.Text = "Дата установки статуса";
            // 
            // returnButton
            // 
            this.returnButton.Image = global::PIS.Properties.Resources.arrowLeft;
            this.returnButton.Location = new System.Drawing.Point(9, 3);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(40, 40);
            this.returnButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.returnButton.TabIndex = 19;
            this.returnButton.TabStop = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(230)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cardIdLabel);
            this.panel1.Controls.Add(this.returnButton);
            this.panel1.Controls.Add(this.cardIdValue);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.readButton);
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Location = new System.Drawing.Point(7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 47);
            this.panel1.TabIndex = 20;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(43, 140);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(313, 25);
            this.userLabel.TabIndex = 21;
            this.userLabel.Text = "Ответственный за изменения статуса";
            // 
            // statusDateValue
            // 
            this.statusDateValue.AutoSize = true;
            this.statusDateValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusDateValue.Location = new System.Drawing.Point(543, 97);
            this.statusDateValue.Name = "statusDateValue";
            this.statusDateValue.Size = new System.Drawing.Size(108, 28);
            this.statusDateValue.TabIndex = 22;
            this.statusDateValue.Text = "12.02.2021";
            // 
            // pdfDeleteButton
            // 
            this.pdfDeleteButton.Enabled = false;
            this.pdfDeleteButton.Location = new System.Drawing.Point(452, 314);
            this.pdfDeleteButton.Name = "pdfDeleteButton";
            this.pdfDeleteButton.Size = new System.Drawing.Size(199, 34);
            this.pdfDeleteButton.TabIndex = 23;
            this.pdfDeleteButton.Text = "Удалить PDF файл";
            this.pdfDeleteButton.UseVisualStyleBackColor = true;
            // 
            // pdfOpenButton
            // 
            this.pdfOpenButton.Location = new System.Drawing.Point(452, 264);
            this.pdfOpenButton.Name = "pdfOpenButton";
            this.pdfOpenButton.Size = new System.Drawing.Size(199, 34);
            this.pdfOpenButton.TabIndex = 24;
            this.pdfOpenButton.Text = "Открыть PDF файл";
            this.pdfOpenButton.UseVisualStyleBackColor = true;
            this.pdfOpenButton.Visible = false;
            // 
            // areaEditBox
            // 
            this.areaEditBox.FormattingEnabled = true;
            this.areaEditBox.Location = new System.Drawing.Point(43, 244);
            this.areaEditBox.Name = "areaEditBox";
            this.areaEditBox.Size = new System.Drawing.Size(380, 33);
            this.areaEditBox.TabIndex = 25;
            this.areaEditBox.Text = "Тюмень";
            this.areaEditBox.Visible = false;
            // 
            // areaReadBox
            // 
            this.areaReadBox.Location = new System.Drawing.Point(43, 245);
            this.areaReadBox.Name = "areaReadBox";
            this.areaReadBox.Size = new System.Drawing.Size(380, 31);
            this.areaReadBox.TabIndex = 26;
            this.areaReadBox.Text = "Тюмень";
            // 
            // statusBox1
            // 
            this.statusBox1.CurrentStatus = null;
            this.statusBox1.Editable = false;
            this.statusBox1.IsLeftButtonEnabled = true;
            this.statusBox1.IsRightButtonEnabled = true;
            this.statusBox1.Location = new System.Drawing.Point(256, 543);
            this.statusBox1.Name = "statusBox1";
            this.statusBox1.Size = new System.Drawing.Size(642, 56);
            this.statusBox1.TabIndex = 27;
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.statusBox1);
            this.Controls.Add(this.areaReadBox);
            this.Controls.Add(this.areaEditBox);
            this.Controls.Add(this.pdfOpenButton);
            this.Controls.Add(this.pdfDeleteButton);
            this.Controls.Add(this.statusDateValue);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusDateLabel);
            this.Controls.Add(this.catchDateLabel);
            this.Controls.Add(this.catchDatePicker);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.cardDeleteButton);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.pdfLoadButton);
            this.Controls.Add(this.statusSaveButton);
            this.Controls.Add(this.statusEditButton);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.areaLabel);
            this.Name = "Card";
            this.Size = new System.Drawing.Size(1042, 761);
            this.Load += new System.EventHandler(this.Card_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cardIdLabel;
        private System.Windows.Forms.Label cardIdValue;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.Button statusEditButton;
        private System.Windows.Forms.Button statusSaveButton;
        private System.Windows.Forms.Button pdfLoadButton;
        private System.Windows.Forms.PictureBox editButton;
        private System.Windows.Forms.PictureBox readButton;
        private System.Windows.Forms.PictureBox saveButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button cardDeleteButton;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.DateTimePicker catchDatePicker;
        private System.Windows.Forms.Label catchDateLabel;
        private System.Windows.Forms.Label statusDateLabel;
        private System.Windows.Forms.PictureBox returnButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label statusDateValue;
        private System.Windows.Forms.Button pdfDeleteButton;
        private System.Windows.Forms.Button pdfOpenButton;
        private System.Windows.Forms.ComboBox areaEditBox;
        private System.Windows.Forms.TextBox areaReadBox;
        private StatusBox statusBox1;
    }
}
