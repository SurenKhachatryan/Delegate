using System;

namespace Delegate
{
    //Делегат хранит в себе указатели на методы или ссылки на методы других Объект․
    //Также Делегат может хранит в себе указатели на методы или ссылки на методы не 
    //принадлежащий не какова объекта , так называемы анонимные методы․


    //Создаем Класс Делегат MyDelegate
    public delegate int MyDelegate(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            //локальные переменные
            int a = 5;
            int b = 6;

            //Делегаты могут в себе содержать ссылки или указатели на статические методы․
            MyDelegate delegate1 = new MyDelegate(MyStaticClass.StaticMethod);

            Console.WriteLine("Выводы статического метода");
            Console.WriteLine(delegate1(a, b));        //Первый вариант вызова статического метода․
            Console.WriteLine(delegate1.Invoke(a, b)); //Второй вариант вызова статического метода․

            //------------------------------------------------------------------------------------
            Console.WriteLine($"{new string('=', 10)} Класс");
            //---------------------------------Класс----------------------------------------------

            //Создаем Объект Класса MyClass․
            MyClass my = new MyClass();

            //Делегаты могут в себе содержать ссылки или указатели на простые методы Класса․
            MyDelegate delegate2 = new MyDelegate(my.Method);

            Console.WriteLine(delegate2(a, b));             //Первый вариант вызова метода․
            Console.WriteLine(delegate2.Invoke(a, b));      //Второй вариант вызова метода․

            //------------------------------------------------------------------------------------
            Console.WriteLine($"{new string('=', 10)} Структура");
            //--------------------------------Структура-------------------------------------------

            //Создаем Экземпляр Структуры
            MyStruct mystruct;
            //Делегаты могут в себе содержать ссылки или указатели на простые методы Структур․
            MyDelegate delegate3 = new MyDelegate(mystruct.Method);


            Console.WriteLine(delegate3(a, b));             //Первый вариант вызова метода․
            Console.WriteLine(delegate3.Invoke(a, b));      //Второй вариант вызова метода․

            //------------------------------------------------------------------------------------
            Console.WriteLine($"{new string('=', 10)} Лябда =>");
            //--------------------------------|Лябда =>|------------------------------------------
            MyDelegate delegate4 = delegate (int x, int y) { return x + y; }; //Лямбада метод․

            //Анонимные методы с Лямбда оператором варианты
            MyDelegate delegate5 = (int x, int y) => { return x + y; };

            MyDelegate delegate6 = (x, y) => { return x + y; };

            MyDelegate delegate7 = (x, y) => x + y;


            Console.WriteLine(delegate4(a, b));            //Первый вариант вызова метода․
            Console.WriteLine(delegate4.Invoke(a, b));     //Второй вариант вызова метода․

            Console.WriteLine(delegate4(a, b));            //Первый вариант вызова метода․
            Console.WriteLine(delegate4.Invoke(a, b));     //Второй вариант вызова метода․

            Console.WriteLine(delegate4(a, b));            //Первый вариант вызова метода․
            Console.WriteLine(delegate4.Invoke(a, b));     //Второй вариант вызова метода․

            Console.WriteLine(delegate4(a, b));            //Первый вариант вызова метода․
            Console.WriteLine(delegate4.Invoke(a, b));     //Второй вариант вызова метода․

            Console.ReadKey();
        }
    }

    struct MyStruct
    {
        public int Method(int a, int b)
        {
            return a * b;
        }
    }

    class MyClass
    {
        public int Method(int a, int b)
        {
            return a * b;
        }
    }

    static class MyStaticClass
    {
        public static int StaticMethod(int a, int b)
        {
            return a * b;
        }
    }
}
