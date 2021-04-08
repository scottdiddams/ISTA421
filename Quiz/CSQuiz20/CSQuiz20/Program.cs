using System;

namespace CSQuiz20
{
    class Program
    {
        public delegate void PrintShoot();

        static void Main(string[] args)
        {
            Console.WriteLine("Delegate Quiz 20");
            
            Rifle R = new Rifle();
            Shotgun S = new Shotgun();
            Pistol P = new Pistol();

            //PrintShoot del = new PrintShoot(R.Shoot);
            PrintShoot del = R.Shoot;
            //del += new PrintShoot(S.Shoot);
            del += S.Shoot;
            //del += new PrintShoot(P.Shoot);
            del += P.Shoot;
            del();
            Console.ReadLine();
        }
    }

    class Rifle
    {
        public void Shoot()
        {
            Console.WriteLine("I am a Rifle and I go Bang");
        }
    }
    class Shotgun
    {
        public void Shoot()
        {
            Console.WriteLine("I am a Shotgun and I go Boom");
        }
    }
    class Pistol
    {
        public void Shoot()
        {
            Console.WriteLine("I am a Pistol and I go Pop");
        }
    }
}
