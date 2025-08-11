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

            //noticeKubunComboBox.Items.Add("お知らせ");
            //noticeKubunComboBox.Items.Add("要確認");
            //noticeKubunComboBox.Items.Add("重要");
            //noticeKubunComboBox.SelectedIndex = 0;
            noticeKubunComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoadEdit()
        {
            using (var context = new Context())
            {
                var query = context.NoticeTable.AsQueryable();
                query = query.Where(n => n.Id == _id);
                noticeTitleTextBox.Text = query.FirstOrDefault().Title;

                string kubun = query.FirstOrDefault().Kubun;
                noticeKubunComboBox.Items.Add("お知らせ");
                noticeKubunComboBox.Items.Add("要確認");
                noticeKubunComboBox.Items.Add("重要");
                noticeKubunComboBox.SelectedItem = kubun;

                publicationDateTextBox.Text = query.FirstOrDefault().PublicationDate.ToString();
                displayDataStartTextBox.Text = query.FirstOrDefault().DisplayStartData.ToString();
                displayDataEndTextBox.Text = query.FirstOrDefault().DisplayEndData.ToString();
                noticeBodyTextBox.Text = query.FirstOrDefault().NoticeBody;
            }
        }

        private void createButton_Click(object sender, EventArgs e)
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
            this.Close();
        }
    }
}
