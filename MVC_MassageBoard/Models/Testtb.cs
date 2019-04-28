using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace MVC_MassageBoard.Models
{
    public class Testtb
    {
        // 代碼
        [Key]
        [DisplayName("留言代碼")]
        public string user { get; set; }

        // 標題
        [Required]
        [DisplayName("標題")]
        public string title { get; set; }

        // 內容
        [Required]
        [DisplayName("內容")]
        public string commet { get; set; }

        // 日期
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode =true)]
        [DisplayName("日期")]
        public DateTime date { get; set; }
    }
}