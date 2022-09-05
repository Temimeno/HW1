using System;

public class Program {

    public static string InputShopName() {
        Console.Write("Please Input Name: ");

        return Console.ReadLine();
    }

    public static string InputTaxID() {
        Console.Write("Please Input Number: ");

        return Console.ReadLine();
    }

    public static string InputKeeperName() {
        Console.Write("Please Input Owner Name: ");

        return Console.ReadLine();
    }

    public static string RegisteredValue() {
        Console.Write("Please Input Registered Value: ");

        return Console.ReadLine();
    }

    public static long ConvertStringToLong(string value) {
        if (long.TryParse(value, out long numeber)){
            return numeber;
        }

        throw new Exception("Please Input Number Only.");
    }

    public static void PrintInfo(string shopname, long realid, string keepername, long realvalue) {
        Console.WriteLine();
        Console.WriteLine("--------Shop Information--------");
        Console.WriteLine("Name: {0}", shopname);
        Console.WriteLine("Number: {0}", realid);
        Console.WriteLine("Owner Name: {0}", keepername);
        Console.WriteLine("Registered Value: {0}", realvalue);
        Console.WriteLine("--------------------------------");
    }
    static void Main(string[] args) {
        string shopname = InputShopName();
        string id = InputTaxID();
        long realid = ConvertStringToLong(id);
        string keepername = InputKeeperName();
        string regisvalue = RegisteredValue();
        long realvalue = ConvertStringToLong(regisvalue);

        PrintInfo(shopname, realid, keepername, realvalue);
    }
}