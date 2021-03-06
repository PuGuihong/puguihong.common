﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using common.main.common_1;
using common.main.common_2;
using common.main.common_3;
using common.main.common_4;
using common.main.common_5;
using common.main.common_7;
using common.main.common_8;
using common.main.common_9;
using common.main.common_10;
using common.main.common_11;
using common.main.common_12;
using common.main.common_13;
using common.main.common_14;
using common.main.common_15;
using common.main.common_16;
using common.main.common_17;

using common.main.update_1;
using System.Collections;

namespace common.main
{
    class Program
    {
        static void Main(string[] args)
        {
            #region common 基础测试入口
            //Common1_test();
            //Common2_test();
            //Common3_test();
            //Common4_test();
            //Common5_test();
            //Common6_test();
            //Common7_test();
            //Common8_test();
            //Common9_test();
            //Common10_test();
            //Common11_test();
            //Common12_test();
            //Common13_test();
            //Common14_test();
            //Common15_test();
            Common16_test();
            //Common17_test();
            #endregion
            #region update 测试入口
            //Update1();
            #endregion
            Console.ReadKey();
        }
        #region common 1-10 基础方法和属性
        /// <summary>
        /// 子类继承
        /// </summary>
        static void Common1_test()
        {
            common_1.Rectangle rec = new common_1.Rectangle();
            rec.SetWidth(52);
            rec.SetHeight(64);

            Console.WriteLine("面积是{0} \n", rec.GetArea());
            Console.WriteLine("周长是{0} \n", rec.GetZhouC());
        }
        /// <summary>
        /// 派生类继承了基类的成员变量和成员方法。
        /// 因此父类对象应在子类对象创建之前被创建。
        /// 您可以在成员初始化列表中进行父类的初始化。
        /// </summary>
        static void Common2_test()
        {
            common_2.TableTop tbt = new TableTop(4.5,7.88);
            tbt.Display();            
        }
        /// <summary>
        /// 使用接口来实现多重继承。
        /// </summary>
        static void Common3_test()
        {
            common_3.Rectangle rec = new common_3.Rectangle();
            int area;
            rec.SetWidth(7);
            rec.SetHeight(9);
            area = rec.GetArea();
            Console.WriteLine("总面积:{0} \n", area);
            Console.WriteLine("总成本: ${0}",rec.getCost(area));
        }
        ///多态性意味着有多重形式。在面向对象编程范式中，多态性往往表现为"一个接口，多个功能"。
        ///多态性可以是静态的或动态的。在静态多态性中，函数的响应是在编译时发生的。在动态多态性中，函数的响应是在运行时发生的。
        static void Common4_test()
        {
            common_4.PrintData printdat = new common_4.PrintData();
            printdat.Print(11);
            printdat.Print(22.22);
            printdat.Print(33, 33);
        }

