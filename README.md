# learning_CSharp
C# 从入门到精通

开发环境：VS2017 


##lesson1_FirstProgram

本节实现一个Windows 控制台程序Hello Word！
有以下几个注意点：
,,,
namespace ConsoleApplication2		//需要一个命名空间来装我们所有的代码
{
    class Program					//建立一个类
    {
        static void Main(string[] args)		//标准写法，函数的入口地址，和C语言类似，注意Main中的M要大写，c#是严格区分大小写的
        {
            Console.WriteLine("Hello");   	//我们在程序开始处 using System; 了 否则要写为System.Console.WriteLine("Hello");      
        }
    }
}
,,,						

#lesson2_WinForm

本节我们实现一个Windows窗体应用程序

C#程序设计的核心是：属性、方法和事件。我们在编程的时候时刻要关注在什么事件下用什么属性或者方法实现了什么功能。
					一个C#程序在运行时是基于事件驱动的。

					









