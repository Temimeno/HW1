public class ProgramMain {
    static void Main(string[] args) {

        //1.1
        ShopInforPrint shopinfo = new ShopInforPrint();
        string shopname = shopinfo.InputShopName();
        string id = shopinfo.InputTaxID();
        long realid = shopinfo.ConvertStringToLong(id);
        string keepername = shopinfo.InputKeeperName();
        string regisvalue = shopinfo.RegisteredValue();
        long realvalue = shopinfo.ConvertStringToLong(regisvalue);
        shopinfo.PrintInfo(shopname, realid, keepername, realvalue);

        //1.2
        MoneyExchange moneyEx = new MoneyExchange();
        string inputMon = moneyEx.InputMoney();
        double converter = moneyEx.ConvertStringToDouble(inputMon);
        moneyEx.CalMoney(converter);
    }
}