        static void Common5_test()
        {
            common_5.Rectangle rec = new common_5.Rectangle(6,9);
            int r = rec.GetArea();
            Console.WriteLine("面积: {0}", r);
        }
        /// <summary>
        /// 动态多态性
        /// </summary>
        static void Common6_test()
        {
            common_6.ClassCaller caller = new common_6.ClassCaller();
            common_6.Rectangle rec = new common_6.Rectangle(20,17);
            common_6.Triangle trian = new common_6.Triangle(12, 18);
            caller.CallArea(rec);
            caller.CallArea(trian);
        }
        /// <summary>
        /// 运算符重载 operator + - == ++ * / 
        /// </summary>
        static void Common7_test()
        {
            common_7.Box box1 = new common_7.Box();
            common_7.Box box2 = new common_7.Box();
            common_7.Box box3 = new common_7.Box();
            common_7.Box box4 = new common_7.Box();
            ///体积
            double volume = 0.0;

            //box1 设置
            box1.SetLength(12.0);
            box1.SetWidth(13.1);
            box1.SetBreadth(14.2);

            //box2 设置
            box2.SetLength(17.2);
            box2.SetWidth(13.1);
            box2.SetBreadth(11.4);

            //box1 的体积
            volume = box1.GetVolume();
            Console.WriteLine("box1 的体积：{0}", volume);

            //box2 的体积
            volume = box2.GetVolume();
            Console.WriteLine("box2 的体积：{0}", volume);

            //把两个对象相加
            box3 = box1 + box2;

            //box3的体积
            volume = box3.GetVolume();
            Console.WriteLine("box3 的体积：{0}", volume);
        }
        /// <summary>
        /// C# 接口
        /// </summary>
        static void Common8_test()
        {
            common_8.Transaction tr1 = new common_8.Transaction("001","2014/12/24",89012.11);
            common_8.Transaction tr2 = new common_8.Transaction("002", "2014/12/26", 218871.91);
            tr1.ShowTransactions();
            tr2.ShowTransactions();
        }
        /// <summary>
        /// #define  预处理器
        /// </summary>
        static void Common9_test()
        {
            common_9.BaseClass basc = new common_9.BaseClass();
            basc.CallDefine();
        }
        /// <summary>
        /// 正则表达式 匹配
        /// </summary>
        static void Common10_test()
        {
            string str = "Hello   World   ,   A   Thousand Splendid Suns .make maze and manage to measure it";
            string expre = "";
            common_10.MyRegex myregex = new common_10.MyRegex();

            Console.WriteLine("被比较的字串是：{0} ：\n",str);
            //匹配 以S为开头的单词
            expre = @"\bS\S*";
            Console.WriteLine("匹配 以S为开头的单词: \n");
            myregex.ShowMatch(str, expre);

            //匹配以m开头e结尾的单词
            expre = @"\bm\S*e\b";
            Console.WriteLine("匹配以m开头e结尾的单词: \n");
            myregex.ShowMatch(str, expre);
            
            //替换掉多余的空格
            string pattern = "\\s+";
            string replacement = " ";
            expre = myregex.ReplaceMatch(str, pattern, replacement);
            Console.WriteLine("替换结果是: {0}\n", expre);
        }
        #endregion
        #region common 11-16 高级方法和属性
        /// <summary>
        /// 异常捕获
        /// 自定义异常
        /// </summary>
        static void Common11_test()
        {
            ///系统捕获的异常
            common_11.MyException myex = new common_11.MyException();
            myex.Divisition(3.0, 0.0);

            ///自定义的异常捕获
            myex.Divisition(3, 0);
        }
        /// <summary>
        /// IO流操作
        /// 
        /// byte 字节的读写
        /// stream 文本流的读取和写入
        /// binary stream 二进制文件的读取和写入
        /// </summary>
        static void Common12_test()
        {
            //查看文件目录和目录下的文件信息
            common_12.MyDirectoryHelper mydirectoryhelper = new common_12.MyDirectoryHelper();
            mydirectoryhelper.GetDirectory();

            //字节流的读写
            common_12.MyFileHelper filehelper = new common_12.MyFileHelper();
            filehelper.ByteFileReader();

            //文本流的读取
            filehelper.TextFileReader();

            //文本流方式写入并读取打印
            filehelper.WriteStream();

            //读写二进制数据
            common_12.BinaryFileWriter bfw = new common_12.BinaryFileWriter();
            bfw.BinaryFileWR();
        }
        /// <summary>
        /// C# - Attribute高级特性
        /// 
        /// 系统  attribute 使用
        /// 自定义 attribute 使用
        /// </summary>
        static void Common13_test()
        {
            //系统 attribute 应用
            common_13.AttributeHelper attrihelper = new common_13.AttributeHelper();
            attrihelper.ShowMessage("在主函数中首次调用");
            attrihelper.Func1();

            //自定义 attribute 应用
            common_13.MyAttribute myarrtibu = new common_13.MyAttribute(12.1,24.3);
            myarrtibu.Display();
        }
        static void Common14_test()
        {
            ///使用反射（Reflection）可以查看属性（attribute）信息。 
            ///ReflectionHelper 类的属性值
            System.Reflection.MemberInfo meminfo = typeof(common_14.ReflectionHelper);
            object[] attributes = meminfo.GetCustomAttributes(true);
            Console.WriteLine("ReflectionHelper 类的属性 \n");
            for (int i = 0; i < attributes.Length; i++)
            {
                Console.WriteLine("属性值是：{0}\n",attributes[i]);
            }
            ///MyAttribute 类的属性值
            meminfo = typeof(common_13.MyAttribute);
            attributes = meminfo.GetCustomAttributes(true);
            Console.WriteLine("MyAttribute 类的属性 \n");
            for (int i = 0; i < attributes.Length; i++)
            {
                Console.WriteLine("属性值是：{0}\n", attributes[i]);
            }

            common_14.ReflectionMethod rem = new common_14.ReflectionMethod();
            rem.GetCellAttribute();
            //有误
            //rem.GetMethodAttribute();
        }
        /// <summary>
        /// Collection C#集合
        /// 
        /// Arraylist   动态数组
        /// HashTable   哈希表
        /// SortedList  排序列表
        /// Stack   堆栈
        /// </summary>
        static void Common15_test()
        {
            ///动态数组
            common_15.MyArrayList myarrylst = new common_15.MyArrayList();
            myarrylst.Add();
            myarrylst.SortArray();
            ///哈希表
            common_15.MyHashTable myhashtable = new common_15.MyHashTable();
            myhashtable.ContainsValues("ss");
            myhashtable.ShowHashTable();
            ///排序列表
            common_15.MySortedList mysortlst = new common_15.MySortedList();
            mysortlst.ShowSortedLst();
            ///堆栈
            common_15.MyStack mystack = new common_15.MyStack();
            mystack.ShowStac();
            ///队列
            common_15.MyQueue myqueue = new common_15.MyQueue();
            myqueue.ShowQueue();
            //点阵列
            common_15.MyBitArray mybitarray = new common_15.MyBitArray();
            mybitarray.ShowBitArray();
        }
        static void Common16_test()
        {
            common_16.MyThread mythread = new common_16.MyThread();
            //获取当前主进程名称
            //mythread.ThreadTest();
            //创建子进程，并且在子进程中执行方法。
            //mythread.ThreadCreated();
            for (int i = 0; i < 100; i++)
            {
                mythread.ThreadSleep();
                Console.WriteLine("执行第 {0} 次 \n",i);
            }
        }
        #endregion
        /// <summary>
        /// 枚举类型
        /// </summary>
        static void Common17_test()
        {
            common_17.MyEnum myenum = new common_17.MyEnum();
        }
        #region update 高级方法和属性
        static void Update1()
        {
            string[] strshap = new string[] { "Rectangle", "Square" };
            List<update_1.MessageModel> msglst = new List<MessageModel>();
            update_1.InitC initrcshap;
            for (int i = 0; i < strshap.Count(); i++)
            {
                initrcshap = new InitC(strshap[i]);
                msglst.Add(initrcshap.GetStart());
            }

            for (int i = 0; i < msglst.Count(); i++)
            {
                Console.WriteLine(msglst[i].ShapName);
                foreach (BasicMessage message in msglst[i].BMsgLst)
                {
                    Console.WriteLine(message.HandleName);
                    Console.WriteLine(message.Result);
                    Console.WriteLine(message.Description);
                    Console.WriteLine(message.Formula);
                }
            }
        }
        #endregion
    }
}
