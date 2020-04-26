using Lab_2;
using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void stringFromFile()
        {
            String s = "10 20 30";
            int[] expected = new int[3] { 10, 20, 30 };
            int[] actual = Program.ParseResult(s);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void LogicTest()
        {
            int[] dats = new int[3] { 1, 2, 3 };
            string actual = Program.Logic(dats);
            string expected = "0,68333";
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void NewFuncTest()
        {
            String s = "1 2 3";
            string actual = NewData.GetRecessivePr(s);
            string expected = "0,31667";
            Assert.Equal(expected, actual);
        }
    }
}
