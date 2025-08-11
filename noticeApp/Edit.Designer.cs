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
            endData = new Label();
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
            UserMessageLabel.Location = new Point(12, 377);
            UserMessageLabel.Name = "UserMessageLabel";
            UserMessageLabel.Size = new Size(38, 15);
            UserMessageLabel.TabIndex = 29;
            UserMessageLabel.Text = "label1";
            UserMessageLabel.Visible = false;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(221, 404);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 28;
            cancelButton.Text = "戻る";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // createButton
            // 
            createButton.Location = new Point(12, 404);
            createButton.Name = "createButton";
            createButton.Size = new Size(75, 23);
            createButton.TabIndex = 27;
            createButton.Text = "更新";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // displayDataEndTextBox
            // 
            displayDataEndTextBox.Location = new Point(12, 263);
            displayDataEndTextBox.Name = "displayDataEndTextBox";
            displayDataEndTextBox.Size = new Size(171, 23);
            displayDataEndTextBox.TabIndex = 24;
            // 
            // displayDataStartTextBox
            // 
            displayDataStartTextBox.Location = new Point(12, 209);
            displayDataStartTextBox.Name = "displayDataStartTextBox";
            displayDataStartTextBox.Size = new Size(171, 23);
            displayDataStartTextBox.TabIndex = 23;
            // 
            // calendarIcon_publicationDate
            // 
            calendarIcon_publicationDate.Image = (Image)resources.GetObject("calendarIcon_publicationDate.Image");
            calendarIcon_publicationDate.Location = new Point(161, 155);
            calendarIcon_publicationDate.Name = "calendarIcon_publicationDate";
            calendarIcon_publicationDate.Size = new Size(22, 23);
            calendarIcon_publicationDate.SizeMode = PictureBoxSizeMode.StretchImage;
            calendarIcon_publicationDate.TabIndex = 25;
            calendarIcon_publicationDate.TabStop = false;
            // 
            // publicationDateTextBox
            // 
            publicationDateTextBox.Location = new Point(12, 155);
            publicationDateTextBox.Name = "publicationDateTextBox";
            publicationDateTextBox.Size = new Size(171, 23);
            publicationDateTextBox.TabIndex = 22;
            // 
            // noticeKubunComboBox
            // 
            noticeKubunComboBox.FormattingEnabled = true;
            noticeKubunComboBox.Location = new Point(12, 100);
            noticeKubunComboBox.Name = "noticeKubunComboBox";
            noticeKubunComboBox.Size = new Size(121, 23);
            noticeKubunComboBox.TabIndex = 21;
            // 
            // noticeBodyTextBox
            // 
            noticeBodyTextBox.Location = new Point(12, 316);
            noticeBodyTextBox.Multiline = true;
            noticeBodyTextBox.Name = "noticeBodyTextBox";
            noticeBodyTextBox.Size = new Size(284, 58);
            noticeBodyTextBox.TabIndex = 26;
            // 
            // noticeTitleTextBox
            // 
            noticeTitleTextBox.Location = new Point(12, 41);
            noticeTitleTextBox.Name = "noticeTitleTextBox";
            noticeTitleTextBox.Size = new Size(284, 23);
            noticeTitleTextBox.TabIndex = 15;
            // 
            // noticeBody
            // 
            noticeBody.AutoSize = true;
            noticeBody.Location = new Point(12, 298);
            noticeBody.Name = "noticeBody";
            noticeBody.Size = new Size(72, 15);
            noticeBody.TabIndex = 16;
            noticeBody.Text = "お知らせ内容";
            // 
            // endData
            // 
            endData.AutoSize = true;
            endData.Location = new Point(12, 245);
            endData.Name = "endData";
            endData.Size = new Size(91, 15);
            endData.TabIndex = 17;
            endData.Text = "適用終了年月日";
            // 
            // displayStartDataLabel
            // 
            displayStartDataLabel.AutoSize = true;
            displayStartDataLabel.Location = new Point(12, 191);
            displayStartDataLabel.Name = "displayStartDataLabel";
            displayStartDataLabel.Size = new Size(91, 15);
            displayStartDataLabel.TabIndex = 18;
            displayStartDataLabel.Text = "適用開始年月日";
            // 
            // publicationDateLabel
            // 
            publicationDateLabel.AutoSize = true;
            publicationDateLabel.Location = new Point(12, 137);
            publicationDateLabel.Name = "publicationDateLabel";
            publicationDateLabel.Size = new Size(43, 15);
            publicationDateLabel.TabIndex = 19;
            publicationDateLabel.Text = "掲載日";
            // 
            // noticeKubun
            // 
            noticeKubun.AutoSize = true;
            noticeKubun.Location = new Point(12, 82);
            noticeKubun.Name = "noticeKubun";
            noticeKubun.Size = new Size(72, 15);
            noticeKubun.TabIndex = 20;
            noticeKubun.Text = "お知らせ区分";
            // 
            // noticeTitle
            // 
            noticeTitle.AutoSize = true;
            noticeTitle.Location = new Point(12, 23);
            noticeTitle.Name = "noticeTitle";
            noticeTitle.Size = new Size(84, 15);
            noticeTitle.TabIndex = 14;
            noticeTitle.Text = "お知らせタイトル";
            // 
            // calendarIcon_displayDateEnd
            // 
            calendarIcon_displayDateEnd.Image = (Image)resources.GetObject("calendarIcon_displayDateEnd.Image");
            calendarIcon_displayDateEnd.Location = new Point(161, 263);
            calendarIcon_displayDateEnd.Name = "calendarIcon_displayDateEnd";
            calendarIcon_displayDateEnd.Size = new Size(22, 23);
            calendarIcon_displayDateEnd.SizeMode = PictureBoxSizeMode.StretchImage;
            calendarIcon_displayDateEnd.TabIndex = 30;
            calendarIcon_displayDateEnd.TabStop = false;
            // 
            // calendarIcon_displayDateStart
            // 
            calendarIcon_displayDateStart.Image = (Image)resources.GetObject("calendarIcon_displayDateStart.Image");
            calendarIcon_displayDateStart.Location = new Point(161, 209);
            calendarIcon_displayDateStart.Name = "calendarIcon_displayDateStart";
            calendarIcon_displayDateStart.Size = new Size(22, 23);
            calendarIcon_displayDateStart.SizeMode = PictureBoxSizeMode.StretchImage;
            calendarIcon_displayDateStart.TabIndex = 31;
            calendarIcon_displayDateStart.TabStop = false;
            // 
            // displayDataEndCalendar
            // 
            displayDataEndCalendar.Location = new Point(106, 223);
            displayDataEndCalendar.Name = "displayDataEndCalendar";
            displayDataEndCalendar.TabIndex = 34;
            displayDataEndCalendar.Visible = false;
            // 
            // displayDataStartCalendar
            // 
            displayDataStartCalendar.Location = new Point(106, 187);
            displayDataStartCalendar.Name = "displayDataStartCalendar";
            displayDataStartCalendar.TabIndex = 33;
            displayDataStartCalendar.Visible = false;
            // 
            // publicationDateCalendar
            // 
            publicationDateCalendar.Location = new Point(106, 155);
            publicationDateCalendar.Name = "publicationDateCalendar";
            publicationDateCalendar.TabIndex = 32;
            publicationDateCalendar.Visible = false;
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 450);
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
            Controls.Add(endData);
            Controls.Add(displayStartDataLabel);
            Controls.Add(publicationDateLabel);
            Controls.Add(noticeKubun);
            Controls.Add(noticeTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
        private Label endData;
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