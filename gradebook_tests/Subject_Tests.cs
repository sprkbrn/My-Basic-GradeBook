using System;
using System.Collections.Generic;
using System.Text;
using GradeBook;
using Xunit;

namespace GradeBook.Tests
{
    public class Subject_Tests
    {
        [Fact]
        public void Subject_Init_IS_OK()
        {
            Subject test_subject = new Subject("French", 72.5f);
            Assert.Equal("French", test_subject.getName());
            Assert.Equal(72.5f, test_subject.getScore());
        }

        [Fact]
        public void DefaultName_IS_NA()
        {
            Subject test_subject = new Subject();
            Assert.Equal("N/A", test_subject.getName());
        }

        [Fact]
        public void DefaultScore_IS_Zero()
        {
            Subject test_subject = new Subject();
            Assert.Equal(0.0f, test_subject.getScore());
        }

        [Fact]
        public void SetName_ValidInput()
        {
            Subject test_subject = new Subject();
            test_subject.setName("Gym");
            Assert.Equal("Gym", test_subject.getName());
        }

        [Fact]
        public void SetScore_ValidInput()
        {
            Subject test_subject = new Subject();
            test_subject.setScore(12.5f);
            Assert.Equal(12.5f, test_subject.getScore());
        }

        [Fact]
        public void SetNameWorks_InvalidInput()
        {
            Subject test_subject = new Subject();
            test_subject.setName(" ");
            Assert.Equal("N/A", test_subject.getName());
        }

        [Fact]
        public void SetScoreWorks_InvalidInput()
        {
            Subject test_subject = new Subject();
            test_subject.setScore(-3.5f);
            Assert.Equal(0.0f, test_subject.getScore());
        }

    }
}
