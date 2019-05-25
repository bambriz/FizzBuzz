using System;
using Xunit;
using FizzBuzzLib;
using System.Collections;

namespace XUnitTestProject1
{
    public class FizzBuzzTest
    {
        [Fact]
        public void does15PrintFizzBuzz_If3PrintsFizz_if5PrintsBuzz()
        {
            //Arrange
            var fb = new FizzBuzz(15);
            //Act
            ArrayList testArray = fb.getFizzBuzz();
            //Assert
            Assert.Equal("FizzBuzz", testArray[14]);
            
        }

       [Fact]
        public void printsEmptyStringIfEmpty()
        {
            //Arrange
            var fb = new FizzBuzz();
            //Act
            ArrayList testArray = fb.getFizzBuzz();
            //Assert
            Assert.Equal("", testArray[0]);
        }

        [Fact]
        public void printsProperWordIfNumberDivisibleByAllKeys()
        {
            //Arrange
            int a = 3;
            int b = 5;
            int c = 6;
            string aS = "Cheesy";
            string bS = "Fish";
            string cS = "Taco";
            string dS = aS + bS + cS;

            var fb = new FizzBuzz(30);
            fb.addFizzBuzzPair(a, aS);
            fb.addFizzBuzzPair(b, bS);
            fb.addFizzBuzzPair(c, cS);

            //Act

            ArrayList testArray = fb.getCustomFizzBuzz();

            //Assert
            Assert.Equal(dS, testArray[29]);
        }

        [Fact]
        public void verifySameKeyOverWritesOldOne()
        {
            //Arrange
            int a = 3;
            string a1 = "First";
            string a2 = "Second";
            string a3 = "Third";

            var fb = new FizzBuzz(3);
            fb.addFizzBuzzPair(a, a1);
            fb.addFizzBuzzPair(a, a2);
            fb.addFizzBuzzPair(a, a3);

            //Act

            ArrayList arrayTest = fb.getCustomFizzBuzz();

            //Assert

            Assert.Equal(a3, arrayTest[2]);

        }

        [Fact]
        public void cannotAddKeysAboveUpperBound()
        {
            //Arrange
            int upBound = 10;
            int key = 11;
            string val = "Hello";



            //Act

            var fb = new FizzBuzz(upBound);
            fb.addFizzBuzzPair(key, val);

            //Assert

            Assert.True(fb.fbDictIsEmpty());
        }

        [Fact]
        public void cannotAddKeysBelowOne()
        {
            //Arrange
            int upBound = 10;
            int key = -1;
            string val = "World";



            //Act

            var fb = new FizzBuzz(upBound);
            fb.addFizzBuzzPair(key, val);

            //Assert

            Assert.True(fb.fbDictIsEmpty());
        }

        [Fact]
        public void uppderBoundCannotBeBelowOne()
        {
            //Arrange
            int upBound = -1;

            //Act
            var fb = new FizzBuzz(upBound);

            //Assert
            Assert.NotEqual(upBound, fb.getUpperBound());
        }
    }
}
