using System;

public class Program {
    public static double ConvertStringToDouble(string value) {
        if (double.TryParse(value, out double number)){
            return number;
        }

        throw new Exception("Please Input Number Only.");
    }
    public static string InputMoney() {
        Console.Write("Please input money: ");

        return Console.ReadLine();
    }
    public static void Main(string[] args) {

        int FrontNum = 0;
        double DecimalNum = 0;

        string input = InputMoney();
        double converter = ConvertStringToDouble(input);

        if (converter % 1 != 0) {
            double SplitBack = converter % 1;
            DecimalNum = SplitBack;
        }
        int SplitFront = Convert.ToInt32(converter);
        FrontNum = SplitFront;

        //Calculate Integer Part
        int TotalFront = FrontNum;
        int Thousands = TotalFront / 1000;
        int Remain1 = TotalFront - (Thousands * 1000);
        int FiveHundred = Remain1 / 500;
        int Remain2 = Remain1 - (FiveHundred * 500);
        int Hundred = Remain2 / 100;
        int Remain3 = Remain2 - (Hundred * 100);
        int Fifty = Remain3 / 50;
        int Remain4 = Remain3 - (Fifty * 50);
        int Ten = Remain4 / 10;
        int Remain5 = Remain4 - (Ten * 10);
        int Five = Remain5 / 5;
        int Remain6 = Remain5 - (Five * 5);
        int Two = Remain6 / 2;
        int Remain7 = Remain6 - (Fifty * 2);
        int One = Remain7 / 1;

        //Calculate Decimal Part
        double DecToPercent = DecimalNum * 100;
        int ConvertBackNum = Convert.ToInt32(DecToPercent);
        int Half = ConvertBackNum / (50);
        int DecRemain1 = ConvertBackNum - (Half * 50);
        int Quarter = DecRemain1 / (25);

        //Print infomation
        Console.WriteLine("1000: {0}", Thousands);
        Console.WriteLine("500: {0}", FiveHundred);
        Console.WriteLine("100: {0}", Hundred);
        Console.WriteLine("50: {0}", Fifty);
        Console.WriteLine("10: {0}", Ten);
        Console.WriteLine("5: {0}", Five);
        Console.WriteLine("2: {0}", Two);
        Console.WriteLine("1: {0}", One);
        Console.WriteLine(".50: {0}", Half);
        Console.WriteLine(".25: {0}", Quarter);
    }
}
