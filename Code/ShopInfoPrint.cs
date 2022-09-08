public class ShopInforPrint {

    public string InputShopName() {
        Console.Write("Please Input Name: ");

        return Console.ReadLine();
    }

    public string InputTaxID() {
        Console.Write("Please Input Number: ");

        return Console.ReadLine();
    }

    public string InputKeeperName() {
        Console.Write("Please Input Owner Name: ");

        return Console.ReadLine();
    }

    public string RegisteredValue() {
        Console.Write("Please Input Registered Value: ");

        return Console.ReadLine();
    }

    public long ConvertStringToLong(string value) {
        if (long.TryParse(value, out long number)){
            return number;
        }

        throw new Exception("Please Input Number Only.");
    }
    public void PrintInfo(string shopname, long realid, string keepername, long realvalue) {
        Console.WriteLine();
        Console.WriteLine("--------Shop Information--------");
        Console.WriteLine("Name: {0}", shopname);
        Console.WriteLine("Number: {0}", realid);
        Console.WriteLine("Owner Name: {0}", keepername);
        Console.WriteLine("Registered Value: {0}", realvalue);
        Console.WriteLine("--------------------------------");
    }
}