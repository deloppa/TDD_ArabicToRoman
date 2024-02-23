using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArabicToRoman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabicToRoman.Tests;

[TestClass()]
public class ConverterTests
{
    [TestMethod()]
    public void ConvertArabicToRomanTest()
    {
        Assert.AreEqual("I", Converter.ConvertArabicToRoman(1));
    }
}