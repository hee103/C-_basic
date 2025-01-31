namespace basic_3week
{
    internal class Program
    {

        //class Person
        //{
        //    //public string Name;
        //    //public int Age;

        //    private string name;
        //    private int age;

        //    // 디폴트 생성자
        //    public Person()
        //    {
        //        name = "Unknown";
        //        age = 0;
        //    }

        //    public Person(string newName, int newAge)
        //    {
        //        name = newName;
        //        age = newAge;
        //        Console.WriteLine("Person 객체 생성");
        //    }

        //    public void PrintInfo()
        //    {
        //        //Console.WriteLine("Name: " + Name);
        //        //Console.WriteLine("Name: " + Age);
        //        Console.WriteLine($"Name: {name}, Age: {age}");
        //    }
        //}


        public class Animal
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public void Eat()
            {
                Console.WriteLine("Animal is eating");
            }
            public void Sleep()
            {
                Console.WriteLine("Animal is sleeping");
            }
        }

        public class Dog:Animal
        {
            public void Bark()
            {

                Console.WriteLine("Dog is bark");
            }
        }

        public class Cat:Animal
        {
            public void Meow()
            {

                Console.WriteLine("Cat is Meow");
            }
            public void Sleep()
            {
                Console.WriteLine("Cat sleep");
            }
        }


        static void Main(string[] args)
        {
            //Person p = new Person();
            //p.Name = "Jhon";
            //p.Age = 30;
            //p.PrintInfo();
            //Person person1 = new Person();
            //Person person2 = new Person("Jhon", 25);
            //person2.PrintInfo();

            Dog dog = new Dog();
            dog.Name = "Bobby";
            dog.Age = 3;

            dog.Eat();
            dog.Sleep();
            dog.Bark();

            Cat cat = new Cat();
            cat.Name = "Kkami";
            cat.Age = 10;

            cat.Eat();
            cat.Sleep();
            cat.Meow();
        }
    }
}
