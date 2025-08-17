using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noticeApp.Model
{
    public class KubunTable
    {
        [Key]
        public int Id { get; set; }

        public string Kubun { get; set; }
    }
}
