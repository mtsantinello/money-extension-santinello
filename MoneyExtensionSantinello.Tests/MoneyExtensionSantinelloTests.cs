namespace MoneyExtensionSantinello.Tests;

[TestClass]
public class MoneyExtensionSantinelloTests
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {
        decimal valor = 7845455.54M;
        var cents = valor.ToCents();

        Assert.AreEqual(784545554, cents);
    }
}