using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlSugar.Model
{
    [SugarTable("BlogNews")]
    public class BlogNews : BaseId
    {
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnDataType = "varchar(200)")]
        public string Title { get; set; }

        /// <summary>
        /// 博客内容
        /// </summary>
        [SugarColumn(ColumnDataType = "text")]
        public string Content { get; set; }


        /// <summary>
        /// 映射不到数据库
        /// </summary>
        [SugarColumn(IsIgnore = true)]
        public string AB { get; set; }

    }
}
