namespace noticeApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            noticeTitle = new Label();
            noticeTitleBox = new TextBox();
            noticeKubun = new Label();
            noticeKubunComboBox = new ComboBox();
            publicationDateLabel = new Label();
            publicationDate = new TextBox();
            calendarIcon_publicationDate = new PictureBox();
            displayDate = new Label();
            displayDataStart = new TextBox();
            calendarIcon_displayDateStart = new PictureBox();
            displayDataEnd = new TextBox();
            calendarIcon_displayDateEnd = new PictureBox();
            searchButton = new Button();
            noticeDataGridView = new DataGridView();
            createButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            publicationDateCalendar = new MonthCalendar();
            displayDataStartCalendar = new MonthCalendar();
            displayDataEndCalendar = new MonthCalendar();
            UserMessageLabel = new Label();
            label1 = new Label();
            panel1 = new Panel();
            nextBtn = new Label();
            pageSizeLabel = new Label();
            backBtn = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)calendarIcon_publicationDate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)calendarIcon_displayDateStart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)calendarIcon_displayDateEnd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)noticeDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // noticeTitle
            // 
            noticeTitle.AutoSize = true;
            noticeTitle.Location = new Point(12, 15);
            noticeTitle.Name = "noticeTitle";
            noticeTitle.Size = new Size(84, 15);
            noticeTitle.TabIndex = 0;
            noticeTitle.Text = "お知らせタイトル";
            // 
            // noticeTitleBox
            // 
            noticeTitleBox.Location = new Point(102, 12);
            noticeTitleBox.Name = "noticeTitleBox";
            noticeTitleBox.Size = new Size(100, 23);
            noticeTitleBox.TabIndex = 1;
            // 
            // noticeKubun
            // 
            noticeKubun.AutoSize = true;
            noticeKubun.Location = new Point(232, 15);
            noticeKubun.Name = "noticeKubun";
            noticeKubun.Size = new Size(72, 15);
            noticeKubun.TabIndex = 2;
            noticeKubun.Text = "お知らせ区分";
            // 
            // noticeKubunComboBox
            // 
            noticeKubunComboBox.FormattingEnabled = true;
            noticeKubunComboBox.Location = new Point(310, 12);
            noticeKubunComboBox.Name = "noticeKubunComboBox";
            noticeKubunComboBox.Size = new Size(121, 23);
            noticeKubunComboBox.TabIndex = 2;
            // 
            // publicationDateLabel
            // 
            publicationDateLabel.AutoSize = true;
            publicationDateLabel.Location = new Point(12, 53);
            publicationDateLabel.Name = "publicationDateLabel";
            publicationDateLabel.Size = new Size(43, 15);
            publicationDateLabel.TabIndex = 0;
            publicationDateLabel.Text = "掲載日";
            // 
            // publicationDate
            // 
            publicationDate.Location = new Point(102, 50);
            publicationDate.Name = "publicationDate";
            publicationDate.Size = new Size(100, 23);
            publicationDate.TabIndex = 3;
            // 
            // calendarIcon_publicationDate
            // 
            calendarIcon_publicationDate.Image = (Image)resources.GetObject("calendarIcon_publicationDate.Image");
            calendarIcon_publicationDate.Location = new Point(202, 50);
            calendarIcon_publicationDate.Name = "calendarIcon_publicationDate";
            calendarIcon_publicationDate.Size = new Size(22, 23);
            calendarIcon_publicationDate.SizeMode = PictureBoxSizeMode.StretchImage;
            calendarIcon_publicationDate.TabIndex = 4;
            calendarIcon_publicationDate.TabStop = false;
            calendarIcon_publicationDate.Click += calendarIcon_publicationDate_Click;
            // 
            // displayDate
            // 
            displayDate.AutoSize = true;
            displayDate.Location = new Point(232, 53);
            displayDate.Name = "displayDate";
            displayDate.Size = new Size(55, 15);
            displayDate.TabIndex = 0;
            displayDate.Text = "適用期間";
            // 
            // displayDataStart
            // 
            displayDataStart.Location = new Point(310, 50);
            displayDataStart.Name = "displayDataStart";
            displayDataStart.Size = new Size(100, 23);
            displayDataStart.TabIndex = 4;
            // 
            // calendarIcon_displayDateStart
            // 
            calendarIcon_displayDateStart.Image = (Image)resources.GetObject("calendarIcon_displayDateStart.Image");
            calendarIcon_displayDateStart.Location = new Point(409, 50);
            calendarIcon_displayDateStart.Name = "calendarIcon_displayDateStart";
            calendarIcon_displayDateStart.Size = new Size(22, 23);
            calendarIcon_displayDateStart.SizeMode = PictureBoxSizeMode.StretchImage;
            calendarIcon_displayDateStart.TabIndex = 4;
            calendarIcon_displayDateStart.TabStop = false;
            calendarIcon_displayDateStart.Click += calendarIcon_displayDateStart_Click;
            // 
            // displayDataEnd
            // 
            displayDataEnd.Location = new Point(465, 50);
            displayDataEnd.Name = "displayDataEnd";
            displayDataEnd.Size = new Size(100, 23);
            displayDataEnd.TabIndex = 5;
            // 
            // calendarIcon_displayDateEnd
            // 
            calendarIcon_displayDateEnd.Image = (Image)resources.GetObject("calendarIcon_displayDateEnd.Image");
            calendarIcon_displayDateEnd.Location = new Point(562, 50);
            calendarIcon_displayDateEnd.Name = "calendarIcon_displayDateEnd";
            calendarIcon_displayDateEnd.Size = new Size(22, 23);
            calendarIcon_displayDateEnd.SizeMode = PictureBoxSizeMode.StretchImage;
            calendarIcon_displayDateEnd.TabIndex = 4;
            calendarIcon_displayDateEnd.TabStop = false;
            calendarIcon_displayDateEnd.Click += calendarIcon_displayDateEnd_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(625, 50);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 6;
            searchButton.Text = "検索";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // noticeDataGridView
            // 
            noticeDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            noticeDataGridView.Location = new Point(12, 132);
            noticeDataGridView.Name = "noticeDataGridView";
            noticeDataGridView.ReadOnly = true;
            noticeDataGridView.Size = new Size(689, 150);
            noticeDataGridView.TabIndex = 7;
            // 
            // createButton
            // 
            createButton.Location = new Point(12, 302);
            createButton.Name = "createButton";
            createButton.Size = new Size(75, 23);
            createButton.TabIndex = 8;
            createButton.Text = "登録";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(93, 302);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 23);
            editButton.TabIndex = 9;
            editButton.Text = "変更";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(174, 302);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 10;
            deleteButton.Text = "削除";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // publicationDateCalendar
            // 
            publicationDateCalendar.Location = new Point(3, 132);
            publicationDateCalendar.Name = "publicationDateCalendar";
            publicationDateCalendar.TabIndex = 10;
            publicationDateCalendar.Visible = false;
            publicationDateCalendar.DateSelected += publicationDateCalendar_DateSelected;
            // 
            // displayDataStartCalendar
            // 
            displayDataStartCalendar.Location = new Point(232, 129);
            displayDataStartCalendar.Name = "displayDataStartCalendar";
            displayDataStartCalendar.TabIndex = 10;
            displayDataStartCalendar.Visible = false;
            displayDataStartCalendar.DateSelected += displayDataStartCalendar_DateSelected;
            // 
            // displayDataEndCalendar
            // 
            displayDataEndCalendar.Location = new Point(465, 129);
            displayDataEndCalendar.Name = "displayDataEndCalendar";
            displayDataEndCalendar.TabIndex = 10;
            displayDataEndCalendar.Visible = false;
            displayDataEndCalendar.DateSelected += displayDataEndCalendar_DateSelected;
            // 
            // UserMessageLabel
            // 
            UserMessageLabel.AutoSize = true;
            UserMessageLabel.ForeColor = Color.Red;
            UserMessageLabel.Location = new Point(12, 86);
            UserMessageLabel.Name = "UserMessageLabel";
            UserMessageLabel.Size = new Size(32, 15);
            UserMessageLabel.TabIndex = 0;
            UserMessageLabel.Text = "label";
            UserMessageLabel.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(438, 54);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 11;
            label1.Text = "～";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(nextBtn);
            panel1.Controls.Add(pageSizeLabel);
            panel1.Controls.Add(backBtn);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(689, 21);
            panel1.TabIndex = 12;
            // 
            // nextBtn
            // 
            nextBtn.AutoSize = true;
            nextBtn.ForeColor = Color.White;
            nextBtn.Location = new Point(609, 4);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(15, 15);
            nextBtn.TabIndex = 3;
            nextBtn.Text = ">";
            nextBtn.Click += nextBtn_Click;
            // 
            // pageSizeLabel
            // 
            pageSizeLabel.AutoSize = true;
            pageSizeLabel.ForeColor = Color.White;
            pageSizeLabel.Location = new Point(537, 4);
            pageSizeLabel.Name = "pageSizeLabel";
            pageSizeLabel.Size = new Size(66, 15);
            pageSizeLabel.TabIndex = 2;
            pageSizeLabel.Text = "1000 / 1000";
            // 
            // backBtn
            // 
            backBtn.AutoSize = true;
            backBtn.ForeColor = Color.White;
            backBtn.Location = new Point(516, 4);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(15, 15);
            backBtn.TabIndex = 1;
            backBtn.Text = "<";
            backBtn.Click += backBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(128, 128, 255);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 4);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 0;
            label2.Text = "検索結果";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 335);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(displayDataEndCalendar);
            Controls.Add(displayDataStartCalendar);
            Controls.Add(publicationDateCalendar);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(createButton);
            Controls.Add(noticeDataGridView);
            Controls.Add(searchButton);
            Controls.Add(calendarIcon_displayDateEnd);
            Controls.Add(calendarIcon_displayDateStart);
            Controls.Add(calendarIcon_publicationDate);
            Controls.Add(noticeKubunComboBox);
            Controls.Add(noticeKubun);
            Controls.Add(displayDataEnd);
            Controls.Add(displayDataStart);
            Controls.Add(publicationDate);
            Controls.Add(noticeTitleBox);
            Controls.Add(displayDate);
            Controls.Add(UserMessageLabel);
            Controls.Add(publicationDateLabel);
            Controls.Add(noticeTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "お知らせ管理";
            ((System.ComponentModel.ISupportInitialize)calendarIcon_publicationDate).EndInit();
            ((System.ComponentModel.ISupportInitialize)calendarIcon_displayDateStart).EndInit();
            ((System.ComponentModel.ISupportInitialize)calendarIcon_displayDateEnd).EndInit();
            ((System.ComponentModel.ISupportInitialize)noticeDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label noticeTitle;
        private TextBox noticeTitleBox;
        private Label noticeKubun;
        private ComboBox noticeKubunComboBox;
        private Label publicationDateLabel;
        private TextBox publicationDate;
        private PictureBox calendarIcon_publicationDate;
        private Label displayDate;
        private TextBox displayDataStart;
        private PictureBox calendarIcon_displayDateStart;
        private TextBox displayDataEnd;
        private PictureBox calendarIcon_displayDateEnd;
        private Button searchButton;
        private DataGridView noticeDataGridView;
        private Button createButton;
        private Button editButton;
        private Button deleteButton;
        private MonthCalendar publicationDateCalendar;
        private MonthCalendar displayDataStartCalendar;
        private MonthCalendar displayDataEndCalendar;
        private Label UserMessageLabel;
        private Label label1;
        private Panel panel1;
        private Label backBtn;
        private Label label2;
        private Label pageSizeLabel;
        private Label nextBtn;
    }
}
