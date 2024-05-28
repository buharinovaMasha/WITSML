using System.Xml.Linq;

public class WitsmlDataFormatter
{
    public static List<XElement> CreateWitsmlRandomData()
    {
        var list = new List<XElement>();
        for(int i =0;i<3;i++)
            list.Add(new XElement("witsml",
                new XElement("data",
                    new XElement("value", DataGenerator.GenerateRandomNumber(1, 100))
                )
            ));
        return list;
    }
}
