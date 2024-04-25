using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog122_S24_L7_ListBox
{
    public class Person
    {
        string _firstName;
        string _lastName;
        List<string> _personaList;

        public Person(string firstName, string lastName, List<string> personaList)
        {
            _firstName = firstName;
            _lastName = lastName;
            _personaList = personaList;
        }

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public List<string> PersonaList { get => _personaList; set => _personaList = value; }

        public override string ToString()
        {
            return $"{_firstName} {_lastName}";
        }
    } // class

} // namespace
