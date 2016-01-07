using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autofac;
using Autofac.Configuration;

namespace LearnCSharp.Basic.IoC.Autofac
{
    class AutofacTest
    {
        /// <summary>
        /// 运行测试
        /// </summary>
        public static void Run()
        {
            TestRegisterInstance();
        }

        /// <summary>
        /// 通过编码方加载
        /// </summary>
        public static void TestRegisterType()
        {
            /*
            Console.WriteLine("////////////////////SQL Server////////////////////");
            var mssBuilder = new ContainerBuilder();
            mssBuilder.RegisterType<DatabaseManager>();
            mssBuilder.RegisterType<MssDatabase>().As<IDatabase>();
            using (var container = mssBuilder.Build())
            {
                var manager = container.Resolve<DatabaseManager>();
                manager.Search("SELECT * FORM USER");
            }

            //Oracle
            Console.WriteLine();
            Console.WriteLine("////////////////////Oracle////////////////////");
            var oracleBuilder = new ContainerBuilder();
            oracleBuilder.RegisterType<DatabaseManager>();
            oracleBuilder.RegisterType<OracleDatabase>().As<IDatabase>();
            using (var container = oracleBuilder.Build())
            {
                var manager = container.Resolve<DatabaseManager>();
                manager.Search("SELECT * FORM USER");
            }
            */
        }

        /// <summary>
        /// 测试配置文件
        /// </summary>
        public static void TestAppConfig()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<DatabaseManager>();
            builder.RegisterModule(new ConfigurationSettingsReader("autofac"));
            using (var container = builder.Build())
            {
                var manager = container.Resolve<DatabaseManager>();
                manager.Search("SELECT * FORM USER");
            } 
        }

        /// <summary>
        /// 测试实例注册
        /// </summary>
        public static void TestRegisterInstance()
        {
            User user = new User { Id = 1, Name = "witt" };
            var builder = new ContainerBuilder();
            //配置文件
            builder.RegisterModule(new ConfigurationSettingsReader("autofac"));
            builder.RegisterInstance(user).As<User>();
            builder.Register(c => new DatabaseManager(c.Resolve<IDatabase>(), c.Resolve<User>()));

            using (var container = builder.Build())
            {
                var manager = container.Resolve<DatabaseManager>();
                manager.Add("INSERT INTO USER ...");
            }
        }
    }
}
