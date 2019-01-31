using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace star
{
    class Program
    {
        static void Main(string[] args)
        {
            String firstname;
            String surname;
            String mothername;
            String Town;
            String SWfirstname;
            String SWsurname;
            String Sideofforce;
            String Good;
            String Bad;
            Console.WriteLine("What is your first name");
            firstname = Console.ReadLine();
            Console.WriteLine("What is your surname");
            surname = Console.ReadLine();
            Console.WriteLine("What is Your mothers first name");
            mothername = Console.ReadLine();
            Console.WriteLine("What is the name of your town");
            Town = Console.ReadLine();
            Console.WriteLine();
            
            SWfirstname = surname.Substring(0, 3) + firstname.Substring(0, 2);
            Console.WriteLine("Your Star Wars first name is " + SWfirstname);

            
            SWsurname = mothername.Substring(0, 2) + Town.Substring(0, 3);
            Console.WriteLine("Your star wars surname is " + SWsurname);

            Console.WriteLine("Your Full Star wars name is: " + SWfirstname +" "+ SWsurname);
            Console.ReadLine();
            Console.WriteLine("Which side of the force are you on Good/Bad ? ");
            Sideofforce = Console.ReadLine();
            
            
            if (Sideofforce == "Bad")
            {
                Console.WriteLine("Your Full Star wars name is:" + " Darth" + SWfirstname + " " + SWsurname);
            }
            else
            {
                Console.WriteLine("Your Full Star wars name is:" + SWfirstname + " " + SWsurname + " Jedi Knight");
            }







        }
    }
}
