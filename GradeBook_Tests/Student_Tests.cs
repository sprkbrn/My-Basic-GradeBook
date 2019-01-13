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
        public void SubjectInit_Is_OK()
        {
            Subject arts = new Subject("Arts & Crafts", 72.0f);
            Student test_student = new Student("Lara", "Croft", arts);
            Assert.Equal("Arts & Crafts", test_student.GetSubjectByName("Arts & Crafts").GetName());
        }

        [Fact]
        public void StudentInit_Is_OK()
        {
            Student test_student = new Student("Michael", "John", new Subject("Yeah", 100f));
            Student copy_student = new Student(test_student);
            Assert.Equal("John", copy_student.GetLastName());
        }

        [Fact]
        public void NoGrades_Is_EmptyList()
        {
            Student test_student = new Student();
            Assert.Empty(test_student.GetAllSubjects());
        }

        [Fact]
        public void PopulatedClass_Is_OK()
        {
            Student test_student = new Student();
            test_student.AddSubject("Math", 42.5f);
            test_student.AddSubject("Science", 85.9f);

            Subject sub_math = test_student.GetSubjectByName("Math");
            Subject sub_sci = test_student.GetSubjectByName("Science");

            Assert.Equal("Math", sub_math.GetName());
            Assert.Equal("B", Subject.GetLetterScore(sub_sci));
        }

        [Fact]
        public void GetSubjectByName_Returns_RightSubject()
        {
            Student test_student = new Student("John", "Doe");
            Subject math = new Subject("Math", 30.0f);
            Subject science = new Subject("Science", 80.0f);
            Subject art = new Subject("Art", 10.0f);

            test_student.AddSubject(math);
            test_student.AddSubject(science);
            test_student.AddSubject(art);

            Subject result = test_student.GetSubjectByName("Art");
            Assert.Equal(10.0f, result.GetScore());

            Subject result2 = test_student.GetSubjectByName("Math");
            Assert.Equal(30.0f, result2.GetScore());
        }

        [Fact]
        public void AddSubject_Is_OK()
        {
            Student test_student = new Student();
            Assert.Empty(test_student.GetAllSubjects());

            test_student.AddSubject("Math", 90.5f);
            Assert.NotEmpty(test_student.GetAllSubjects());
            Assert.Equal("Math", test_student.GetSubjectByName("Math").GetName());
        }

        [Fact]
        public void EditSubject_Is_OK()
        {
            Student test_student = new Student();
            test_student.AddSubject("Science", 80.0f);
            test_student.EditSubject("Science", "Dance");
            Assert.Equal("Dance", test_student.GetSubjectByName("Dance").GetName());

            Student test_student2 = new Student();
            test_student2.AddSubject("Gym", 70.3f);
            test_student2.AddSubject("Library", 68.6f);

            test_student2.EditSubject("Library", "Personal Study", 80.0f);
            Assert.Equal("Personal Study", test_student2.GetSubjectByName("Personal Study").GetName());
            Assert.Equal(80.0f, test_student2.GetSubjectByName("Personal Study").GetScore());
        }

        [Fact]
        public void DropSubject_Is_OK()
        {
            Student test_student = new Student();

            test_student.AddSubject("Lunch", 10.0f);
            Assert.NotEmpty(test_student.GetAllSubjects());

            test_student.DropSubject("Lunch");
            Assert.Empty(test_student.GetAllSubjects());
        }

        [Fact]
        public void GetAllSubjects_Returns_ListOfSubjects()
        {
            Student test_student = new Student();
            test_student.AddSubject("Social Sciences", 82.3f);
            test_student.AddSubject("Health & Wellness", 75.4f);

            List<Subject> list_of_results = test_student.GetAllSubjects();
            Assert.Equal(2, list_of_results.Count);
        }

        [Fact]
        public void GetHighestGradedSubject_Returns_RightSubject()
        {
            Student test_student = new Student();
            test_student.AddSubject("Social Sciences", 10.3f);
            test_student.AddSubject("Health & Wellness", 65.4f);

            Subject result = test_student.GetHighestGradedSubject();
            Assert.Equal("Health & Wellness", result.GetName());
        }

        [Fact]
        public void GetLowestGradedSubject_Returns_RightSubject()
        {
            Student test_student = new Student();
            test_student.AddSubject("Social Sciences", 42.3f);
            test_student.AddSubject("Health & Wellness", 59f);

            Subject result = test_student.GetLowestGradedSubject();
            Assert.Equal("Social Sciences", result.GetName());
        }
    }
}
