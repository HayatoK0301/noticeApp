using noticeApp.Model;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace noticeApp
{
    public partial class Form1 : Form
    {
        private List<NoticeTable> allData;  // 全件データ
        private int pageSize = 1000;     // 1ページの件数
        private int pageIndex = 0;     // 現在ページ (0スタート)

        public Form1()
        {
            InitializeComponent();
            pageSizeLabel.Text = "0 / 1000";
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

        private void createButton_Click(object sender, EventArgs e)
        {
            Create createFrom = new Create();
            createFrom.ShowDialog();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (ValidationCheck())
            {
                SearchNotice();
            }
            else
            {
                noticeDataGridView.DataSource = null;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var selectRow = noticeDataGridView.CurrentRow.DataBoundItem as NoticeTable;
            if (selectRow != null)
            {
                using (var context = new Context())
                {
                    int id = selectRow.Id;
                    var removeData = context.NoticeTable.FirstOrDefault(n => n.Id == id);
                    removeData.DeleteFlag = true;
                    //context.NoticeTable.Remove(removeData);
                    context.SaveChanges();
                    searchButton_Click(sender, e);
                }
            }
        }

        private void calendarIcon_publicationDate_Click(object sender, EventArgs e)
        {
            publicationDateCalendar.Location = new Point(publicationDate.Left, publicationDate.Bottom);
            publicationDateCalendar.Visible = true;
        }

        private void publicationDateCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            publicationDate.Text = e.Start.ToShortDateString();
            publicationDateCalendar.Visible = false;
        }

        private void calendarIcon_displayDateStart_Click(object sender, EventArgs e)
        {
            displayDataStartCalendar.Location = new Point(displayDataStart.Left, displayDataStart.Bottom);
            displayDataStartCalendar.Visible = true;
        }

        private void displayDataStartCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            displayDataStart.Text = e.Start.ToShortDateString();
            displayDataStartCalendar.Visible = false;
        }

        private void calendarIcon_displayDateEnd_Click(object sender, EventArgs e)
        {
            displayDataEndCalendar.Location = new Point(displayDataEnd.Left, displayDataEnd.Bottom);
            displayDataEndCalendar.Visible = true;
        }

        private void displayDataEndCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            displayDataEnd.Text = e.Start.ToShortDateString();
            displayDataEndCalendar.Visible = false;
        }

        private void SearchNotice()
        {
            using (var context = new Context())
            {
                var query = context.NoticeTable.AsQueryable();
                if (!string.IsNullOrEmpty(noticeTitleBox.Text))
                {
                    query = query.Where(n => n.Title.Contains(noticeTitleBox.Text));
                }

                if (!string.IsNullOrEmpty(noticeKubunComboBox.Text))
                {
                    query = query.Where(n => n.Kubun == noticeKubunComboBox.Text);
                }

                if (!string.IsNullOrEmpty(publicationDate.Text))
                {
                    DateTime date = DateTime.Parse(publicationDate.Text);
                    query = query.Where(n => n.PublicationDate == date);
                }

                if (!string.IsNullOrEmpty(displayDataStart.Text))
                {
                    DateTime date = DateTime.Parse(displayDataStart.Text);
                    query = query.Where(n => n.DisplayStartData >= date);
                }

                if (!string.IsNullOrEmpty(displayDataEnd.Text))
                {
                    DateTime date = DateTime.Parse(displayDataEnd.Text);
                    query = query.Where(n => n.DisplayEndData <= date);
                }

                query = query.Where(n => n.DeleteFlag == false);
                //noticeDataGridView.DataSource = query.ToList();
                allData = query.ToList();
                SettingDataGridView();
            }
        }

        private void SettingDataGridView()
        {
            // ページごとにデータを切り出し
            var pageData = allData
                .Skip(pageIndex * pageSize)
                .Take(pageSize)
                .ToList();

            // DataGridViewにバインド
            noticeDataGridView.DataSource = null;
            noticeDataGridView.DataSource = pageData;

            if (pageData.Count >= 1000)
            {
                pageSizeLabel.Text = "1000 / 1000";
            }
            else
            {
                pageSizeLabel.Text = $"{pageData.Count} / 1000";
            }

            noticeDataGridView.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            noticeDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            noticeDataGridView.Columns["Id"].Visible = false;
            noticeDataGridView.Columns["NoticeBody"].Visible = false;
            noticeDataGridView.Columns["Title"].HeaderText = "お知らせタイトル";
            noticeDataGridView.Columns["Kubun"].HeaderText = "お知らせ区分";
            noticeDataGridView.Columns["PublicationDate"].HeaderText = "掲載日";
            noticeDataGridView.Columns["DisplayStartData"].HeaderText = "適用開始期間";
            noticeDataGridView.Columns["DisplayEndData"].HeaderText = "適用終了期間";
            noticeDataGridView.Columns["DeleteFlag"].Visible = false;
        }

        private bool ValidationCheck()
        {
            if (noticeTitleBox.Text.Length > 100)
            {
                SetUserMessage(noticeTitle.Text, 100);
                return false;
            }

            DateTime dt;
            if (!string.IsNullOrEmpty(publicationDate.Text))
            {
                if (!DateTime.TryParse(publicationDate.Text, out dt))
                {
                    SetUserMessage(publicationDateLabel.Text, 0);
                    return false;
                }

                if (publicationDate.Text.Length > 10)
                {
                    SetUserMessage(publicationDateLabel.Text, 10);
                    return false;
                }
            }

            if (!string.IsNullOrEmpty(displayDataStart.Text))
            {
                if (!DateTime.TryParse(displayDataStart.Text, out dt))
                {
                    SetUserMessage(displayDate.Text, 0);
                    return false;
                }

                if (displayDataStart.Text.Length > 10)
                {
                    SetUserMessage(displayDate.Text, 10);
                    return false;
                }
            }

            if (!string.IsNullOrEmpty(displayDataEnd.Text))
            {
                if (!DateTime.TryParse(displayDataEnd.Text, out dt))
                {
                    SetUserMessage(displayDate.Text, 0);
                    return false;
                }

                if (displayDataEnd.Text.Length > 10)
                {
                    SetUserMessage(displayDate.Text, 10);
                    return false;
                }
            }

            if (!string.IsNullOrEmpty(displayDataStart.Text) && !string.IsNullOrEmpty(displayDataEnd.Text))
            {
                DateTime startDate = DateTime.Parse(displayDataStart.Text);
                DateTime endDate = DateTime.Parse(displayDataEnd.Text);

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

        private void editButton_Click(object sender, EventArgs e)
        {
            if (noticeDataGridView.Rows.Count > 0 &&
                (noticeDataGridView.SelectedRows.Count > 0 || noticeDataGridView.SelectedCells.Count > 0))
            {
                var selectRow = noticeDataGridView.CurrentRow.DataBoundItem as NoticeTable;
                if (selectRow != null)
                {
                    UserMessageLabel.Visible = false;
                    Edit editForm = new Edit(selectRow.Id);
                    editForm.ShowDialog();
                }
            }
            else
            {
                UserMessageLabel.Text = "行を選択してください。";
                UserMessageLabel.Visible = true;
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (pageIndex > 0)
            {
                pageIndex--;
                SettingDataGridView();
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            int totalPage = (int)Math.Ceiling((double)allData.Count / pageSize);
            if (pageIndex < totalPage - 1)
            {
                pageIndex++;
                SettingDataGridView();
            }
        }
    }
}
