using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using Laba_7.Models;
using System.Linq;
using System.IO;

namespace Lab_12
{
    public static class Reflector
    {
        public static void First(string t) 
        {
            string writePath = @"D:\OOP\Lab_12\File.txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine("");
                }

                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine("Сборка");
                    Console.WriteLine("Сборка");
                    var assemdl = Type.GetType(t);
                    sw.WriteLine(assemdl.Assembly.FullName);
                    Console.WriteLine(assemdl.Assembly.FullName);
                    sw.WriteLine();
                    Console.WriteLine();

                    sw.WriteLine("Имеются ли публичные конструкторы");
                    Console.WriteLine("Имеются ли публичные конструкторы");
                    ConstructorInfo[] p = assemdl.GetConstructors();
                    for (int i = 0; i < p.Length; i++)
                    {
                        sw.WriteLine(p[i].IsPublic);
                        Console.WriteLine(p[i].IsPublic);
                    }
                    sw.WriteLine();
                    Console.WriteLine();

                    sw.WriteLine("Методы");
                    Console.WriteLine("Методы");
                    var meth = assemdl.GetMethods();
                    for (int i = 0; i < meth.Length; i++)
                    {
                        if (meth[i].IsPublic)
                        {
                            sw.WriteLine(meth[i]);
                            Console.WriteLine(meth[i]);
                        }
                    }
                    sw.WriteLine();
                    Console.WriteLine();

                    sw.WriteLine("Поля");
                    Console.WriteLine("Поля");
                    var fields = assemdl.GetFields();
                    var propert = assemdl.GetProperties();
                    for (int i = 0; i < fields.Length; i++)
                    {
                        sw.WriteLine(fields[i]);
                        Console.WriteLine(fields[i]);
                    }
                    sw.WriteLine();
                    Console.WriteLine();

                    sw.WriteLine("Свойства");
                    Console.WriteLine("Свойства");
                    for (int i = 0; i < propert.Length; i++)
                    {
                        sw.WriteLine(propert[i]);
                        Console.WriteLine(propert[i]);
                    }
                    sw.WriteLine();
                    Console.WriteLine();

                    sw.WriteLine("Интерфейсы");
                    Console.WriteLine("Интерфейсы");
                    var interf = assemdl.GetInterfaces();
                    for (int i = 0; i < interf.Length; i++)
                    {
                        sw.WriteLine(interf[i]);
                        Console.WriteLine(interf[i]);
                    }
                    sw.WriteLine();
                    Console.WriteLine();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void GetNameOfMethods(string ClassName, string TypeOfParams)
        {
            var type = Type.GetType(ClassName);
            var param = Type.GetType(TypeOfParams);

            var request = type.GetMethods().Where(i => i.GetParameters().Any(item => item.ParameterType == param));
            if (request.Count() > 0)
            {
                Console.WriteLine($"All methods");
                foreach (var item in request) Console.WriteLine(item);
            }
            else
            {
                Console.WriteLine("There no any methods");
            }
        }

        public static void Invoke(object Class, string NameOfMethod, string[] Params)
        {
            // получаем метод GetArray
            MethodInfo method = Class.GetType().GetMethod(NameOfMethod);
            // вызываем метод, передаем значения для параметров и получаем
            object result = method.Invoke(Class, Params);
            Console.WriteLine((result));

        }

        public static T Crate<T>(Type myType) where T : class
        {
            ConstructorInfo info = myType.GetConstructors()[0];

            // reflection (создаем объект, вызывая конструктор)
            Object myObj = info.Invoke(null);

            // result
            return (T)myObj;
        }
    }
}
