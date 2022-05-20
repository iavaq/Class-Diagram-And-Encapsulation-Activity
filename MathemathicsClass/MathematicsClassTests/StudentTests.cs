using FluentAssertions;
using MathemathicsClass;

namespace MathematicsClassTests
{
    public class StudentTests
    {
        [Test]
        public void Should_Throw_Exception_If_Name_Is_Null()
        {
            void CheckConstructor()
            {
                Student student = new Student(" ", "B", "3");
            }

            Assert.Throws(typeof(ArgumentNullException), CheckConstructor);
        }

        [Test]
        public void Should_Throw_Exception_If_Grade_Is_OutofRange()
        {
            void CheckConstructor()
            {
                Student student = new Student("Lastname, Firstname", "G", "3");
            }
            Assert.Throws(typeof(ArgumentOutOfRangeException), CheckConstructor);
        }
        
        [Test]
        public void Should_Throw_Exception_If_Group_Is_OutofRange()
        {
            void CheckConstructor()
            {
                Student student = new Student("Lastname, Firstname", "B", "8");
            }

            Assert.Throws(typeof(ArgumentOutOfRangeException), CheckConstructor);
        }
        
        [Test]
        public void Should_Upgrade_Grade_To_A()
        {
            Student student = new Student("Lastname, Fistname", "B", "3");

            student.Upgrade();
            student.Grade.Should().Be(StudentTable.Grades.A);
        }

        [Test]
        public void Should_Downgrade_Grade_To_C()
        {
            Student student = new Student("Lastname, Firstname", "B", "3");

            student.Downgrade();
            student.Grade.Should().Be(StudentTable.Grades.C);
        }

        [Test]
        public void Should_Keep_Grade_As_F()
        {
            Student student = new Student("Lastname, Firstname", "F", "3");

            student.Downgrade();
            student.Grade.Should().Be(StudentTable.Grades.F);
        }

        [Test]
        public void Should_Keep_Grade_As_A()
        {
            Student student = new Student("Lastname, Firstname", "A", "3");

            student.Upgrade();
            student.Grade.Should().Be(StudentTable.Grades.A);
        }
    }
}