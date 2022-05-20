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
            Student aStudent = new Student("A name", "B", "3");
        }

        [Test]
        public void Test2()
        {
            Student aStudent = new Student("A name", "B", "3");

            aStudent.Upgrade();
            aStudent.Grade.Should().Be(StudentTable.Grades.A);
        }

        [Test]
        public void Test3()
        {
            Student aStudent = new Student("A name", "B", "3");

            aStudent.Downgrade();
            aStudent.Grade.Should().Be(StudentTable.Grades.C);
        }
    }
}