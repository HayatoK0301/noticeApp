using noticeApp.Model;

namespace noticeApp
{
    public partial class Create : Form
    {


        public Create()
        {
            InitializeComponent();
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            SetKubunComboBox();
        }

        private void SetKubunComboBox()
        {
            using (var context = new Context())
            {
                var kubuns = context.KubunTable.ToList();
                foreach (var kubun in kubuns)
                {
                    noticeKubunComboBox.Items.Add(kubun.Kubun);
                }

                noticeKubunComboBox.SelectedIndex = 0;
                noticeKubunComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (ValidationCheck())
            {
                CreateNotice();
                this.Close();
            }            
        }

        private void CreateNotice()
        {
            string title = noticeTitleTextBox.Text;
            string kubun = noticeKubunComboBox.Text;

            DateTime publicationDate = 
                string.IsNullOrEmpty(publicationDateTextBox.Text) ? DateTime.MinValue : DateTime.Parse(publicationDateTextBox.Text);
            DateTime displayStartData = 
                string.IsNullOrEmpty(displayDataStartTextBox.Text) ? DateTime.MinValue:  DateTime.Parse(displayDataStartTextBox.Text);
            DateTime displayEndData = 
                string.IsNullOrEmpty(displayDataEndTextBox.Text) ? DateTime.MinValue : DateTime.Parse(displayDataEndTextBox.Text);
            string noticeBody = noticeBodyTextBox.Text;

            NoticeTable noticeTable = new NoticeTable();
            noticeTable.Title = title;
            noticeTable.Kubun = kubun;
            noticeTable.PublicationDate = publicationDate;
            noticeTable.DisplayStartData = displayStartData;
            noticeTable.DisplayEndData = displayEndData;
            noticeTable.NoticeBody = noticeBody;

            using (var context = new Context())
            {
                context.NoticeTable.Add(noticeTable);
                context.SaveChanges();
            }
        }

        private void calendarIcon_publicationDate_Click(object sender, EventArgs e)
        {
            publicationDateCalendar.Location = new Point(publicationDateTextBox.Left, publicationDateTextBox.Bottom);
            publicationDateCalendar.Visible = true;
        }

        private void publicationDateCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            publicationDateTextBox.Text = e.Start.ToShortDateString();
            publicationDateCalendar.Visible = false;
        }

        private void calendarIcon_displayDateStart_Click(object sender, EventArgs e)
        {
            displayDataStartCalendar.Location = new Point(displayDataStartTextBox.Left, displayDataStartTextBox.Bottom);
            displayDataStartCalendar.Visible = true;
        }

        private void displayDataStartCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            displayDataStartTextBox.Text = e.Start.ToShortDateString();
            displayDataStartCalendar.Visible = false;
        }

        private void calendarIcon_displayDateEnd_Click(object sender, EventArgs e)
        {
            displayDataEndCalendar.Location = new Point(displayDataEndTextBox.Left, displayDataEndTextBox.Bottom);
            displayDataEndCalendar.Visible = true;
        }

        private void displayDataEndCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            displayDataEndTextBox.Text = e.Start.ToShortDateString();
            displayDataEndCalendar.Visible = false;
        }

        private bool ValidationCheck()
        {
            if (string.IsNullOrEmpty(noticeTitleTextBox.Text))
            {
                UserMessageLabel.Text = "お知らせタイトルは必須入力項目です。\r\n入力してください。";
                UserMessageLabel.Visible = true;
                return false;
            }

            if (noticeTitleTextBox.Text.Length > 100)
            {
                SetUserMessage(noticeTitle.Text, 100);
                return false;
            }

            DateTime dt;
            if (!string.IsNullOrEmpty(publicationDateTextBox.Text))
            {
                if (!DateTime.TryParse(publicationDateTextBox.Text, out dt))
                {
                    SetUserMessage(publicationDateLabel.Text, 0);
                    return false;
                }

                if (publicationDateTextBox.Text.Length > 10)
                {
                    SetUserMessage(publicationDateLabel.Text, 10);
                    return false;
                }
            }

            if (!string.IsNullOrEmpty(displayDataStartTextBox.Text))
            {
                if (!DateTime.TryParse(displayDataStartTextBox.Text, out dt))
                {
                    SetUserMessage(displayStartDataLabel.Text, 0);
                    return false;
                }

                if (displayDataStartTextBox.Text.Length > 10)
                {
                    SetUserMessage(displayStartDataLabel.Text, 10);
                    return false;
                }
            }

            if (!string.IsNullOrEmpty(displayDataEndTextBox.Text))
            {
                if (!DateTime.TryParse(displayDataEndTextBox.Text, out dt))
                {
                    SetUserMessage(displayEndDataLabel.Text, 0);
                    return false;
                }

                if (displayDataEndTextBox.Text.Length > 10)
                {
                    SetUserMessage(displayEndDataLabel.Text, 10);
                    return false;
                }
            }

            if (!string.IsNullOrEmpty(displayDataStartTextBox.Text) && !string.IsNullOrEmpty(displayDataEndTextBox.Text))
            {
                DateTime startDate = DateTime.Parse(displayDataStartTextBox.Text);
                DateTime endDate = DateTime.Parse(displayDataEndTextBox.Text);

                if (startDate > endDate)
                {
                    UserMessageLabel.Text = "適用開始日よりも前の適用開始日で検索することはできません。";
                    UserMessageLabel.Visible = true;
                    return false;
                }
            }

            UserMessageLabel.Visible = false;
            return true;
        }

        private void SetUserMessage(string target, int length)
        {
            if (length > 0)
            {
                UserMessageLabel.Text = $"{target}は{length.ToString()}文字以下で入力してください。";
            }
            else
            {
                UserMessageLabel.Text = $"{target}に入力された日時の形式が不正です。";
            }

            UserMessageLabel.Visible = true;
        }
    }
}
