using System;
using System.Collections.Generic;
using System.Text;

namespace SourceControlGit
{
    class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Grade { get; set; }

        public User(string name, string surname, string grade)
        {
            this.Name = name;
            this.Surname = surname;
            this.Grade = grade;
        }

        public void GetDetails()
        {
            Console.WriteLine("Name and Surname: {0} {1}, Grade: {2}", Name, Surname, Grade);
        }

        public void ChangeGrade(string grade)
        {
            this.Grade = grade;
        }
    }
}
