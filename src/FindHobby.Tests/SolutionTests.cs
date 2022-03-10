using FindHobby.Core;
using NUnit.Framework;

namespace FindHobby.Tests
{
    [TestFixture]
    public class SolutionTests
    {
        [TestCase(3, 3, ExpectedResult = Hobby.Writer, Description = "FindHobby.1")]
        [TestCase(1, 1, ExpectedResult = Hobby.Painter, Description = "FindHobby.2")]
        [TestCase(4, 5, ExpectedResult = Hobby.Writer, Description = "FindHobby.3")]
        [TestCase(4, 6, ExpectedResult = Hobby.Painter, Description = "FindHobby.4")]
        [TestCase(4, 2, ExpectedResult = Hobby.Writer, Description = "FindHobby.5")]
        [TestCase(8, 100, ExpectedResult = Hobby.Painter, Description = "FindHobby.6")]
        [TestCase(10, 470, ExpectedResult = Hobby.Painter, Description = "FindHobby.7")]
        [TestCase(17, 5921, ExpectedResult = Hobby.Writer, Description = "FindHobby.8")]
        [TestCase(20, 171971, ExpectedResult = Hobby.Painter, Description = "FindHobby.9")]
        public Hobby FindHobbyTest(int level, int pos)
        {
            return Hobby.Painter;
        }
    }
}