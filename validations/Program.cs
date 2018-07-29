using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace validations
{
    class Program
    {
            static void GetValidName()

            {
                Console.WriteLine("This is my Lab 7");
                const string name = "";



                Console.WriteLine("Please enter a name");

                Regex isName = new Regex(@"^[A-Z]{1}[a-z]{1,29}$");

                Console.ReadLine();



                if (isName.IsMatch(name ?? throw new InvalidOperationException()))

                {



                    Console.WriteLine("That's a name.");



                }



                else

                {



                    Console.WriteLine("That's not a name.");



                }



            }



            static void GetValidEmail()

            {



                Console.WriteLine("Please enter an e-mail: ");

                Regex isAddress = new Regex(@"^\w{5,}@[A-z]{5,}.[A-z]{2,3}$");

                string address = Console.ReadLine();



                if (isAddress.IsMatch(address))

                {



                    Console.WriteLine("That's an e-mail.");



                }



                else

                {



                    Console.WriteLine("That's not an e-mail.");



                }



            }



            static void GetValidPhone()

            {



                Console.WriteLine("Please enter a phone number: ");

                Regex isPhone = new Regex(@"^\d{3}-\d{3}-\d{4}$");

                string phone = Console.ReadLine();



                if (isPhone.IsMatch(phone ?? throw new InvalidOperationException()))

                {



                    Console.WriteLine("That's a phone number.");



                }



                else

                {



                    Console.WriteLine("That's not a phone number.");



                }



            }



            static void GetValidDate()

            {



                Console.WriteLine("Please enter a date");

                Regex isDate = new Regex(@"^[0123][0-9]/[01][0-9]/\d{4}$");

                string date = Console.ReadLine();



                if (isDate.IsMatch(date ?? throw new InvalidOperationException()))

                {



                    Console.WriteLine("That's a date.");



                }



                else

                {



                    Console.WriteLine("That's not a date.");



                }



            }



            static void Main(string[] args)

            {



                GetValidName();

                GetValidEmail();

                GetValidPhone();

                GetValidDate();

                Console.WriteLine("nothing else");

            }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
