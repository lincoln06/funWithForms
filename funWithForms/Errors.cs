using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funWithForms
{
    class Errors
    {
        public string FormName { get; set; }
        public string IsCorrect { get; set; }
        public List<string> ListOfErrors { get; set; }
        public Errors(string formName, string isCorrect, List<string> listOfErrors)
        {
            FormName = formName;
            IsCorrect = isCorrect;
            ListOfErrors = listOfErrors;
        }
        
    }
}
