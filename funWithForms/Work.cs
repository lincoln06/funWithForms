using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funWithForms
{
    class Work:Human
    {
        public string Gender { get; set; }
        public int Education { get; set; }
        public int Age { get; set; }
        public Work(string firstName, string lastName, List<string> listOfErrors, int age, string gender, int education)
        :base(firstName, lastName, listOfErrors)
        {
            Gender = gender;
            Education = education;
            Age = age;
        }
        public Work Check(string firstName, string lastName, int age, string gender, int education, List<string> listOfErrors)
        {
            base.Check(firstName, lastName, listOfErrors);
            if (!ValidateValues.CheckAge(age, 18, 65)) listOfErrors.Add(Fails[3] + " 18 a 65.");
            if (education < 3) listOfErrors.Add(Fails[5]);
            return new Work(firstName, lastName, listOfErrors, age, gender, education);
        }
        
    }
}
