using GradeBook;
using Xunit;

namespace GradeBook_Tests
{
    public class Subject_Tests
    {
        [Fact]
        public void Subject_Init_IS_OK()
        {
            Subject test_subject = new Subject("French", 72.5f);
            Assert.Equal("French", test_subject.GetName());
            Assert.Equal(72.5f, test_subject.GetScore());
        }

        [Fact]
        public void DefaultName_IS_NA()
        {
            Subject test_subject = new Subject();
            Assert.Equal("N/A", test_subject.GetName());
        }

        [Fact]
        public void DefaultScore_IS_Zero()
        {
            Subject test_subject = new Subject();
            Assert.Equal(0.0f, test_subject.GetScore());
        }

        [Fact]
        public void SetName_ValidInput()
        {
            Subject test_subject = new Subject();
            test_subject.SetName("Gym");
            Assert.Equal("Gym", test_subject.GetName());
        }

        [Fact]
        public void SetScore_ValidInput()
        {
            Subject test_subject = new Subject();
            test_subject.SetScore(12.5f);
            Assert.Equal(12.5f, test_subject.GetScore());
        }

        [Fact]
        public void SetName_InvalidInput()
        {
            Subject test_subject = new Subject();
            test_subject.SetName(" ");
            Assert.Equal("N/A", test_subject.GetName());
        }

        [Fact]
        public void SetScore_InvalidInput()
        {
            Subject test_subject = new Subject();
            test_subject.SetScore(-3.5f);
            Assert.Equal(0.0f, test_subject.GetScore());
        }

        [Fact]
        public void GetLetterGrade_Returns_RightGrade()
        {
            Subject test_subject = new Subject("Geography", 98.2f);
            Assert.Equal("A", Subject.GetLetterScore(test_subject));

            test_subject.SetScore(76f);
            Assert.Equal("B", Subject.GetLetterScore(test_subject));

            test_subject.SetScore(60.7f);
            Assert.Equal("C", Subject.GetLetterScore(test_subject));

            test_subject.SetScore(43.2f);
            Assert.Equal("D", Subject.GetLetterScore(test_subject));

            test_subject.SetScore(10.2f);
            Assert.Equal("F", Subject.GetLetterScore(test_subject));
        }
    }
}
