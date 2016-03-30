using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.WinForm.Other.PropertyGridTest.SimpleTest
{
    [DefaultPropertyAttribute("Name")]
    class Person
    {
        private string name;

        private  Gender gender;

        private DateTime birthday;

        private bool isSingle;



        private Color favColor;

        private DayOfWeek favDay;

        
        

        [Category("基本信息"), DescriptionAttribute("人员姓名")]
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        [CategoryAttribute("基本信息"), DescriptionAttribute("年龄")]
        public Gender Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        [CategoryAttribute("基本信息"), DescriptionAttribute("生日")]
        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
            }
        }

        [CategoryAttribute("基本信息"), DescriptionAttribute("是否单身")]
        public Boolean IsSignle
        {
            get
            {
                return isSingle ;
            }
            set
            {
                isSingle = value;
            }
        }

        [CategoryAttribute("兴趣爱好"), DescriptionAttribute("最喜欢的颜色")]
        public Color FavColor
        {
            get
            {
                return favColor;
            }
            set
            {
                favColor = value;
            }
        }

        [CategoryAttribute("兴趣爱好"), DescriptionAttribute("最喜欢周几？")]
        public DayOfWeek FavDay
        {
            get
            {
                return favDay;
            }
            set
            {
                favDay = value;
            }
        }

    }


    enum Gender
    {
        [Description("男")]
        male =1,
        
        [Description("女")]
        female =2,
    }


}
