using System;

namespace Nasledovanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat Billy = new Cat(true, "Billy"); // В соответствии с конструктором инициализируем поля класса,
            // после чего просто выводим их :)
            Console.WriteLine(Billy.name);
            Console.WriteLine(Billy.isHungry);
        }
    }

    class Animal
    {
        public string name { get; set; } // Здесь мы определеям поле с именем котика.
        public bool isHungry { get; set; } // А тут создаём поле, которое говорит нам о том, голоден котик или нет.

        public Animal(string name, bool isHungry) // Тут мы просто ссылаемся на поля.
        {
            this.name = name;
            this.isHungry = isHungry;
        }

    }
    class Cat : Animal // Класс Cat наследует все поля родительского (в данном случае обобщающего) класса.
        // Т.е в классе Cat мы можем использовать поле name.
    {
        public Cat(bool isHungry, string name) : base(name, isHungry) // base - это родительский класс, то есть 
            // класс Cat в данном случае наследует isHungry и name из родительского класса, а не из пустоты, 
            // соответственно, эти поля не будут пустыми. Однако, имя мы задаём
            // в методе Main в круглых скобках, когда вызываем класс.
        {
            this.name = name;
            isHungry = true;
        }
    }
}
