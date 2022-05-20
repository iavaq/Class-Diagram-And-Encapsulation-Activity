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
        private StudentTable.Groups _group;
        private string _secretNickName = "MySecretNickName";
        

        public Student(string name, string grade, string group)
        {
            //Object[] inputs = new Object[] { name, grade, group };
            //nullChecker(inputs);

            if (!Enum.IsDefined(typeof(StudentTable.Grades), grade.ToUpper()))
            {
                throw new ArgumentOutOfRangeException("Invalid grade. Please enter a valid student grade. ");
            }

            if (!Enum.IsDefined(typeof(StudentTable.Groups),Int32.Parse(group)))
            {
                throw new ArgumentOutOfRangeException("Invalid group. Please enter a valid student group. ");
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
            int newGrade = (int)(StudentTable.Grades)Enum.Parse(typeof(StudentTable.Grades), Grade.ToString()) + level;
            Grade = (StudentTable.Grades)(newGrade);
            
        }

        /*
        private void nullChecker(Object[] inputs)
        {
            foreach (Object[] input in inputs)
            {
                //ArgumentNullException.ThrowIfNull(input.);
            }
        }*/
    }
}
