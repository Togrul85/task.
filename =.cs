using System;

namespace Task7
{
    class Program
    {
        public static int NumberofBullets { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Capacity:");
           int Capacity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" TheNumberOfBullets:");
            int TheNumberOfBullets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("CombDischargeSecond:");
            double CombDischargeSecond= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ShootingMode:");
            string ShootingMode =(Console.ReadLine());

            string value;
          Weapon c=new Weapon(Capacity, TheNumberOfBullets, CombDischargeSecond, ShootingMode);
            do
            {
                Console.WriteLine("\n0. Getting Information\n1.Shoot\n2.Fire\n3.GetRemainBulletCount\n4.Reload\n5.ChangeFireMode");
                value = (Console.ReadLine());
                switch(value)
                {
                    case "0":
                        c.GetType();
                        break;

                    case "1":
                        c.Shoot();
                        break;

                    case "2":
                        c.Fire();
                        break;

                    case "3":
                        c.GetRemainBulletCount();
                        break;

                    case "4":
                        c.Reload();
                        break;

                    case "5":
                        c.ChangeFireMode();
                        break;

                    case "6":
                        continue;
                        break;

                        //case "7":
                        //    Console.WriteLine("Press T Change the capacity\n.Press S Number of bullets\n.Press D Reset second");
                        //    string value2=(Console.ReadLine());




                }
            } while (value!="6");

        }
    }

}


