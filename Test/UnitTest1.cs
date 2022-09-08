namespace Test;

public class UnitTest1
{
    [Fact]
    public void TestConvertStringToLong() {
        ShopInforPrint shopInfoTest = new ShopInforPrint();
        long number = shopInfoTest.ConvertStringToLong("6412050");

        Assert.Equal(number, 6412050);
    }

    [Fact]
    public void TestConvertStringToDouble() {
        MoneyExchange moneyExTest = new MoneyExchange();
        double number = moneyExTest.ConvertStringToDouble("4800000");

        Assert.Equal(number, 4800000);
    }
}