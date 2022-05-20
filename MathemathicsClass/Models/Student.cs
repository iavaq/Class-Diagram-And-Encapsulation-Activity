using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathemathicsClass.Models
{
    public class Student
    {
        public string Name { get; private set; }
        public StudentTable.Grades Grade { get; private set; }
        private StudentTable.Groups _group;
        private string _secretNickName = "MySecretNickName";

        public Student(string name, string grade, string group)
        {
            if (nullChecker(name))
            {
                throw new ArgumentNullException();
            }

            if (!checkGradeRange(grade))
            {
                throw new ArgumentOutOfRangeException();
            }

            if (!checkGroupRange(group))
            {
                throw new ArgumentOutOfRangeException();
            }

            Name = name;
            Grade = (StudentTable.Grades)Enum.Parse(typeof(StudentTable.Grades), grade);
            _group = (StudentTable.Groups)Enum.Parse(typeof(StudentTable.Grades), group);
        }

        public void Upgrade()
        {
            updateGrade(1);
        }

        public void Downgrade()
        {
            updateGrade(-1);
        }

        private void updateGrade(int level)
        {
            int newLevel = (int)(StudentTable.Grades)Enum.Parse(typeof(StudentTable.Grades), Grade.ToString()) + level;

            if (checkGradeRange(((StudentTable.Grades)newLevel).ToString()))
            {
                Grade = (StudentTable.Grades)newLevel;
            }
            else
            {
                Console.WriteLine("New grade is out of range. Enter valid grade.");
            }
        }

        private bool nullChecker(string input)
        {
            return string.IsNullOrEmpty(input.Trim());

        }
        private bool checkGradeRange(string grade)
        {
            return Enum.IsDefined(typeof(StudentTable.Grades), grade.ToUpper());

        }
        private bool checkGroupRange(string group)
        {
            return Enum.IsDefined(typeof(StudentTable.Groups), int.Parse(group));

        }
    }
}
