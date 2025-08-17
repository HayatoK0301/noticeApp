using noticeApp.Model;
using System.Data.Entity;
//using noticeApp.;

namespace noticeApp
{
    public class Context : DbContext
    {
        public Context() : base("name=NoticeConnection")
        {
        }
        public virtual DbSet<NoticeTable> NoticeTable { get; set; }
        public virtual DbSet<KubunTable> KubunTable { get; set; }
    }
}
