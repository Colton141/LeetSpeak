using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leet;

namespace LeetTest
{
  [TestClass]
  public class LeetTest
  {
    [TestMethod]
    public void IsLeet_ReplaceLowerCaseEWith3()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.AreEqual(true, testLeetSpeak.IsLeet('e'));
    }

    [TestMethod]
    public void IsLeet_ResplaceLowerCaseOWith0()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.AreEqual(true, testLeetSpeak.IsLeet('o'));
    }

    [TestMethod]
    public void IsLeet_ResplaceUpperCaseIWith1()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.AreEqual(true, testLeetSpeak.IsLeet('I'));
    }

    [TestMethod]
    public void IsLeet_ResplaceLowerCaseTWith7()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.AreEqual(true, testLeetSpeak.IsLeet('t'));
    }

    [TestMethod]
    public void IsLeet_ResplaceLowerCaseSWith7()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.AreEqual(true, testLeetSpeak.IsLeet('s'));
    }
  }
}
