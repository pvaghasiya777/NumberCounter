namespace NumberCounter
{

    class Programm
    {
        static void Main(string[] args)
        {
            MySingleton mysingleton = MySingleton.GetInstance();
            mysingleton.DoSomething("Console Message From Void Main");
            mysingleton.Increment();
            mysingleton.Increment();
            mysingleton.Increment();
           // mysingleton.GetCounterNumber();
            Console.WriteLine("Hello");
        }
    }

    public class MySingleton
    {
        private static MySingleton instance = new MySingleton();
        private int count;

        // Private constructor to prevent direct instantiation
        private MySingleton()
        {
            // Initialization code, if any
        }

        public static MySingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new MySingleton();
            }
            return instance;
        }

        private void GetCounterNumber()
        {
            count = 0;  
            Console.WriteLine(count.ToString());
        }
        public void Increment()
        {
            count++;
        }
        public void Decrement()
        {
            count--;
        }
        public void DoSomething(string msg)
        {
            Console.WriteLine(msg);
            Console.ReadLine();
        }
    }
}