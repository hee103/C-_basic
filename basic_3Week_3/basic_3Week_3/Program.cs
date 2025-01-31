namespace basic_3Week_3
{
    internal class Program
    {
        abstract class shape
        {
            public abstract void Draw();
        }

        class circle:shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing a Circle");
            }
        }

        class Square : shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing a Square");
            }
        }

        class Triangle : shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing a Triangle");
            }
        }

        static void Main(string[] args)
        {
            //shape shape = new shape(); ->매서드를 선언만 하고 정의를 하지 않아서 인스턴스화 객체화 할 수 없음
            List<shape> list = new List<shape>();
            list.Add(new circle());
            list.Add(new Square());
            list.Add(new Triangle());

            foreach (shape shape in list)
            {
                shape.Draw();
            }

        }
    }
}
