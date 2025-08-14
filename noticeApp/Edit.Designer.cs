namespace noticeApp
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            UserMessageLabel = new Label();
            cancelButton = new Button();
            createButton = new Button();
            displayDataEndTextBox = new TextBox();
            displayDataStartTextBox = new TextBox();
            calendarIcon_publicationDate = new PictureBox();
            publicationDateTextBox = new TextBox();
            noticeKubunComboBox = new ComboBox();
            noticeBodyTextBox = new TextBox();
            noticeTitleTextBox = new TextBox();
            noticeBody = new Label();
            displayEndDataLabel = new Label();
            displayStartDataLabel = new Label();
            publicationDateLabel = new Label();
            noticeKubun = new Label();
            noticeTitle = new Label();
            calendarIcon_displayDateEnd = new PictureBox();
            calendarIcon_displayDateStart = new PictureBox();
            displayDataEndCalendar = new MonthCalendar();
            displayDataStartCalendar = new MonthCalendar();
            publicationDateCalendar = new MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)calendarIcon_publicationDate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)calendarIcon_displayDateEnd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)calendarIcon_displayDateStart).BeginInit();
            SuspendLayout();
            // 
            // UserMessageLabel
            // 
            UserMessageLabel.AutoSize = true;
            UserMessageLabel.ForeColor = Color.Red;
            UserMessageLabel.Location = new Point(14, 484);
            UserMessageLabel.Name = "UserMessageLabel";
            UserMessageLabel.Size = new Size(50, 20);
            UserMessageLabel.TabIndex = 29;
            UserMessageLabel.Text = "label1";
            UserMessageLabel.Visible = false;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(253, 548);
            cancelButton.Margin = new Padding(3, 4, 3, 4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(86, 31);
            cancelButton.TabIndex = 28;
            cancelButton.Text = "戻る";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // createButton
            // 
            createButton.Location = new Point(14, 548);
            createButton.Margin = new Padding(3, 4, 3, 4);
            createButton.Name = "createButton";
            createButton.Size = new Size(86, 31);
            createButton.TabIndex = 27;
            createButton.Text = "更新";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // displayDataEndTextBox
            // 
            displayDataEndTextBox.Location = new Point(14, 332);
            displayDataEndTextBox.Margin = new Padding(3, 4, 3, 4);
            displayDataEndTextBox.Name = "displayDataEndTextBox";
            displayDataEndTextBox.Size = new Size(195, 27);
            displayDataEndTextBox.TabIndex = 24;
            // 
            // displayDataStartTextBox
            // 
            displayDataStartTextBox.Location = new Point(14, 260);
            displayDataStartTextBox.Margin = new Padding(3, 4, 3, 4);
            displayDataStartTextBox.Name = "displayDataStartTextBox";
            displayDataStartTextBox.Size = new Size(195, 27);
            displayDataStartTextBox.TabIndex = 23;
            // 
            // calendarIcon_publicationDate
            // 
            calendarIcon_publicationDate.Image = (Image)resources.GetObject("calendarIcon_publicationDate.Image");
            calendarIcon_publicationDate.Location = new Point(184, 185);
            calendarIcon_publicationDate.Margin = new Padding(3, 4, 3, 4);
            calendarIcon_publicationDate.Name = "calendarIcon_publicationDate";
            calendarIcon_publicationDate.Size = new Size(25, 31);
            calendarIcon_publicationDate.SizeMode = PictureBoxSizeMode.StretchImage;
            calendarIcon_publicationDate.TabIndex = 25;
            calendarIcon_publicationDate.TabStop = false;
            calendarIcon_publicationDate.Click += calendarIcon_publicationDate_Click;
            // 
            // publicationDateTextBox
            // 
            publicationDateTextBox.Location = new Point(14, 188);
            publicationDateTextBox.Margin = new Padding(3, 4, 3, 4);
            publicationDateTextBox.Name = "publicationDateTextBox";
            publicationDateTextBox.Size = new Size(195, 27);
            publicationDateTextBox.TabIndex = 22;
            // 
            // noticeKubunComboBox
            // 
            noticeKubunComboBox.FormattingEnabled = true;
            noticeKubunComboBox.Location = new Point(14, 115);
            noticeKubunComboBox.Margin = new Padding(3, 4, 3, 4);
            noticeKubunComboBox.Name = "noticeKubunComboBox";
            noticeKubunComboBox.Size = new Size(138, 28);
            noticeKubunComboBox.TabIndex = 21;
            // 
            // noticeBodyTextBox
            // 
            noticeBodyTextBox.Location = new Point(14, 403);
            noticeBodyTextBox.Margin = new Padding(3, 4, 3, 4);
            noticeBodyTextBox.Multiline = true;
            noticeBodyTextBox.Name = "noticeBodyTextBox";
            noticeBodyTextBox.Size = new Size(324, 76);
            noticeBodyTextBox.TabIndex = 26;
            // 
            // noticeTitleTextBox
            // 
            noticeTitleTextBox.Location = new Point(14, 36);
            noticeTitleTextBox.Margin = new Padding(3, 4, 3, 4);
            noticeTitleTextBox.Name = "noticeTitleTextBox";
            noticeTitleTextBox.Size = new Size(324, 27);
            noticeTitleTextBox.TabIndex = 15;
            // 
            // noticeBody
            // 
            noticeBody.AutoSize = true;
            noticeBody.Location = new Point(14, 379);
            noticeBody.Name = "noticeBody";
            noticeBody.Size = new Size(90, 20);
            noticeBody.TabIndex = 16;
            noticeBody.Text = "お知らせ内容";
            // 
            // displayEndDataLabel
            // 
            displayEndDataLabel.AutoSize = true;
            displayEndDataLabel.Location = new Point(14, 308);
            displayEndDataLabel.Name = "displayEndDataLabel";
            displayEndDataLabel.Size = new Size(114, 20);
            displayEndDataLabel.TabIndex = 17;
            displayEndDataLabel.Text = "適用終了年月日";
            // 
            // displayStartDataLabel
            // 
            displayStartDataLabel.AutoSize = true;
            displayStartDataLabel.Location = new Point(14, 236);
            displayStartDataLabel.Name = "displayStartDataLabel";
            displayStartDataLabel.Size = new Size(114, 20);
            displayStartDataLabel.TabIndex = 18;
            displayStartDataLabel.Text = "適用開始年月日";
            // 
            // publicationDateLabel
            // 
            publicationDateLabel.AutoSize = true;
            publicationDateLabel.Location = new Point(14, 164);
            publicationDateLabel.Name = "publicationDateLabel";
            publicationDateLabel.Size = new Size(54, 20);
            publicationDateLabel.TabIndex = 19;
            publicationDateLabel.Text = "掲載日";
            // 
            // noticeKubun
            // 
            noticeKubun.AutoSize = true;
            noticeKubun.Location = new Point(14, 91);
            noticeKubun.Name = "noticeKubun";
            noticeKubun.Size = new Size(90, 20);
            noticeKubun.TabIndex = 20;
            noticeKubun.Text = "お知らせ区分";
            // 
            // noticeTitle
            // 
            noticeTitle.AutoSize = true;
            noticeTitle.Location = new Point(14, 12);
            noticeTitle.Name = "noticeTitle";
            noticeTitle.Size = new Size(104, 20);
            noticeTitle.TabIndex = 14;
            noticeTitle.Text = "お知らせタイトル";
            // 
            // calendarIcon_displayDateEnd
            // 
            calendarIcon_displayDateEnd.Image = (Image)resources.GetObject("calendarIcon_displayDateEnd.Image");
            calendarIcon_displayDateEnd.Location = new Point(184, 329);
            calendarIcon_displayDateEnd.Margin = new Padding(3, 4, 3, 4);
            calendarIcon_displayDateEnd.Name = "calendarIcon_displayDateEnd";
            calendarIcon_displayDateEnd.Size = new Size(25, 31);
            calendarIcon_displayDateEnd.SizeMode = PictureBoxSizeMode.StretchImage;
            calendarIcon_displayDateEnd.TabIndex = 30;
            calendarIcon_displayDateEnd.TabStop = false;
            calendarIcon_displayDateEnd.Click += calendarIcon_displayDateEnd_Click;
            // 
            // calendarIcon_displayDateStart
            // 
            calendarIcon_displayDateStart.Image = (Image)resources.GetObject("calendarIcon_displayDateStart.Image");
            calendarIcon_displayDateStart.Location = new Point(184, 257);
            calendarIcon_displayDateStart.Margin = new Padding(3, 4, 3, 4);
            calendarIcon_displayDateStart.Name = "calendarIcon_displayDateStart";
            calendarIcon_displayDateStart.Size = new Size(25, 31);
            calendarIcon_displayDateStart.SizeMode = PictureBoxSizeMode.StretchImage;
            calendarIcon_displayDateStart.TabIndex = 31;
            calendarIcon_displayDateStart.TabStop = false;
            calendarIcon_displayDateStart.Click += calendarIcon_displayDateStart_Click;
            // 
            // displayDataEndCalendar
            // 
            displayDataEndCalendar.Location = new Point(121, 297);
            displayDataEndCalendar.Margin = new Padding(10, 12, 10, 12);
            displayDataEndCalendar.Name = "displayDataEndCalendar";
            displayDataEndCalendar.TabIndex = 34;
            displayDataEndCalendar.Visible = false;
            displayDataEndCalendar.DateSelected += displayDataEndCalendar_DateSelected;
            // 
            // displayDataStartCalendar
            // 
            displayDataStartCalendar.Location = new Point(121, 249);
            displayDataStartCalendar.Margin = new Padding(10, 12, 10, 12);
            displayDataStartCalendar.Name = "displayDataStartCalendar";
            displayDataStartCalendar.TabIndex = 33;
            displayDataStartCalendar.Visible = false;
            displayDataStartCalendar.DateSelected += displayDataStartCalendar_DateSelected;
            // 
            // publicationDateCalendar
            // 
            publicationDateCalendar.Location = new Point(121, 207);
            publicationDateCalendar.Margin = new Padding(10, 12, 10, 12);
            publicationDateCalendar.Name = "publicationDateCalendar";
            publicationDateCalendar.TabIndex = 32;
            publicationDateCalendar.Visible = false;
            publicationDateCalendar.DateSelected += publicationDateCalendar_DateSelected;
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 590);
            Controls.Add(displayDataEndCalendar);
            Controls.Add(displayDataStartCalendar);
            Controls.Add(publicationDateCalendar);
            Controls.Add(calendarIcon_displayDateEnd);
            Controls.Add(calendarIcon_displayDateStart);
            Controls.Add(UserMessageLabel);
            Controls.Add(cancelButton);
            Controls.Add(createButton);
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
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Edit";
            Text = "Edit";
            ((System.ComponentModel.ISupportInitialize)calendarIcon_publicationDate).EndInit();
            ((System.ComponentModel.ISupportInitialize)calendarIcon_displayDateEnd).EndInit();
            ((System.ComponentModel.ISupportInitialize)calendarIcon_displayDateStart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserMessageLabel;
        private Button cancelButton;
        private Button createButton;
        private TextBox displayDataEndTextBox;
        private TextBox displayDataStartTextBox;
        private PictureBox calendarIcon_publicationDate;
        private TextBox publicationDateTextBox;
        private ComboBox noticeKubunComboBox;
        private TextBox noticeBodyTextBox;
        private TextBox noticeTitleTextBox;
        private Label noticeBody;
        private Label displayEndDataLabel;
        private Label displayStartDataLabel;
        private Label publicationDateLabel;
        private Label noticeKubun;
        private Label noticeTitle;
        private PictureBox calendarIcon_displayDateEnd;
        private PictureBox calendarIcon_displayDateStart;
        private MonthCalendar displayDataEndCalendar;
        private MonthCalendar displayDataStartCalendar;
        private MonthCalendar publicationDateCalendar;
    }
}