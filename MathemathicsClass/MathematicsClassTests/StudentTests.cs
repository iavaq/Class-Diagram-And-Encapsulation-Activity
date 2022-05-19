using FluentAssertions;
using MathemathicsClass;

namespace MathematicsClassTests
{
    public class StudentTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string name = "A Student";
            char grade = 'B';
            int group = 3;

            Student aStudent = new Student(name, grade, group);
        }

        [Test]
        public void Test2()
        {
            string name = "A Student";
            char grade = 'B';
            int group = 3;

            Student aStudent = new Student(name, grade, group);

            aStudent.Upgrade();
            aStudent.Grade.Should().Be(StudentTable.Grades.A);
        }

        [Test]
        public void Test3()
        {
            string name = "A Student";
            char grade = 'B';
            int group = 3;

            Student aStudent = new Student(name, grade, group);

            aStudent.Downgrade();
            aStudent.Grade.Should().Be(StudentTable.Grades.C);
        }
    }
}