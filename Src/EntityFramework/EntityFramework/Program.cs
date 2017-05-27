using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new BloggingContextInitializer());

            var db = new BloggingContext();

            //新增一条
            //string name = "Hello World !";
            //var blog = new Blog { Name = name };
            //db.Blogs.Add(blog);
            //db.SaveChanges();

            //获取第3条数据
            var thuesdayBlog = (from b in db.Blogs
                where b.BlogId == 2
                select b).FirstOrDefault();
            thuesdayBlog.Name = "周二的Blog";

            //删除第三条数据
            var wednesdayBlog = db.Blogs.Find(3);
            db.Blogs.Remove(wednesdayBlog);

            db.SaveChanges();

            //查询
            var query = from b in db.Blogs
                        orderby b.Name
                        select b;
            foreach (var item in query)
            {
                Console.WriteLine(
                    item.BlogId + "\t\t"
                    + item.Name + "\t\t"
                    + item.CreatedDate.ToString("yyyy-MM-dd") + "\t\t"
                    + item.IsPublished.ToString());
            }

           

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

    }
}
