using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Part1
{
    class Pet
    {
        private string name;// name of the pet
        private int age;
        private bool isFemale;// true if female, false if male

        public void Start()
        {
            Console.WriteLine();
            Console.WriteLine("*******************************************");
            Console.WriteLine("Greeting from the Pet Owner application!");
            Console.WriteLine("******************************************");
            Console.WriteLine();

            ReadAndSavePetData();
            DisplayPetInfo();
        }
        public void ReadAndSavePetData()
        {
            ReadName();
            ReadAge();
            ReadGender();
        




        }
        public void ReadName()
        {
            // Read a line of text
            Console.Write("What is the name of your Pet?");
            name = Console.ReadLine();
            Console.WriteLine();
        }
        public void ReadAge()
        {
            // Read a whole number;
            Console.Write("How old is " + name + "?");
            string textValue = Console.ReadLine();
            age = int.Parse(textValue);
            Console.WriteLine();
        }
        public void ReadGender()
        {
            // Read a logical value (y/n)
            Console.Write("Is your pet a female(y/n)?");
            string strGender = Console.ReadLine();
            strGender = strGender.Trim();// deleted leading and trailing spaces
            char response = strGender[0];
            if ((response == 'y') || (response == 'Y'))
                isFemale = true;
            else
                isFemale = false;
            Console.WriteLine();

        }
        public void DisplayPetInfo()
        {
            
            Console.WriteLine("++++++++++++++++++++++++");
            string textOut = "Pet name: " + name + "\n"
                            + "Pet age: " + age;
            
            Console.WriteLine(textOut);
            if (isFemale)
                Console.WriteLine(name + "is a good girl");
            else
                Console.WriteLine(name + "is a good boy");

            Console.WriteLine("++++++++++++++++++++++++");
            Console.WriteLine();

        }
    }
}
