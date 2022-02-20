using System;
namespace Any
{
    interface Calc1
    {
        int add(int a, int b);
    }
    interface Cla2
    {
        int sub(int a, int b);
    }
    interface Cal3
    {
        int mul(int a, int b);
    }
    class Member : Calc1, Cla2, Cal3
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public int sub(int a, int b)
        {
            return a - b;
        }
        public int mul(int a, int b)
        {
            return a * b;
        }
        static void Main()
        {
            Member m = new Member();
            m.add(1, 2);
            m.sub(4, 2);
            m.mul(4, 7);
            Console.WriteLine("Add is :" + m.add(1, 2));
            Console.WriteLine("sub is :" + m.sub(4, 2));
            Console.WriteLine("mul is :" + m.mul(4, 7));
            Console.ReadLine();

        }
    }

}