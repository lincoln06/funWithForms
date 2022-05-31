using System;
using System.Collections.Generic;

namespace funWithForms
{
    class SocialMedia:Human
    {
        public int Age { get; set; }
        public string Email { get; set; }
        public SocialMedia(string firstName, string lastName, List<string> listOfErrors, int age, string email)
        :base(firstName,lastName, listOfErrors)
        {
            Age = age;
            Email = email;
        }
        public SocialMedia Check(string firstName, string lastName, int age, string email, List<string> listOfErrors)
        {
            base.Check(firstName, lastName, listOfErrors);
            if (!ValidateValues.CheckAge(age, 13, 100)) listOfErrors.Add(Fails[3] + " 13 a 100.");
            if (!ValidateValues.CheckEmail(email)) listOfErrors.Add(Fails[4]);
            return new SocialMedia(firstName, lastName, listOfErrors, age, email);
        }
    }
}
