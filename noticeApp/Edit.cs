using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace noticeApp
{
    public partial class Edit : Form
    {
        private int _id = 0;

        public Edit(int id)
        {
            InitializeComponent();
            _id = id;
            LoadEdit();
        }

        private void LoadEdit()
        {
            using (var context = new Context())
            {
                var query = context.NoticeTable.AsQueryable();
                query = query.Where(n => n.Id == _id);
                noticeTitleTextBox.Text = query.FirstOrDefault().Title;

                string selectKubun = query.FirstOrDefault().Kubun;

                var kubuns = context.KubunTable.ToList();
                foreach (var kubun in kubuns)
                {
                    noticeKubunComboBox.Items.Add(kubun.Kubun);
                }

                noticeKubunComboBox.SelectedItem = selectKubun;

                publicationDateTextBox.Text = query.FirstOrDefault().PublicationDate.ToString("yyyy/MM/dd");
                displayDataStartTextBox.Text = query.FirstOrDefault().DisplayStartData.ToString("yyyy/MM/dd");
                displayDataEndTextBox.Text = query.FirstOrDefault().DisplayEndData.ToString("yyyy/MM/dd");
                noticeBodyTextBox.Text = query.FirstOrDefault().NoticeBody;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void createButton_Click(object sender, EventArgs e)
        {
            if (ValidationCheck())
            {
                UpdateNoticeApp();
                this.Close();
            }
            
        }

        private void UpdateNoticeApp()
        {
            using (var context = new Context())
            {
                var query = context.NoticeTable.AsQueryable();
                query = query.Where(n => n.Id == _id);
                query.FirstOrDefault().Title = noticeTitleTextBox.Text;
                query.FirstOrDefault().Kubun = noticeKubunComboBox.Text;
                DateTime publicationDate = DateTime.Parse(publicationDateTextBox.Text);
                DateTime displayStartData = DateTime.Parse(displayDataStartTextBox.Text);
                DateTime displayEndData = DateTime.Parse(displayDataEndTextBox.Text);
                query.FirstOrDefault().PublicationDate = publicationDate;
                query.FirstOrDefault().DisplayStartData = displayStartData;
                query.FirstOrDefault().DisplayEndData = displayEndData;
                query.FirstOrDefault().NoticeBody = noticeBodyTextBox.Text;

                context.SaveChanges();
            }
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
