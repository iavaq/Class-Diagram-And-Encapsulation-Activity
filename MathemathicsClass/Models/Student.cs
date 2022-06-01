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
            if (IsStringNull(name))
            {
                throw new ArgumentNullException();
            }

            if (!CheckGradeRange(grade))
            {
                throw new ArgumentOutOfRangeException();
            }

            if (!CheckGroupRange(group))
            {
                throw new ArgumentOutOfRangeException();
            }

            Name = name;
            Grade = (StudentTable.Grades)Enum.Parse(typeof(StudentTable.Grades), grade);
            _group = (StudentTable.Groups)Enum.Parse(typeof(StudentTable.Grades), group);
        }

        public void Upgrade()
        {
            UpdateGrade(1);
        }

        public void Downgrade()
        {
            UpdateGrade(-1);
        }

        public Student GetStudentInfo()
        {
            return this;
        }
        private void UpdateGrade(int level)
        {
            int newLevel = (int)(StudentTable.Grades)Enum.Parse(typeof(StudentTable.Grades), Grade.ToString()) + level;

            if (CheckGradeRange(((StudentTable.Grades)newLevel).ToString()))
            {
                Grade = (StudentTable.Grades)newLevel;
            }
            else
            {
                Console.WriteLine("New grade is out of range. Enter valid grade.");
            }
        }

        private bool IsStringNull(string input)
        {
            return string.IsNullOrEmpty(input.Trim());

        }
        private bool CheckGradeRange(string grade)
        {
            return Enum.IsDefined(typeof(StudentTable.Grades), grade.ToUpper());

        }
        private bool CheckGroupRange(string group)
        {
            return Enum.IsDefined(typeof(StudentTable.Groups), int.Parse(group));

        }
    }
}
