using System;
using System.Collections.Generic;

namespace funWithForms
{
    public abstract class Human
    {
        public bool IsCorrect;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> ListOfErrors { get; set; }
        
        public string[] Fails =
        {
            "Imię powinno zaczynać się wielką literą, składać się tylko z liter i zawierać min. 5 znaków",
            "Nazwisko powinno zaczynać się wielką literą, składać się tylko z liter i zawierać min. 7 znaków",
            "Numer PESEL powinien składać się z 11 cyfr",
            "Wiek powinien zawierać się w przedziale ",
            "Nieprawidłowy format adresu e-mail",
            "Wymagane wykształcenie to średnie lub wyższe"
        };
        public string[] Schools =
        {
            "Podstawowe",
            "Zawodowe",
            "Średnie",
            "Wyższe"
        };
        public Human(string firstName, string lastName, List<string> listOfErrors)
        {
            FirstName = firstName;
            LastName = lastName;
            ListOfErrors = listOfErrors;
        }
        public virtual void Check(string firstName, string lastName, List<string> listOfErrors)
        {
            if (!ValidateValues.CheckName(firstName, 5)) listOfErrors.Add(Fails[0]);
            if (!ValidateValues.CheckName(lastName, 7)) listOfErrors.Add(Fails[1]);
        }
}
}
