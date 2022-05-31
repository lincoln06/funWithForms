using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funWithForms
{
    public abstract class ErrorList
    {
        public string[] fails =
        {
            "Imię powinno zaczynać się wielką literą, składać się tylko z liter i zawierać min. 5 znaków",
            "Nazwisko powinno zaczynać się wielką literą, składać się tylko z liter i zawierać min. 7 znaków",
            "Numer PESEL powinien składać się z 11 cyfr",
            "Wiek powinien zawierać się w przedziale ",
            "Nieprawidłowy format adresu e-mail",
        };
    }
}
