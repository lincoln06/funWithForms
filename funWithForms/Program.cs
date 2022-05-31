using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace funWithForms
{
    class Program
    {
        public static string[] names =
        {
            "Formularz do szkoły",
            "Formularz do pracy",
            "Formuarz do portalu społecznościowego"
        };
        static void Main()
        {

            int choose = 0;
            while (choose < 1 || choose > 3)
            {
                Console.WriteLine($"1\t{names[0]}\n2\t{names[1]}\n3\t{names[2]}");
                choose = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Podaj imię");
            string firstName = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko");
            string lastName = Console.ReadLine();
            Errors log=new("","",new List<string>());
            switch (choose)
            {
                case 1:
                    log = NewSchoolForm(firstName, lastName);
                    break;
                case 2:
                    log = NewWorkForm(firstName, lastName);
                    break;
                case 3:
                    log = NewSocialMediaForm(firstName, lastName);
                    break;
            }
            Console.WriteLine("Naciśnij dowolny klawisz aby wyświetlić log...\n\n");
            Console.ReadKey();
            ShowLog(log);
            Console.ReadKey();
        }
        static Errors NewSchoolForm(string firstName, string lastName)
        {
            Console.WriteLine("Podaj numer PESEL");
            string pesel = Console.ReadLine();
            School schoolForm = new(firstName, lastName, new List<string>(), pesel);
            schoolForm = schoolForm.Check(firstName, lastName, new List<string>(), pesel);
            return new Errors(names[0], ValidateValues.IsCorrect(schoolForm.ListOfErrors), schoolForm.ListOfErrors);
        }
        static Errors NewWorkForm(string firstName, string lastName)
        {
            Console.WriteLine("Podaj wiek");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj płeć");
            string gender = ValidateValues.GetGender();
            int education = ValidateValues.GetEducation();
            Work workForm = new(firstName, lastName, new List<string>(), age, gender, education);
            workForm = workForm.Check(firstName, lastName, age, gender, education, new List<string>());
            return new Errors(names[1], ValidateValues.IsCorrect(workForm.ListOfErrors), workForm.ListOfErrors);
        }
        static Errors NewSocialMediaForm(string firstName, string lastName)
        {
            Console.WriteLine("Podaj e-mail");
            string email = Console.ReadLine();
            Console.WriteLine("Podaj wiek");
            int age = int.Parse(Console.ReadLine());
            SocialMedia socialMediaForm = new(firstName, lastName, new List<string>(), age, email);
            socialMediaForm = socialMediaForm.Check(firstName, lastName, age, email, new List<string>());
            return new Errors(names[2], ValidateValues.IsCorrect(socialMediaForm.ListOfErrors), socialMediaForm.ListOfErrors);
        }
        static void ShowLog(Errors log)
        {
            Console.WriteLine($"Rodzaj:\t{log.FormName}\n");
            Console.WriteLine(log.IsCorrect);
            if (log.ListOfErrors.Count != 0)
            {
                Console.WriteLine("\nNr\tOpis błędu\n");
                foreach (string error in log.ListOfErrors)
                {
                    Console.WriteLine($"{log.ListOfErrors.IndexOf(error) + 1}\t{error}");
                }
            }
        }
    }
    
}

