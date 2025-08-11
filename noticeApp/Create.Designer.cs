namespace noticeApp
{
    partial class Create
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create));
            noticeTitle = new Label();
            noticeKubun = new Label();
            publicationDateLabel = new Label();
            displayStartDataLabel = new Label();
            displayEndDataLabel = new Label();
            noticeBody = new Label();
            noticeTitleTextBox = new TextBox();
            noticeKubunComboBox = new ComboBox();
            calendarIcon_publicationDate = new PictureBox();
            publicationDateTextBox = new TextBox();
            calendarIcon_displayDateStart = new PictureBox();
            displayDataStartTextBox = new TextBox();
            displayDataEndTextBox = new TextBox();
            calendarIcon_displayDateEnd = new PictureBox();
            noticeBodyTextBox = new TextBox();
            createButton = new Button();
            cancelButton = new Button();
            publicationDateCalendar = new MonthCalendar();
            displayDataStartCalendar = new MonthCalendar();
            displayDataEndCalendar = new MonthCalendar();
            UserMessageLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)calendarIcon_publicationDate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)calendarIcon_displayDateStart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)calendarIcon_displayDateEnd).BeginInit();
            SuspendLayout();
            // 
            // noticeTitle
            // 
            noticeTitle.AutoSize = true;
            noticeTitle.Location = new Point(12, 9);
            noticeTitle.Name = "noticeTitle";
            noticeTitle.Size = new Size(84, 15);
            noticeTitle.TabIndex = 0;
            noticeTitle.Text = "お知らせタイトル";
            // 
            // noticeKubun
            // 
            noticeKubun.AutoSize = true;
            noticeKubun.Location = new Point(12, 68);
            noticeKubun.Name = "noticeKubun";
            noticeKubun.Size = new Size(72, 15);
            noticeKubun.TabIndex = 1;
            noticeKubun.Text = "お知らせ区分";
            // 
            // publicationDateLabel
            // 
            publicationDateLabel.AutoSize = true;
            publicationDateLabel.Location = new Point(12, 123);
            publicationDateLabel.Name = "publicationDateLabel";
            publicationDateLabel.Size = new Size(43, 15);
            publicationDateLabel.TabIndex = 1;
            publicationDateLabel.Text = "掲載日";
            // 
            // displayStartDataLabel
            // 
            displayStartDataLabel.AutoSize = true;
            displayStartDataLabel.Location = new Point(12, 177);
            displayStartDataLabel.Name = "displayStartDataLabel";
            displayStartDataLabel.Size = new Size(91, 15);
            displayStartDataLabel.TabIndex = 1;
            displayStartDataLabel.Text = "適用開始年月日";
            // 
            // displayEndDataLabel
            // 
            displayEndDataLabel.AutoSize = true;
            displayEndDataLabel.Location = new Point(12, 231);
            displayEndDataLabel.Name = "displayEndDataLabel";
            displayEndDataLabel.Size = new Size(91, 15);
            displayEndDataLabel.TabIndex = 1;
            displayEndDataLabel.Text = "適用終了年月日";
            // 
            // noticeBody
            // 
            noticeBody.AutoSize = true;
            noticeBody.Location = new Point(12, 284);
            noticeBody.Name = "noticeBody";
            noticeBody.Size = new Size(72, 15);
            noticeBody.TabIndex = 1;
            noticeBody.Text = "お知らせ内容";
            // 
            // noticeTitleTextBox
            // 
            noticeTitleTextBox.Location = new Point(12, 27);
            noticeTitleTextBox.Name = "noticeTitleTextBox";
            noticeTitleTextBox.Size = new Size(284, 23);
            noticeTitleTextBox.TabIndex = 1;
            // 
            // noticeKubunComboBox
            // 
            noticeKubunComboBox.FormattingEnabled = true;
            noticeKubunComboBox.Location = new Point(12, 86);
            noticeKubunComboBox.Name = "noticeKubunComboBox";
            noticeKubunComboBox.Size = new Size(121, 23);
            noticeKubunComboBox.TabIndex = 2;
            // 
            // calendarIcon_publicationDate
            // 
            calendarIcon_publicationDate.Image = (Image)resources.GetObject("calendarIcon_publicationDate.Image");
            calendarIcon_publicationDate.Location = new Point(161, 141);
            calendarIcon_publicationDate.Name = "calendarIcon_publicationDate";
            calendarIcon_publicationDate.Size = new Size(22, 23);
            calendarIcon_publicationDate.SizeMode = PictureBoxSizeMode.StretchImage;
            calendarIcon_publicationDate.TabIndex = 6;
            calendarIcon_publicationDate.TabStop = false;
            calendarIcon_publicationDate.Click += calendarIcon_publicationDate_Click;
            // 
            // publicationDateTextBox
            // 
            publicationDateTextBox.Location = new Point(12, 141);
            publicationDateTextBox.Name = "publicationDateTextBox";
            publicationDateTextBox.Size = new Size(171, 23);
            publicationDateTextBox.TabIndex = 3;
            // 
            // calendarIcon_displayDateStart
            // 
            calendarIcon_displayDateStart.Image = (Image)resources.GetObject("calendarIcon_displayDateStart.Image");
            calendarIcon_displayDateStart.Location = new Point(161, 195);
            calendarIcon_displayDateStart.Name = "calendarIcon_displayDateStart";
            calendarIcon_displayDateStart.Size = new Size(22, 23);
            calendarIcon_displayDateStart.SizeMode = PictureBoxSizeMode.StretchImage;
            calendarIcon_displayDateStart.TabIndex = 8;
            calendarIcon_displayDateStart.TabStop = false;
            calendarIcon_displayDateStart.Click += calendarIcon_displayDateStart_Click;
            // 
            // displayDataStartTextBox
            // 
            displayDataStartTextBox.Location = new Point(12, 195);
            displayDataStartTextBox.Name = "displayDataStartTextBox";
            displayDataStartTextBox.Size = new Size(171, 23);
            displayDataStartTextBox.TabIndex = 4;
            // 
            // displayDataEndTextBox
            // 
            displayDataEndTextBox.Location = new Point(12, 249);
            displayDataEndTextBox.Name = "displayDataEndTextBox";
            displayDataEndTextBox.Size = new Size(171, 23);
            displayDataEndTextBox.TabIndex = 5;
            // 
            // calendarIcon_displayDateEnd
            // 
            calendarIcon_displayDateEnd.Image = (Image)resources.GetObject("calendarIcon_displayDateEnd.Image");
            calendarIcon_displayDateEnd.Location = new Point(161, 249);
            calendarIcon_displayDateEnd.Name = "calendarIcon_displayDateEnd";
            calendarIcon_displayDateEnd.Size = new Size(22, 23);
            calendarIcon_displayDateEnd.SizeMode = PictureBoxSizeMode.StretchImage;
            calendarIcon_displayDateEnd.TabIndex = 8;
            calendarIcon_displayDateEnd.TabStop = false;
            calendarIcon_displayDateEnd.Click += calendarIcon_displayDateEnd_Click;
            // 
            // noticeBodyTextBox
            // 
            noticeBodyTextBox.Location = new Point(12, 302);
            noticeBodyTextBox.Multiline = true;
            noticeBodyTextBox.Name = "noticeBodyTextBox";
            noticeBodyTextBox.Size = new Size(284, 58);
            noticeBodyTextBox.TabIndex = 6;
            // 
            // createButton
            // 
            createButton.Location = new Point(12, 394);
            createButton.Name = "createButton";
            createButton.Size = new Size(75, 23);
            createButton.TabIndex = 7;
            createButton.Text = "登録";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(221, 394);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 8;
            cancelButton.Text = "戻る";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // publicationDateCalendar
            // 
            publicationDateCalendar.Location = new Point(115, 163);
            publicationDateCalendar.Name = "publicationDateCalendar";
            publicationDateCalendar.TabIndex = 10;
            publicationDateCalendar.Visible = false;
            publicationDateCalendar.DateSelected += publicationDateCalendar_DateSelected;
            // 
            // displayDataStartCalendar
            // 
            displayDataStartCalendar.Location = new Point(115, 195);
            displayDataStartCalendar.Name = "displayDataStartCalendar";
            displayDataStartCalendar.TabIndex = 11;
            displayDataStartCalendar.Visible = false;
            displayDataStartCalendar.DateSelected += displayDataStartCalendar_DateSelected;
            // 
            // displayDataEndCalendar
            // 
            displayDataEndCalendar.Location = new Point(115, 231);
            displayDataEndCalendar.Name = "displayDataEndCalendar";
            displayDataEndCalendar.TabIndex = 12;
            displayDataEndCalendar.Visible = false;
            displayDataEndCalendar.DateSelected += displayDataEndCalendar_DateSelected;
            // 
            // UserMessageLabel
            // 
            UserMessageLabel.AutoSize = true;
            UserMessageLabel.ForeColor = Color.Red;
            UserMessageLabel.Location = new Point(12, 363);
            UserMessageLabel.Name = "UserMessageLabel";
            UserMessageLabel.Size = new Size(38, 15);
            UserMessageLabel.TabIndex = 13;
            UserMessageLabel.Text = "label1";
            UserMessageLabel.Visible = false;
            // 
            // Create
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(308, 450);
            Controls.Add(UserMessageLabel);
            Controls.Add(displayDataEndCalendar);
            Controls.Add(displayDataStartCalendar);
            Controls.Add(publicationDateCalendar);
            Controls.Add(cancelButton);
            Controls.Add(createButton);
            Controls.Add(calendarIcon_displayDateEnd);
            Controls.Add(calendarIcon_displayDateStart);
            Controls.Add(displayDataEndTextBox);
            Controls.Add(displayDataStartTextBox);
            Controls.Add(calendarIcon_publicationDate);
            Controls.Add(publicationDateTextBox);
            Controls.Add(noticeKubunComboBox);
            Controls.Add(noticeBodyTextBox);
            Controls.Add(noticeTitleTextBox);
            Controls.Add(noticeBody);
            Controls.Add(displayEndDataLabel);
            Controls.Add(displayStartDataLabel);
            Controls.Add(publicationDateLabel);
            Controls.Add(noticeKubun);
            Controls.Add(noticeTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Create";
            Text = "Create";
            ((System.ComponentModel.ISupportInitialize)calendarIcon_publicationDate).EndInit();
            ((System.ComponentModel.ISupportInitialize)calendarIcon_displayDateStart).EndInit();
            ((System.ComponentModel.ISupportInitialize)calendarIcon_displayDateEnd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void CalendarIcon_displayDateEnd_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label noticeTitle;
        private Label noticeKubun;
        private Label publicationDateLabel;
        private Label displayStartDataLabel;
        private Label displayEndDataLabel;
        private Label noticeBody;
        private TextBox noticeTitleTextBox;
        private ComboBox noticeKubunComboBox;
        private PictureBox calendarIcon_publicationDate;
        private TextBox publicationDateTextBox;
        private PictureBox calendarIcon_displayDateStart;
        private TextBox displayDataStartTextBox;
        private TextBox displayDataEndTextBox;
        private PictureBox calendarIcon_displayDateEnd;
        private TextBox noticeBodyTextBox;
        private Button createButton;
        private Button cancelButton;
        private MonthCalendar publicationDateCalendar;
        private MonthCalendar displayDataStartCalendar;
        private MonthCalendar displayDataEndCalendar;
        private Label UserMessageLabel;
    }
}