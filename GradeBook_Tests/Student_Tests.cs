using Xunit;
using System.Collections.Generic;
using GradeBook;

namespace GradeBook_Tests
{
    public class Student_Tests
    {
        [Fact]
        public void DefaultName_Is_JohnDoe()
        {
            Student test_student = new Student();
            Assert.Equal("John Doe", test_student.GetName());
        }

        [Fact]
        public void FirstNameInit_Is_OK()
        {
            Student test_student = new Student();
            test_student.SetName("Joe", " ");
            Assert.Equal("Joe Doe", test_student.GetName());
        }

        [Fact]
        public void LastNameInit_Is_OK()
        {
            Student test_student = new Student();
            test_student.SetName(" ", "French");
            Assert.Equal("John French", test_student.GetName());
        }

        [Fact]
        public void NoGrades_Is_EmptyList()
        {
            Student test_student = new Student();
            Assert.Empty(test_student.GetAllGrades());
        }

        [Fact]
        public void PopulatedClasses()
        {
            Student test_student = new Student();
            test_student.AddClass("Math", 42.5f);
            test_student.AddClass("Science", 85.9f);

            Subject sub_math = test_student.GetGradeByClassName("Math");
            Subject sub_sci = test_student.GetGradeByClassName("Science");

            Assert.Equal("Math", sub_math.GetName());
            Assert.Equal("B", sub_sci.GetLetterScore());
        }

        [Fact]
        public void GetGrades_Returns_ListOfSubjects()
        {
            Student test_student = new Student();
            test_student.AddClass("Social Sciences", 82.3f);
            test_student.AddClass("Health & Wellness", 75.4f);

            List<Subject> list_of_results = test_student.GetAllGrades();
            Assert.Equal(2, list_of_results.Count);
        }

        [Fact]
        public void GetHighestGrade_Returns_RightSubject()
        {
            Student test_student = new Student();
            test_student.AddClass("Social Sciences", 10.3f);
            test_student.AddClass("Health & Wellness", 65.4f);

            Subject result = test_student.GetHighestGrade();
            Assert.Equal("Health & Wellness", result.GetName());
        }

        [Fact]
        public void GetLowestGrade_Returns_RightSubject()
        {
            Student test_student = new Student();
            test_student.AddClass("Social Sciences", 42.3f);
            test_student.AddClass("Health & Wellness", 59f);

            Subject result = test_student.GetLowestGrade();
            Assert.Equal("Social Sciences", result.GetName());
        }
    }
}
