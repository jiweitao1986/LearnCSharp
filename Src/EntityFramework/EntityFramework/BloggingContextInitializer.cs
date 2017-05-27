using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class BloggingContextInitializer : DropCreateDatabaseIfModelChanges<BloggingContext>
    {
        /// <summary>
        /// 上下文
        /// </summary>
        private BloggingContext _context;

        /// <summary>
        /// 初始化数据
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(BloggingContext context)
        {
            _context = context;
            AddBlogs();
            base.Seed(context);
        }

        /// <summary>
        /// 添加产品
        /// </summary>
        private void AddBlogs()
        {
            _context.Blogs.Add(new Blog
            {
                Name = "Monday's Blog",
                CreatedDate = DateTime.Now,
                IsPublished = true,
                Tag = BlogTag.Life
            });
            _context.Blogs.Add(new Blog
            {
                Name = "Thuesday's Blog",
                CreatedDate = DateTime.Now,
                IsPublished = false,
                Tag = BlogTag.Work
            });
            _context.Blogs.Add(new Blog
            {
                Name = "Wednesday's Blog",
                CreatedDate = DateTime.Now,
                IsPublished = true,
                Tag = BlogTag.Reading
            });
        }

        /// <summary>
        /// 添加分类
        /// </summary>
        private void AddPosts()
        {
        }
    }
}
