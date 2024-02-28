using Microsoft.VisualStudio.TestTools.UnitTesting;

/// <summary> ArabicToRoman Testing </summary>
/// <author>Svitlana Bakun</author>
/// <project>ArabicToRomanTests</project>
/// <version>1.0.0</version>

namespace ArabicToRoman.Tests;

[TestClass()]
public class ConverterTests
{
    [TestMethod()]
    public void WhenLessThan0_ThenNull()
    {
        Assert.IsNull(Converter.ConvertArabicToRoman(-2));
    }
    
    [TestMethod()]
    public void When0_ThenNull()
    {
        Assert.IsNull(Converter.ConvertArabicToRoman(0));
    }
    
    [TestMethod()]
    public void When4000_ThenNull()
    {
        Assert.IsNull(Converter.ConvertArabicToRoman(4000));
    }

    [TestMethod()]
    public void WhenMoreThan4000_ThenNull()
    {
        Assert.IsNull(Converter.ConvertArabicToRoman(34340));
    }

    [TestMethod()]
    public void When1_ThenI()
    {
        Assert.AreEqual("I", Converter.ConvertArabicToRoman(1));
    }

    [TestMethod()]
    public void When4_ThenIV()
    {
        Assert.AreEqual("IV", Converter.ConvertArabicToRoman(4));
    }

    [TestMethod()]
    public void When5_ThenV()
    {
        Assert.AreEqual("V", Converter.ConvertArabicToRoman(5));
    }

    [TestMethod()]
    public void When9_ThenIX()
    {
        Assert.AreEqual("IX", Converter.ConvertArabicToRoman(9));

    }

    [TestMethod()]
    public void When10_ThenX()
    {
        Assert.AreEqual("X", Converter.ConvertArabicToRoman(10));
    }

    [TestMethod()]
    public void When40_ThenXL()
    {
        Assert.AreEqual("XL", Converter.ConvertArabicToRoman(40));
    }

    [TestMethod()]
    public void When50_ThenL()
    {
        Assert.AreEqual("L", Converter.ConvertArabicToRoman(50));
    }
    
    [TestMethod()]
    public void When90_ThenXC()
    {
        Assert.AreEqual("XC", Converter.ConvertArabicToRoman(90));
    }

    [TestMethod()]
    public void When100_ThenC()
    {
        Assert.AreEqual("C", Converter.ConvertArabicToRoman(100));
    }

    [TestMethod()]
    public void When400_ThenCD()
    {
        Assert.AreEqual("CD", Converter.ConvertArabicToRoman(400));
    }

    [TestMethod()]
    public void When500_ThenD()
    {
        Assert.AreEqual("D", Converter.ConvertArabicToRoman(500));
    }

    [TestMethod()]
    public void When900_ThenCD()
    {
        Assert.AreEqual("CM", Converter.ConvertArabicToRoman(900));
    }

    [TestMethod()]
    public void When1000_ThenM()
    {
        Assert.AreEqual("M", Converter.ConvertArabicToRoman(1000));
    }

    [TestMethod()]
    public void When12_ThenXII()
    {
        Assert.AreEqual("XII", Converter.ConvertArabicToRoman(12));
    }

    [TestMethod()]
    public void When27_ThenXXVII()
    {
        Assert.AreEqual("XXVII", Converter.ConvertArabicToRoman(27));
    }

    [TestMethod()]
    public void When34_ThenXXXIV()
    {
        Assert.AreEqual("XXXIV", Converter.ConvertArabicToRoman(34));
    }

    [TestMethod()]
    public void When42_ThenXLII()
    {
        Assert.AreEqual("XLII", Converter.ConvertArabicToRoman(42));
    }

    [TestMethod()]
    public void When55_ThenXII()
    {
        Assert.AreEqual("LV", Converter.ConvertArabicToRoman(55));
    }

    [TestMethod()]
    public void When78_ThenLXXVIII()
    {
        Assert.AreEqual("LXXVIII", Converter.ConvertArabicToRoman(78));
    }

    [TestMethod()]
    public void When83_ThenLXXXIII()
    {
        Assert.AreEqual("LXXXIII", Converter.ConvertArabicToRoman(83));
    }

    [TestMethod()]
    public void When99_ThenXCIX()
    {
        Assert.AreEqual("XCIX", Converter.ConvertArabicToRoman(99));
    }

    [TestMethod()]
    public void When145_ThenCXLV()
    {
        Assert.AreEqual("CXLV", Converter.ConvertArabicToRoman(145));
    }

    [TestMethod()]
    public void When198_ThenCXCVIII()
    {
        Assert.AreEqual("CXCVIII", Converter.ConvertArabicToRoman(198));
    }

    [TestMethod()]
    public void When239_ThenCCXXXIX()
    {
        Assert.AreEqual("CCXXXIX", Converter.ConvertArabicToRoman(239));
    }

    [TestMethod()]
    public void When281_ThenCCVXXXI()
    {
        Assert.AreEqual("CCLXXXI", Converter.ConvertArabicToRoman(281));
    }

    [TestMethod()]
    public void When333_ThenCCCXXXIII()
    {
        Assert.AreEqual("CCCXXXIII", Converter.ConvertArabicToRoman(333));
    }

    [TestMethod()]
    public void When472_ThenCDVXXII()
    {
        Assert.AreEqual("CDLXXII", Converter.ConvertArabicToRoman(472));
    }

    [TestMethod()]
    public void When599_ThenDXCIX()
    {
        Assert.AreEqual("DXCIX", Converter.ConvertArabicToRoman(599));
    }

    [TestMethod()]
    public void When850_ThenDCCCL()
    {
        Assert.AreEqual("DCCCL", Converter.ConvertArabicToRoman(850));
    }

    [TestMethod()]
    public void When990_ThenCMXC()
    {
        Assert.AreEqual("CMXC", Converter.ConvertArabicToRoman(990));
    }

    [TestMethod()]
    public void When1467_ThenMCDLXVII()
    {
        Assert.AreEqual("MCDLXVII", Converter.ConvertArabicToRoman(1467));
    }

    [TestMethod()]
    public void When1992_ThenMCMXCII()
    {
        Assert.AreEqual("MCMXCII", Converter.ConvertArabicToRoman(1992));
    }

    [TestMethod()]
    public void When2568_ThenMMDLXVIII()
    {
        Assert.AreEqual("MMDLXVIII", Converter.ConvertArabicToRoman(2568));
    }

    [TestMethod()]
    public void When2806_ThenMMDCCCVI()
    {
        Assert.AreEqual("MMDCCCVI", Converter.ConvertArabicToRoman(2806));
    }

    [TestMethod()]
    public void When3009_ThenMMMIX()
    {
        Assert.AreEqual("MMMIX", Converter.ConvertArabicToRoman(3009));
    }

    [TestMethod()]
    public void When3904_ThenMMMCMIV()
    {
        Assert.AreEqual("MMMCMIV", Converter.ConvertArabicToRoman(3904));
    }
}