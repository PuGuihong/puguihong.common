using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
using System.Reflection;


namespace common.main
{
    class Program
    {
        static void Main(string[] args)
        {
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
            Console.ReadKey();
        }
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
    }
}
