using System;
using System.Collections.Generic;

namespace funWithForms
{
    public class School:Human
    {
        public string Pesel { get; set; }
        public School(string firstName, string lastName, List<string> listOfErrors, string pesel)
            :base(firstName, lastName, listOfErrors)
        {
            Pesel = pesel;
        }
        public School Check(string firstName, string lastName, List<string> listOfErrors,string pesel)
        {
            base.Check(firstName, lastName, listOfErrors);
            if (!ValidateValues.CheckPesel(pesel)) listOfErrors.Add(Fails[2]);
            return new School(firstName, lastName, listOfErrors, pesel);
        }
    }
}
