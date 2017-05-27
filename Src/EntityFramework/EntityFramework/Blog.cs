using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class Blog
    {
        /// <summary>
        /// 博客ID
        /// </summary>
        public int BlogId { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// 是否已经发布
        /// </summary>
        public bool IsPublished { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        public BlogTag Tag { get; set; }

        /// <summary>
        /// 评论集合
        /// </summary>
        public virtual List<Post> Posts { get; set; }

    }

    public enum BlogTag
    {
        Life,
        Work,
        Reading,
        Photo
    }


}
