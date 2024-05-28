using System;

class Program
{
    static void Main(string[] args)
    {
        var witsmlData = WitsmlDataFormatter.CreateWitsmlRandomData();
        Console.WriteLine($"WITSML Data: {witsmlData}");

        /* отправка в API 
        var url = "";
        var dataSender = new DataSender(url);
        dataSender.SendData(witsmlData);
        */

        var dataSender = new DataSender("test.xml");
        dataSender.SendData(witsmlData);
    }
}
