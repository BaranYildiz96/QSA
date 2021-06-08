using System;

namespace QuizShowApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tüm program döngüye alınacaktır.
            Console.WriteLine("-------->KİM 500.000 TL İSTER YARIŞMASINA HOSGELDINIZ<--------");
            Console.WriteLine("\nLütfen adınız ve şifreniz ile giriş yapınız:");
            signup();
        }

        public static void signup()
        {
            Participant participant = new Participant();
            participant.LoginIn();
           
        }

        public void exit()
        {
            throw new System.NotImplementedException();
        }

        public void returnMainPage()
        {
            throw new System.NotImplementedException();
        }
    }
}
