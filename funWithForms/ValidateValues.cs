using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Text.RegularExpressions;
namespace funWithForms
{
    class ValidateValues
    {
        public static bool CheckName(string name, int minimumLength)
        {
            foreach(char sign in name)
            {
                if (!Char.IsLetter(sign)) return false;
            }
            if (name.Length < minimumLength || name[0] != Char.ToUpper(name[0])) return false;
            return true;
        }
        public static bool CheckPesel(string pesel)
        {
            if (pesel.Length != 11) return false;
            foreach(char sign in pesel)
            {
                if (!Char.IsDigit(sign)) return false;
            }
            return true;
        }
        public static bool CheckAge(int age,int minAge, int maxAge)
        {
            if (age < minAge || age > maxAge) return false;
            return true;
        }
        public static bool CheckEmail(string email)
        {

            return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
        }
        public static string IsCorrect(List<string> listOfErrors)
        {
            if (listOfErrors.Count == 0) return "Formularz jest dobrze wypełniony";
            return "Formularz zawiera błędy";
        }
        public static string GetGender()
        {
            string gender = "x";
            while (gender[0] != 'M' && gender[0] != 'm' && gender[0] != 'K' && gender[0] != 'k')
            {
                Console.WriteLine("Podaj płeć\nM\tMężczyzna\nK\tKobieta");
                gender = Console.ReadLine();
            }
            if (gender[0] == 'M' || gender[0] == 'm') return "Mężczyzna";
            return "Kobieta";
        }
        public static int GetEducation()
        {
            int choose = 0;
            while(choose<1||choose>4)
            { 
                Console.WriteLine("Podaj wykształcenie");
                Console.WriteLine("1 - Podstawowe");
                Console.WriteLine("2 - Zawodowe");
                Console.WriteLine("3 - Średnie");
                Console.WriteLine("4 - Wyższe");
                choose = int.Parse(Console.ReadLine());
            }
            return choose;
        }
    }
}