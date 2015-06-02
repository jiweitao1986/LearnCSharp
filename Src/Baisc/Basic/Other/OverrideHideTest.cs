﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Basic.Other
{
    class OverrideHideTest
    {
        public static void Run()
        {
            MyDerivedClass derivedObj = new MyDerivedClass();
            MyBaseClass baseObj = derivedObj;

            Console.WriteLine("//////////基类：替换基类中虚方法//////////");
            baseObj.VirtualOverrideMethod();

            Console.WriteLine("//////////子类：替换基类中虚方法//////////");
            derivedObj.VirtualOverrideMethod();

            Console.WriteLine("//////////基类：重写基类中虚方法//////////");
            baseObj.VirtualNewMethod();

            Console.WriteLine("//////////子类：重写基类中虚方法//////////");
            derivedObj.VirtualNewMethod();

            Console.WriteLine("//////////基类：隐藏基类中非虚方法//////////");
            baseObj.NotVirtualNewMethod();

            Console.WriteLine("//////////子类：重写基类中虚方法//////////");
            derivedObj.VirtualNewMethod();

        
        }
    }


    class MyBaseClass
    {
        /// <summary>
        /// 该方法将被替换
        /// </summary>
        public virtual void VirtualOverrideMethod()
        {
            Console.WriteLine("I am VirtualOverrideMethod in base class !");
        }

        /// <summary>
        /// 该方法将被重写
        /// </summary>
        public virtual void VirtualNewMethod()
        {
            Console.WriteLine("I am VirtualNewMethod in base class !");
        }


        /// <summary>
        /// 该方法将被隐藏
        /// </summary>
        public void NotVirtualNewMethod()
        {
            Console.WriteLine("I am NotVirtualNewMethod in base class !");
        }

    }

    class MyDerivedClass : MyBaseClass
    {
        /// <summary>
        /// 替换基类中虚方法
        /// </summary>
        public override void VirtualOverrideMethod()
        {
            base.VirtualOverrideMethod();
            Console.WriteLine("I am VirtualOverrideMethod in derived class !");
        }

        /// <summary>
        /// 重写基类中虚方法
        /// </summary>
        new public void VirtualNewMethod()
        {
            base.VirtualNewMethod();
            Console.WriteLine("I am VirtualNewMethod in derived class !");
        }

        /// <summary>
        /// 隐藏基类中非虚方法
        /// </summary>

        new public void NotVirtualNewMethod()
        {
            base.NotVirtualNewMethod();
            Console.WriteLine("I am NotVirtualNewMethod in derived class !");
        }
    }
}