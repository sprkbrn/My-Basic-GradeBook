using Xunit;
using GradeBook;
using System.Collections.Generic;

namespace GradeBook_Tests
{
    public class Book_Tests
    {
        [Fact]
        public void DefaultInit_Is_OK()
        {
            Book test_book = new Book();
            Assert.Empty(test_book.GetStudentRoster());
        }

        [Fact]
        public void StudentInit_Is_OK()
        {
            Student test_student = new Student("Michael", "D'Angelo");
            Book test_book = new Book(test_student);
            Assert.Equal("Michael D'Angelo", test_book.GetStudentByFullName("Michael D'Angelo").GetFullName());
        }

        [Fact]
        public void ListInit_Is_OK()
        {
            List<Student> listOfStudents = new List<Student>();
            Student test_student1 = new Student("Peter", "Parker");
            Student test_student2 = new Student("Susan", "Powers");
            Student test_student3 = new Student("Reed", "Richards");

            listOfStudents.Add(test_student1);
            listOfStudents.Add(test_student2);
            listOfStudents.Add(test_student3);

            Book test_book = new Book(listOfStudents);
            Assert.NotEmpty(test_book.GetStudentRoster());
        }

        [Fact]
        public void GetStudentByFullName_Returns_RightStudent()
        {
            List<Student> students = new List<Student>();
            Student test_student1 = new Student("Peter", "Parker");
            Student test_student2 = new Student("Susan", "Powers");
            Student test_student3 = new Student("Reed", "Richards");

            students.Add(test_student1);
            students.Add(test_student2);
            students.Add(test_student3);

            Book test_book = new Book(students);

            Assert.Equal("Susan", test_book.GetStudentByFullName("Susan Powers").GetFirstName());
            Assert.Equal("Richards", test_book.GetStudentByFullName("Reed Richards").GetLastName());
        }

        [Fact]
        public void GetStudentsByFirstName_Returns_RightList()
        {
            List<Student> students = new List<Student>();
            Student test_student1 = new Student("Peter", "Parker");
            Student test_student2 = new Student("Peter", "Rabbit");
            Student test_student3 = new Student("Reed", "Richards");

            students.Add(test_student1);
            students.Add(test_student2);
            students.Add(test_student3);

            Book test_book = new Book(students);

            Assert.Equal(2, test_book.GetStudentsByFirstName("Peter").Count);
        }

        [Fact]
        public void GetStudentsByLastName_Returns_RightList()
        {
            List<Student> students = new List<Student>();
            Student test_student1 = new Student("Austin", "Powers");
            Student test_student2 = new Student("Susan", "Powers");
            Student test_student3 = new Student("Reed", "Richards");

            students.Add(test_student1);
            students.Add(test_student2);
            students.Add(test_student3);

            Book test_book = new Book(students);

            Assert.Single(test_book.GetStudentsByLastName("Richards"));
        }

        [Fact]
        public void GetStudentRosterEmpty_Is_OK()
        {
            Book test_book = new Book();
            Assert.Empty(test_book.GetStudentRoster());
        }

        [Fact]
        public void GetStudentRosterPopulated_Is_OK()
        {
            Book test_book = new Book();
            Student test_student1 = new Student("Austin", "Powers");
            Student test_student2 = new Student("Susan", "Powers");
            Student test_student3 = new Student("Reed", "Richards");

            test_book.AddStudent(test_student1);
            test_book.AddStudent(test_student2);
            test_book.AddStudent(test_student3);
            Assert.Equal(3, test_book.GetStudentRoster().Count);
        }

        [Fact]
        public void ToStringEmpty_Is_OK()
        {
            Book test_book = new Book();

            Assert.Equal("No records available.", test_book.ToString());
        }

        [Fact]
        public void ToStringPopulated_Is_OK()
        {
            Book test_book = new Book();
            Student test_student1 = new Student("Austin", "Powers");
            Student test_student2 = new Student("Susan", "Powers");
            Student test_student3 = new Student("Reed", "Richards");

            test_book.AddStudent(test_student1);
            test_book.AddStudent(test_student2);
            test_book.AddStudent(test_student3);

            Assert.Contains("Reed Richards", test_book.ToString());
            Assert.Contains("Susan Powers", test_book.ToString());
        }
    }
}
