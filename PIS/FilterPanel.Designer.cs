
namespace PIS
{
    partial class FilterPanel
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
            this.checkBoxOfEditableCardsWithNotifications = new System.Windows.Forms.CheckBox();
            this.checkBoxOfEditableCardsWithoutNotifications = new System.Windows.Forms.CheckBox();
            this.checkBoxOfOtherCards = new System.Windows.Forms.CheckBox();
            this.checkBoxOfAttachedPdf = new System.Windows.Forms.CheckBox();
            this.checkBoxOfCommented = new System.Windows.Forms.CheckBox();
            this.CardIdRangeEnd = new System.Windows.Forms.TextBox();
            this.dashLabelOfCardNumberRange = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxOfSubmittedForRevision = new System.Windows.Forms.CheckBox();
            this.checkBoxOfDraft = new System.Windows.Forms.CheckBox();
            this.checkBoxOfAgreementByCatchingOrganization = new System.Windows.Forms.CheckBox();
            this.checkBoxOfApprovedByOmsu = new System.Windows.Forms.CheckBox();
            this.checkBoxOfAgreedByOmsu = new System.Windows.Forms.CheckBox();
            this.checkBoxOfApprovedByCatchingOrganization = new System.Windows.Forms.CheckBox();
            this.checkBoxOfAgreedByCatchingOrganization = new System.Windows.Forms.CheckBox();
            this.countOfOfEditableCardsWithNotifications = new System.Windows.Forms.Label();
            this.countOfOfEditableCardsWithoutNotifications = new System.Windows.Forms.Label();
            this.CountOfOtherCards = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.CardIdRangeStart = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sortingByBox = new System.Windows.Forms.ComboBox();
            this.orderByBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // checkBoxOfEditableCardsWithNotifications
            // 
            this.checkBoxOfEditableCardsWithNotifications.AutoSize = true;
            this.checkBoxOfEditableCardsWithNotifications.Location = new System.Drawing.Point(23, 163);
            this.checkBoxOfEditableCardsWithNotifications.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxOfEditableCardsWithNotifications.Name = "checkBoxOfEditableCardsWithNotifications";
            this.checkBoxOfEditableCardsWithNotifications.Size = new System.Drawing.Size(316, 29);
            this.checkBoxOfEditableCardsWithNotifications.TabIndex = 0;
            this.checkBoxOfEditableCardsWithNotifications.Text = "Редактируемые с уведомлениями";
            this.checkBoxOfEditableCardsWithNotifications.UseVisualStyleBackColor = true;
            this.checkBoxOfEditableCardsWithNotifications.CheckedChanged += new System.EventHandler(this.checkBoxOfEditableCardsWithNotifications_CheckedChanged);
            // 
            // checkBoxOfEditableCardsWithoutNotifications
            // 
            this.checkBoxOfEditableCardsWithoutNotifications.AutoSize = true;
            this.checkBoxOfEditableCardsWithoutNotifications.Location = new System.Drawing.Point(23, 196);
            this.checkBoxOfEditableCardsWithoutNotifications.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxOfEditableCardsWithoutNotifications.Name = "checkBoxOfEditableCardsWithoutNotifications";
            this.checkBoxOfEditableCardsWithoutNotifications.Size = new System.Drawing.Size(313, 29);
            this.checkBoxOfEditableCardsWithoutNotifications.TabIndex = 1;
            this.checkBoxOfEditableCardsWithoutNotifications.Text = "Редактируемые без уведомлений";
            this.checkBoxOfEditableCardsWithoutNotifications.UseVisualStyleBackColor = true;
            this.checkBoxOfEditableCardsWithoutNotifications.CheckedChanged += new System.EventHandler(this.checkBoxOfEditableCardsWithoutNotifications_CheckedChanged);
            // 
            // checkBoxOfOtherCards
            // 
            this.checkBoxOfOtherCards.AutoSize = true;
            this.checkBoxOfOtherCards.Location = new System.Drawing.Point(23, 230);
            this.checkBoxOfOtherCards.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxOfOtherCards.Name = "checkBoxOfOtherCards";
            this.checkBoxOfOtherCards.Size = new System.Drawing.Size(126, 29);
            this.checkBoxOfOtherCards.TabIndex = 2;
            this.checkBoxOfOtherCards.Text = "Остальные";
            this.checkBoxOfOtherCards.UseVisualStyleBackColor = true;
            this.checkBoxOfOtherCards.CheckedChanged += new System.EventHandler(this.checkBoxOfOtherCards_CheckedChanged);
            // 
            // checkBoxOfAttachedPdf
            // 
            this.checkBoxOfAttachedPdf.AutoSize = true;
            this.checkBoxOfAttachedPdf.Location = new System.Drawing.Point(23, 692);
            this.checkBoxOfAttachedPdf.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxOfAttachedPdf.Name = "checkBoxOfAttachedPdf";
            this.checkBoxOfAttachedPdf.Size = new System.Drawing.Size(115, 29);
            this.checkBoxOfAttachedPdf.TabIndex = 3;
            this.checkBoxOfAttachedPdf.Text = "PDF файл";
            this.checkBoxOfAttachedPdf.UseVisualStyleBackColor = true;
            this.checkBoxOfAttachedPdf.CheckedChanged += new System.EventHandler(this.checkBoxOfAttachedPdf_CheckedChanged);
            // 
            // checkBoxOfCommented
            // 
            this.checkBoxOfCommented.AutoSize = true;
            this.checkBoxOfCommented.Location = new System.Drawing.Point(23, 659);
            this.checkBoxOfCommented.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxOfCommented.Name = "checkBoxOfCommented";
            this.checkBoxOfCommented.Size = new System.Drawing.Size(151, 29);
            this.checkBoxOfCommented.TabIndex = 4;
            this.checkBoxOfCommented.Text = "Комментарий";
            this.checkBoxOfCommented.UseVisualStyleBackColor = true;
            this.checkBoxOfCommented.CheckedChanged += new System.EventHandler(this.checkBoxOfCommented_CheckedChanged);
            // 
            // CardIdRangeEnd
            // 
            this.CardIdRangeEnd.Location = new System.Drawing.Point(225, 582);
            this.CardIdRangeEnd.Margin = new System.Windows.Forms.Padding(2);
            this.CardIdRangeEnd.Name = "CardIdRangeEnd";
            this.CardIdRangeEnd.PlaceholderText = "До";
            this.CardIdRangeEnd.Size = new System.Drawing.Size(168, 31);
            this.CardIdRangeEnd.TabIndex = 7;
            this.CardIdRangeEnd.TextChanged += new System.EventHandler(this.CardIdRangeEnd_TextChanged);
            this.CardIdRangeEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CardIdRangeEnd_KeyPress);
            // 
            // dashLabelOfCardNumberRange
            // 
            this.dashLabelOfCardNumberRange.AutoSize = true;
            this.dashLabelOfCardNumberRange.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dashLabelOfCardNumberRange.Location = new System.Drawing.Point(194, 582);
            this.dashLabelOfCardNumberRange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dashLabelOfCardNumberRange.Name = "dashLabelOfCardNumberRange";
            this.dashLabelOfCardNumberRange.Size = new System.Drawing.Size(30, 25);
            this.dashLabelOfCardNumberRange.TabIndex = 8;
            this.dashLabelOfCardNumberRange.Text = "—";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(17, 548);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Диапазон номеров";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(17, 630);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Наличие";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Тип карточек";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 271);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Последний статус";
            // 
            // checkBoxOfSubmittedForRevision
            // 
            this.checkBoxOfSubmittedForRevision.AutoSize = true;
            this.checkBoxOfSubmittedForRevision.Location = new System.Drawing.Point(23, 300);
            this.checkBoxOfSubmittedForRevision.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxOfSubmittedForRevision.Name = "checkBoxOfSubmittedForRevision";
            this.checkBoxOfSubmittedForRevision.Size = new System.Drawing.Size(254, 29);
            this.checkBoxOfSubmittedForRevision.TabIndex = 13;
            this.checkBoxOfSubmittedForRevision.Text = "Отправлено на доработку";
            this.checkBoxOfSubmittedForRevision.UseVisualStyleBackColor = true;
            this.checkBoxOfSubmittedForRevision.CheckedChanged += new System.EventHandler(this.checkBoxOfSubmittedForRevision_CheckedChanged);
            // 
            // checkBoxOfDraft
            // 
            this.checkBoxOfDraft.AutoSize = true;
            this.checkBoxOfDraft.Location = new System.Drawing.Point(23, 334);
            this.checkBoxOfDraft.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxOfDraft.Name = "checkBoxOfDraft";
            this.checkBoxOfDraft.Size = new System.Drawing.Size(120, 29);
            this.checkBoxOfDraft.TabIndex = 14;
            this.checkBoxOfDraft.Text = "Черновик";
            this.checkBoxOfDraft.UseVisualStyleBackColor = true;
            this.checkBoxOfDraft.CheckedChanged += new System.EventHandler(this.checkBoxOfDraft_CheckedChanged);
            // 
            // checkBoxOfAgreementByCatchingOrganization
            // 
            this.checkBoxOfAgreementByCatchingOrganization.AutoSize = true;
            this.checkBoxOfAgreementByCatchingOrganization.Location = new System.Drawing.Point(23, 367);
            this.checkBoxOfAgreementByCatchingOrganization.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxOfAgreementByCatchingOrganization.Name = "checkBoxOfAgreementByCatchingOrganization";
            this.checkBoxOfAgreementByCatchingOrganization.Size = new System.Drawing.Size(366, 29);
            this.checkBoxOfAgreementByCatchingOrganization.TabIndex = 15;
            this.checkBoxOfAgreementByCatchingOrganization.Text = "Согласование в организации по отлову";
            this.checkBoxOfAgreementByCatchingOrganization.UseVisualStyleBackColor = true;
            this.checkBoxOfAgreementByCatchingOrganization.CheckedChanged += new System.EventHandler(this.checkBoxOfAgreementByCatchingOrganization_CheckedChanged);
            // 
            // checkBoxOfApprovedByOmsu
            // 
            this.checkBoxOfApprovedByOmsu.AutoSize = true;
            this.checkBoxOfApprovedByOmsu.Location = new System.Drawing.Point(23, 500);
            this.checkBoxOfApprovedByOmsu.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxOfApprovedByOmsu.Name = "checkBoxOfApprovedByOmsu";
            this.checkBoxOfApprovedByOmsu.Size = new System.Drawing.Size(209, 29);
            this.checkBoxOfApprovedByOmsu.TabIndex = 16;
            this.checkBoxOfApprovedByOmsu.Text = "Утверждено в ОМСУ";
            this.checkBoxOfApprovedByOmsu.UseVisualStyleBackColor = true;
            this.checkBoxOfApprovedByOmsu.CheckedChanged += new System.EventHandler(this.checkBoxOfApprovedByOmsu_CheckedChanged);
            // 
            // checkBoxOfAgreedByOmsu
            // 
            this.checkBoxOfAgreedByOmsu.AutoSize = true;
            this.checkBoxOfAgreedByOmsu.Location = new System.Drawing.Point(23, 467);
            this.checkBoxOfAgreedByOmsu.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxOfAgreedByOmsu.Name = "checkBoxOfAgreedByOmsu";
            this.checkBoxOfAgreedByOmsu.Size = new System.Drawing.Size(215, 29);
            this.checkBoxOfAgreedByOmsu.TabIndex = 17;
            this.checkBoxOfAgreedByOmsu.Text = "Согласовано в ОМСУ";
            this.checkBoxOfAgreedByOmsu.UseVisualStyleBackColor = true;
            this.checkBoxOfAgreedByOmsu.CheckedChanged += new System.EventHandler(this.checkBoxOfAgreedByOmsu_CheckedChanged);
            // 
            // checkBoxOfApprovedByCatchingOrganization
            // 
            this.checkBoxOfApprovedByCatchingOrganization.AutoSize = true;
            this.checkBoxOfApprovedByCatchingOrganization.Location = new System.Drawing.Point(23, 434);
            this.checkBoxOfApprovedByCatchingOrganization.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxOfApprovedByCatchingOrganization.Name = "checkBoxOfApprovedByCatchingOrganization";
            this.checkBoxOfApprovedByCatchingOrganization.Size = new System.Drawing.Size(352, 29);
            this.checkBoxOfApprovedByCatchingOrganization.TabIndex = 18;
            this.checkBoxOfApprovedByCatchingOrganization.Text = "Утверждено в организации по отлову";
            this.checkBoxOfApprovedByCatchingOrganization.UseVisualStyleBackColor = true;
            this.checkBoxOfApprovedByCatchingOrganization.CheckedChanged += new System.EventHandler(this.checkBoxOfApprovedByCatchingOrganization_CheckedChanged);
            // 
            // checkBoxOfAgreedByCatchingOrganization
            // 
            this.checkBoxOfAgreedByCatchingOrganization.AutoSize = true;
            this.checkBoxOfAgreedByCatchingOrganization.Location = new System.Drawing.Point(23, 400);
            this.checkBoxOfAgreedByCatchingOrganization.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxOfAgreedByCatchingOrganization.Name = "checkBoxOfAgreedByCatchingOrganization";
            this.checkBoxOfAgreedByCatchingOrganization.Size = new System.Drawing.Size(358, 29);
            this.checkBoxOfAgreedByCatchingOrganization.TabIndex = 19;
            this.checkBoxOfAgreedByCatchingOrganization.Text = "Согласовано в организации по отлову";
            this.checkBoxOfAgreedByCatchingOrganization.UseVisualStyleBackColor = true;
            this.checkBoxOfAgreedByCatchingOrganization.CheckedChanged += new System.EventHandler(this.checkBoxOfAgreedByCatchingOrganization_CheckedChanged);
            // 
            // countOfOfEditableCardsWithNotifications
            // 
            this.countOfOfEditableCardsWithNotifications.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.countOfOfEditableCardsWithNotifications.Location = new System.Drawing.Point(327, 164);
            this.countOfOfEditableCardsWithNotifications.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.countOfOfEditableCardsWithNotifications.Name = "countOfOfEditableCardsWithNotifications";
            this.countOfOfEditableCardsWithNotifications.Size = new System.Drawing.Size(74, 25);
            this.countOfOfEditableCardsWithNotifications.TabIndex = 20;
            this.countOfOfEditableCardsWithNotifications.Text = "(1234)";
            this.countOfOfEditableCardsWithNotifications.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // countOfOfEditableCardsWithoutNotifications
            // 
            this.countOfOfEditableCardsWithoutNotifications.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.countOfOfEditableCardsWithoutNotifications.Location = new System.Drawing.Point(327, 197);
            this.countOfOfEditableCardsWithoutNotifications.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.countOfOfEditableCardsWithoutNotifications.Name = "countOfOfEditableCardsWithoutNotifications";
            this.countOfOfEditableCardsWithoutNotifications.Size = new System.Drawing.Size(74, 25);
            this.countOfOfEditableCardsWithoutNotifications.TabIndex = 21;
            this.countOfOfEditableCardsWithoutNotifications.Text = "(1234)";
            this.countOfOfEditableCardsWithoutNotifications.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CountOfOtherCards
            // 
            this.CountOfOtherCards.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CountOfOtherCards.Location = new System.Drawing.Point(239, 230);
            this.CountOfOtherCards.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CountOfOtherCards.Name = "CountOfOtherCards";
            this.CountOfOtherCards.Size = new System.Drawing.Size(162, 25);
            this.CountOfOtherCards.TabIndex = 22;
            this.CountOfOtherCards.Text = "(1234)";
            this.CountOfOtherCards.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.resetButton.Location = new System.Drawing.Point(17, 746);
            this.resetButton.Margin = new System.Windows.Forms.Padding(2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(178, 33);
            this.resetButton.TabIndex = 23;
            this.resetButton.Text = "Сбросить";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.applyButton.Location = new System.Drawing.Point(215, 746);
            this.applyButton.Margin = new System.Windows.Forms.Padding(2);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(178, 33);
            this.applyButton.TabIndex = 24;
            this.applyButton.Text = "Применить";
            this.applyButton.UseVisualStyleBackColor = false;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // CardIdRangeStart
            // 
            this.CardIdRangeStart.Location = new System.Drawing.Point(23, 582);
            this.CardIdRangeStart.Margin = new System.Windows.Forms.Padding(2);
            this.CardIdRangeStart.Name = "CardIdRangeStart";
            this.CardIdRangeStart.PlaceholderText = "От";
            this.CardIdRangeStart.Size = new System.Drawing.Size(168, 31);
            this.CardIdRangeStart.TabIndex = 6;
            this.CardIdRangeStart.TextChanged += new System.EventHandler(this.CardIdRangeStart_TextChanged);
            this.CardIdRangeStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CardIdRangeStart_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(17, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 28);
            this.label5.TabIndex = 25;
            this.label5.Text = "Сортировка";
            // 
            // sortingByBox
            // 
            this.sortingByBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sortingByBox.FormattingEnabled = true;
            this.sortingByBox.Items.AddRange(new object[] {
            "По дате изменения статуса",
            "По дате поимки",
            "По номеру"});
            this.sortingByBox.Location = new System.Drawing.Point(23, 46);
            this.sortingByBox.Name = "sortingByBox";
            this.sortingByBox.Size = new System.Drawing.Size(370, 33);
            this.sortingByBox.TabIndex = 26;
            this.sortingByBox.SelectedIndexChanged += new System.EventHandler(this.sortingByBox_SelectedIndexChanged);
            // 
            // orderByBox
            // 
            this.orderByBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderByBox.FormattingEnabled = true;
            this.orderByBox.Items.AddRange(new object[] {
            "По убыванию",
            "По возрастанию"});
            this.orderByBox.Location = new System.Drawing.Point(23, 85);
            this.orderByBox.Name = "orderByBox";
            this.orderByBox.Size = new System.Drawing.Size(370, 33);
            this.orderByBox.TabIndex = 27;
            this.orderByBox.SelectedIndexChanged += new System.EventHandler(this.orderByBox_SelectedIndexChanged);
            // 
            // FilterPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(230)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.checkBoxOfOtherCards);
            this.Controls.Add(this.checkBoxOfEditableCardsWithoutNotifications);
            this.Controls.Add(this.checkBoxOfEditableCardsWithNotifications);
            this.Controls.Add(this.orderByBox);
            this.Controls.Add(this.sortingByBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.CountOfOtherCards);
            this.Controls.Add(this.countOfOfEditableCardsWithoutNotifications);
            this.Controls.Add(this.countOfOfEditableCardsWithNotifications);
            this.Controls.Add(this.checkBoxOfAgreedByCatchingOrganization);
            this.Controls.Add(this.checkBoxOfApprovedByCatchingOrganization);
            this.Controls.Add(this.checkBoxOfAgreedByOmsu);
            this.Controls.Add(this.checkBoxOfApprovedByOmsu);
            this.Controls.Add(this.checkBoxOfAgreementByCatchingOrganization);
            this.Controls.Add(this.checkBoxOfDraft);
            this.Controls.Add(this.checkBoxOfSubmittedForRevision);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dashLabelOfCardNumberRange);
            this.Controls.Add(this.CardIdRangeEnd);
            this.Controls.Add(this.CardIdRangeStart);
            this.Controls.Add(this.checkBoxOfCommented);
            this.Controls.Add(this.checkBoxOfAttachedPdf);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FilterPanel";
            this.Size = new System.Drawing.Size(413, 800);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxOfEditableCardsWithNotifications;
        private System.Windows.Forms.CheckBox checkBoxOfEditableCardsWithoutNotifications;
        private System.Windows.Forms.CheckBox checkBoxOfOtherCards;
        private System.Windows.Forms.CheckBox checkBoxOfAttachedPdf;
        private System.Windows.Forms.CheckBox checkBoxOfCommented;
        private System.Windows.Forms.TextBox CardIdRangeEnd;
        private System.Windows.Forms.Label dashLabelOfCardNumberRange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxOfSubmittedForRevision;
        private System.Windows.Forms.CheckBox checkBoxOfDraft;
        private System.Windows.Forms.CheckBox checkBoxOfAgreementByCatchingOrganization;
        private System.Windows.Forms.CheckBox checkBoxOfApprovedByOmsu;
        private System.Windows.Forms.CheckBox checkBoxOfAgreedByOmsu;
        private System.Windows.Forms.CheckBox checkBoxOfApprovedByCatchingOrganization;
        private System.Windows.Forms.CheckBox checkBoxOfAgreedByCatchingOrganization;
        private System.Windows.Forms.Label countOfOfEditableCardsWithNotifications;
        private System.Windows.Forms.Label countOfOfEditableCardsWithoutNotifications;
        private System.Windows.Forms.Label CountOfOtherCards;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.TextBox CardIdRangeStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox sortingByBox;
        private System.Windows.Forms.ComboBox orderByBox;
    }
}
