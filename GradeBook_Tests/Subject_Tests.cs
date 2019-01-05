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
        public void SetNameWorks_InvalidInput()
        {
            Subject test_subject = new Subject();
            test_subject.SetName(" ");
            Assert.Equal("N/A", test_subject.GetName());
        }

        [Fact]
        public void SetScoreWorks_InvalidInput()
        {
            Subject test_subject = new Subject();
            test_subject.SetScore(-3.5f);
            Assert.Equal(0.0f, test_subject.GetScore());
        }

    }
}
