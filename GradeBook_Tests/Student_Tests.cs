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
            Assert.Equal("John Doe", test_student.GetFullName());
        }

        [Fact]
        public void FirstNameInit_Is_OK()
        {
            Student test_student = new Student("Joe");
            Assert.Equal("Joe Doe", test_student.GetFullName());
        }

        [Fact]
        public void FirstNameAssignment_Is_OK()
        {
            Student test_student = new Student("Jerry");
            test_student.SetFirstName("Ben");
            Assert.Equal("Ben", test_student.GetFirstName());
        }

        [Fact]
        public void LastNameInit_Is_OK()
        {
            Student test_student = new Student(" ", "French");
            Assert.Equal("John French", test_student.GetFullName());
        }

        [Fact]
        public void LastNameAssignment_Is_OK()
        {
            Student test_student = new Student();
            test_student.SetLastName("Deer");
            Assert.Equal("Deer", test_student.GetLastName());
        }

        [Fact]
        public void NoGrades_Is_EmptyList()
        {
            Student test_student = new Student();
            Assert.Empty(test_student.GetAllSubjects());
        }

        [Fact]
        public void PopulatedClasses()
        {
            Student test_student = new Student();
            test_student.AddClass("Math", 42.5f);
            test_student.AddClass("Science", 85.9f);

            Subject sub_math = test_student.GetSubjectByName("Math");
            Subject sub_sci = test_student.GetSubjectByName("Science");

            Assert.Equal("Math", sub_math.GetName());
            Assert.Equal("B", Subject.GetLetterScore(sub_sci));
        }

        [Fact]
        public void GetAllSubjects_Returns_ListOfSubjects()
        {
            Student test_student = new Student();
            test_student.AddClass("Social Sciences", 82.3f);
            test_student.AddClass("Health & Wellness", 75.4f);

            List<Subject> list_of_results = test_student.GetAllSubjects();
            Assert.Equal(2, list_of_results.Count);
        }

        [Fact]
        public void GetHighestGradedSubject_Returns_RightSubject()
        {
            Student test_student = new Student();
            test_student.AddClass("Social Sciences", 10.3f);
            test_student.AddClass("Health & Wellness", 65.4f);

            Subject result = test_student.GetHighestGradedSubject();
            Assert.Equal("Health & Wellness", result.GetName());
        }

        [Fact]
        public void GetLowestGradedSubject_Returns_RightSubject()
        {
            Student test_student = new Student();
            test_student.AddClass("Social Sciences", 42.3f);
            test_student.AddClass("Health & Wellness", 59f);

            Subject result = test_student.GetLowestGradedSubject();
            Assert.Equal("Social Sciences", result.GetName());
        }
    }
}
