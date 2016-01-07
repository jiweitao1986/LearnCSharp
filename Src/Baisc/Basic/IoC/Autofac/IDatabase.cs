﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Basic.IoC.Autofac
{
    /// <summary>
    /// 数据库操作
    /// </summary>
    public interface IDatabase
    {
        string Name { get; }

        void Select(string commandText);

        void Insert(string commandText);

        void Update(string commandText);

        void Delete(string commandText);
    }
}
