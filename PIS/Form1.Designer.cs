
namespace PIS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cardPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.card = new PIS.Card();
            this.autorisation = new PIS.Autorisation();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.profileButton = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.profilePanel = new System.Windows.Forms.Panel();
            this.fioBox = new System.Windows.Forms.TextBox();
            this.fioLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.filterPanel1 = new PIS.FilterPanel();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileButton)).BeginInit();
            this.profilePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardPanel
            // 
            this.cardPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.cardPanel.Location = new System.Drawing.Point(6, 62);
            this.cardPanel.Name = "cardPanel";
            this.cardPanel.Size = new System.Drawing.Size(613, 795);
            this.cardPanel.TabIndex = 0;
            this.cardPanel.Visible = false;
            // 
            // card
            // 
            this.card.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.card.CardContent = null;
            this.card.Instance = null;
            this.card.Location = new System.Drawing.Point(2, 1);
            this.card.Margin = new System.Windows.Forms.Padding(4);
            this.card.Name = "card";
            this.card.Size = new System.Drawing.Size(1045, 877);
            this.card.TabIndex = 1;
            this.card.Visible = false;
            // 
            // autorisation
            // 
            this.autorisation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.autorisation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.autorisation.Location = new System.Drawing.Point(329, 177);
            this.autorisation.Margin = new System.Windows.Forms.Padding(4);
            this.autorisation.Name = "autorisation";
            this.autorisation.Size = new System.Drawing.Size(391, 248);
            this.autorisation.TabIndex = 0;
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(230)))));
            this.menuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuPanel.Controls.Add(this.profileButton);
            this.menuPanel.Controls.Add(this.button1);
            this.menuPanel.Controls.Add(this.exportButton);
            this.menuPanel.Controls.Add(this.addButton);
            this.menuPanel.Location = new System.Drawing.Point(10, 8);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(1021, 47);
            this.menuPanel.TabIndex = 2;
            this.menuPanel.Visible = false;
            // 
            // profileButton
            // 
            this.profileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.profileButton.Image = global::PIS.Properties.Resources.profile;
            this.profileButton.Location = new System.Drawing.Point(979, 3);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(40, 40);
            this.profileButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profileButton.TabIndex = 3;
            this.profileButton.TabStop = false;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.button1.Location = new System.Drawing.Point(243, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // exportButton
            // 
            this.exportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.exportButton.Location = new System.Drawing.Point(125, 6);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(112, 34);
            this.exportButton.TabIndex = 1;
            this.exportButton.Text = "Экспорт";
            this.exportButton.UseVisualStyleBackColor = false;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.addButton.Location = new System.Drawing.Point(7, 6);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(112, 34);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // profilePanel
            // 
            this.profilePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.profilePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(230)))));
            this.profilePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profilePanel.Controls.Add(this.fioBox);
            this.profilePanel.Controls.Add(this.fioLabel);
            this.profilePanel.Controls.Add(this.logoutButton);
            this.profilePanel.Controls.Add(this.textBox1);
            this.profilePanel.Controls.Add(this.loginBox);
            this.profilePanel.Controls.Add(this.RoleLabel);
            this.profilePanel.Controls.Add(this.loginLabel);
            this.profilePanel.Location = new System.Drawing.Point(658, 54);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(373, 287);
            this.profilePanel.TabIndex = 3;
            this.profilePanel.Visible = false;
            // 
            // fioBox
            // 
            this.fioBox.Location = new System.Drawing.Point(20, 118);
            this.fioBox.Name = "fioBox";
            this.fioBox.ReadOnly = true;
            this.fioBox.Size = new System.Drawing.Size(339, 31);
            this.fioBox.TabIndex = 6;
            this.fioBox.Text = "Иванов Иван Иванович";
            // 
            // fioLabel
            // 
            this.fioLabel.AutoSize = true;
            this.fioLabel.Location = new System.Drawing.Point(20, 90);
            this.fioLabel.Name = "fioLabel";
            this.fioLabel.Size = new System.Drawing.Size(52, 25);
            this.fioLabel.TabIndex = 5;
            this.fioLabel.Text = "ФИО";
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(247, 239);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(112, 34);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Выйти";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 192);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(339, 31);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Куратор по отлову";
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(20, 46);
            this.loginBox.Name = "loginBox";
            this.loginBox.ReadOnly = true;
            this.loginBox.Size = new System.Drawing.Size(339, 31);
            this.loginBox.TabIndex = 2;
            this.loginBox.Text = "ivanov123";
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Location = new System.Drawing.Point(20, 164);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(51, 25);
            this.RoleLabel.TabIndex = 1;
            this.RoleLabel.Text = "Роль";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(20, 18);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(62, 25);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Логин";
            // 
            // filterPanel1
            // 
            this.filterPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(230)))));
            this.filterPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterPanel1.Location = new System.Drawing.Point(619, 65);
            this.filterPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.filterPanel1.Name = "filterPanel1";
            this.filterPanel1.Size = new System.Drawing.Size(412, 800);
            this.filterPanel1.TabIndex = 5;
            this.filterPanel1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1041, 877);
            this.Controls.Add(this.profilePanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.autorisation);
            this.Controls.Add(this.card);
            this.Controls.Add(this.cardPanel);
            this.Controls.Add(this.filterPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profileButton)).EndInit();
            this.profilePanel.ResumeLayout(false);
            this.profilePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel cardPanel;
        private Card card;
        private Autorisation autorisation;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.PictureBox profileButton;
        private System.Windows.Forms.Panel profilePanel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox fioBox;
        private System.Windows.Forms.Label fioLabel;
        private FilterPanel filterPanel1;
    }
}

