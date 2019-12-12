using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaModululTrei
{
    class Program
    {
        public enum Gender
        {
            Male,
            Female
        }
        static void Main(string[] args)
        {
            string Dob;
            Console.WriteLine("Enter date of Birth in format DD/MM/YYYY: ");
            Dob = Console.ReadLine();
            DateTime birthDate = DateTime.Parse(Dob);
            DateTime todayDate = DateTime.Today;
            int age = todayDate.Year - birthDate.Year;
            if (birthDate > todayDate.AddYears(-age))
            {
                age--;
            }
            
            
            string input = Console.ReadLine();
            Nullable<char> c =null;
            Gender MaleGender = Gender.Male;
            Gender FemaleGender = Gender.Female;
            if (c.HasValue) 
            {
                c = char.Parse(input);
                if (c == 'M'|| c == 'F')
                {
                    
                    if (age >= 63 && c=='F')
                    {
                        Console.WriteLine("You are {0},and you are retired"+FemaleGender);
                        if(age>=65 && c == 'M') 
                        {
                            Console.WriteLine("You are {0},and you are retired" + MaleGender);
                            Console.ReadLine();
                        }
                    }
                    else 
                    {
                        Console.WriteLine("You will retire at age 65 if you are {0},and at 63 if you are {2}"+MaleGender+FemaleGender);
                    }
                }else
                {
                    Console.WriteLine("Enter a valid value");

                }
            }

            
            
            

            Console.WriteLine("Varsta dvs este: {0} ", age);
            Console.ReadLine();
            Console.Write("Press any key to finish");
            Console.ReadKey(true);
        }
    }
}