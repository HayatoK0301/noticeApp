using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace noticeApp.Model
{
    public class NoticeTable
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }

        public string Kubun { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime PublicationDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DisplayStartData { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DisplayEndData { get; set; }

        public string NoticeBody { get; set; }

        public bool DeleteFlag { get; set; }
    }
}
