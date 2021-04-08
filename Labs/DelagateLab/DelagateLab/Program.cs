using System;

namespace DelagateLab
{
    class Program
    {
        /*
        //lab01
         static void Main(string[] args)
        {
            Console.WriteLine("Del20200329a");
            //2. instantiate a delegate object
            //either of the two lines below, a or b
            var md = new MyDel(someMethod); //a
            //MyDel md = someMethod; //b
            //3. call the delegate
            md();
        }

        static void someMethod()
        {
            Console.WriteLine("This is the body of the method named \"someMethod()\"");
        }
        */

        /*
        //lab02
        delegate int IntDel(int a, int b);  //create delegate type

        static int Add(int a, int b) => a + b;
        static int Sub(int a, int b) => a - b;
        static int Prod(int a, int b) => a * b;
        static int Mod(int a, int b) => a % b;
        static int Pow(int a, int b) => (int)Math.Pow(a, b);

        private static (int a, int b) GetInput()
        {
            Console.WriteLine("Enter an integer for the left hand side");
            int a, b;
            int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Enter an integer for the right hand side");
            int.TryParse(Console.ReadLine(), out b);
            return (a, b);
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Hello Del20200327c!");
            (int a, int b) = GetInput();

            Console.WriteLine("=======using a method call=========");
            int result = Add(a, b);
            Console.WriteLine(result);
            result = Sub(a, b);
            Console.WriteLine(result);
            result = Prod(a, b);
            Console.WriteLine(result);
            result = Mod(a, b);
            Console.WriteLine(result);
            result = Pow(a, b);
            Console.WriteLine(result);

            Console.WriteLine("=======using a delegate=========");
            IntDel idel = new IntDel(Add);
            Console.WriteLine(idel(a, b));
            idel = Sub;
            Console.WriteLine(idel(a, b));
            idel = Prod;
            Console.WriteLine(idel(a, b));
            idel = Mod;
            Console.WriteLine(idel(a, b));
            idel = Pow;
            Console.WriteLine(idel(a, b));
        }
        */

        //lab03

        public delegate void PrintPresDel(President p);
        public delegate string GetPresDel();

        static void Main(string[] args)
        {
            Console.WriteLine("Delegate Lab 03");
            President first = new President
            {
                FirstName = "George",
                LastName = "Washington",
                State = "Virginia",
                Party = "independent",
                Year = 1788
            };
            Console.WriteLine("========= three different ways =========");
            first.PrintFirstName(first);
            Console.WriteLine(first.GetFirstName());
            Console.WriteLine(first.FirstName);
            Console.WriteLine(first.FirstName.GetType());

            Console.WriteLine("=========non delegate demostration =========");
            Console.WriteLine(first.FirstName);
            Console.WriteLine(first.LastName);
            Console.WriteLine(first.State);
            Console.WriteLine(first.Party);
            Console.WriteLine(first.Year);
            Console.WriteLine(first.ToString());

            Console.WriteLine("=========first delegate demostration =========");
            GetPresDel myFirstDel = new GetPresDel(first.GetFirstName);
            Console.WriteLine(myFirstDel());
            myFirstDel = first.GetLastName;
            Console.WriteLine(myFirstDel());
            myFirstDel = first.GetState;
            Console.WriteLine(myFirstDel());
            myFirstDel = first.GetParty;
            Console.WriteLine(myFirstDel());
            myFirstDel = first.GetYear;
            Console.WriteLine(myFirstDel());
            myFirstDel = first.ToString;
            Console.WriteLine(myFirstDel());

            Console.WriteLine("=========second delegate demostration =========");
            PrintPresDel mySecondDel = new PrintPresDel(first.PrintFirstName);
            mySecondDel(first);
            mySecondDel = new PrintPresDel(first.PrintLastName);
            mySecondDel(first);
            mySecondDel = new PrintPresDel(first.PrintState);
            mySecondDel(first);
            mySecondDel = new PrintPresDel(first.PrintParty);
            mySecondDel(first);
            mySecondDel = new PrintPresDel(first.PrintYear);
            mySecondDel(first);
            mySecondDel = new PrintPresDel(first.PrintString);
            mySecondDel(first);

            Console.WriteLine("=========third delegate demostration =========");
            PrintPresDel myThirdDel = new PrintPresDel(first.PrintFirstName);
            myThirdDel += new PrintPresDel(first.PrintLastName);
            myThirdDel += new PrintPresDel(first.PrintState);
            myThirdDel += new PrintPresDel(first.PrintParty);
            myThirdDel += new PrintPresDel(first.PrintYear);
            myThirdDel += new PrintPresDel(first.PrintString);
            myThirdDel(first);
        }
    }
    public class President
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string State { get; set; }
        public string Party { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} from {State} was a {Party} elected in {Year}.";
        }

        //Get takes no arguments ahd returns a string
        public string GetFirstName() => FirstName;
        public string GetLastName() => LastName;
        public string GetState() => State;
        public string GetParty() => Party;
        public string GetYear() => Year.ToString();

        //print takes a President argument and returns void
        public void PrintFirstName(President p) => Console.WriteLine(p.FirstName);
        public void PrintLastName(President p) => Console.WriteLine(p.LastName);
        public void PrintState(President p) => Console.WriteLine(p.State);
        public void PrintParty(President p) => Console.WriteLine(p.Party);
        public void PrintYear(President p) => Console.WriteLine(p.Year.ToString());

        public void PrintString(President p) =>
            Console.WriteLine($"{FirstName} {LastName} from {State} was a {Party} elected in {Year}.");
    }
}