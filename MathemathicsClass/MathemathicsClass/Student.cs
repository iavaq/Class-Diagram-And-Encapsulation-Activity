using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathemathicsClass
{
    public class Student
    {
        public string Name { get; private set; }
        public StudentTable.Grades Grade { get; private set; }
        private int _group;
        private string _secretNickName = "MySecretNickName";


        public Student(string name, char grade, int group)
        {
            if (!Enum.IsDefined(typeof(StudentTable.Grades), char.ToUpper(grade).ToString()))
            {
                throw new Exception("Invalid grade. Please enter a valid student grade. ");
            }

            if (!StudentTable.Groups.Contains(group))
            {
                throw new Exception("Invalid group. Please enter a valid student group. ");
            }

            Name = name;
            Grade = (StudentTable.Grades)grade;
            _group = group;
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
            
            int newGrade = (int)(StudentTable.Grades)Enum.Parse(typeof(StudentTable.Grades), ((char)Grade).ToString()) + level;
            Grade = (StudentTable.Grades)(newGrade);
        }
    }
}
