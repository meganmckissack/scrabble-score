using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ScrabbleScore.Models;


namespace ScrabbleScore.Tests
{
  [TestClass]
  public class LetterTests
  {
    // Test methods go here
    [TestMethod]
    public void LetterConstructor_CreatesInstanceOfLetter_Letter()
    {
      Letter newLetter = new Letter();
      Assert.AreEqual(typeof(Letter), newLetter.GetType());
    }

     [TestMethod]
    public void GetKey_CreatesKeyValuePairs_True()
    {
      //changed to char because of error messages I received when running test
     Dictionary<char, int> letters = new Dictionary<char, int>(){{'A', 1}, {'E', 1}, {'I', 1}, {'O', 1}, {'U', 1}, {'L', 1}, {'N', 1}, {'R', 1}, {'S', 1}, {'T', 1}, {'D', 2}, {'G', 2}, {'B', 3}, {'C', 3}, {'M', 3}, {'P', 3}, {'F', 4}, {'H', 4}, {'V', 4}, {'W', 4}, {'Y', 4}, {'K', 5},    {'J', 8}, {'X', 8},    {'Q', 10}, {'Z', 10}};
      Assert.AreEqual(1, letters['A']);

      //error CS0246: The type or namespace name 'Dictionary<,>' could not be found (are you missing a using directive or an assembly reference?) [/Users/mmckissack/Desktop/ScrabbleScore.Solution/ScrabbleScore.Tests/ScrabbleScore.Tests.csproj]

      // var method = typeof(KeyValuePair<,>).GetProperty("Value").GetGetMethod();
    }

   //     [TestMethod]
   // public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
   // {
   //   // any necessary logic to prep for test; instantiating new classes, etc.
   //   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
   // }
  }
}