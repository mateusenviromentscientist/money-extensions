using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MoneyExtension.Tests;

[TestClass]
public class MoneyExtensionTests
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {
        decimal valor = 279.98M;
        var cent = valor.ToCents();
        
        Assert.AreEqual(27998, cent);
    }
}