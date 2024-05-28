using RestSharp;
using System.Xml.Linq;

public class DataSender
{
    private readonly string endpoint;

    public DataSender(string url)
    {
        this.endpoint = url;
    }

    public void SendData(List<XElement> data) =>
        File.WriteAllText(endpoint, new XElement("list", data).ToString());
    public void SendData(XElement witsmlData)
    {
        var client = new RestClient(endpoint);
        var request = new RestRequest("", Method.Post);

        request.AddHeader("Content-Type", "application/xml");
        request.AddParameter("application/xml", witsmlData.ToString(), ParameterType.RequestBody);

        var response = client.Execute<RestResponse>(request);

        if (response.IsSuccessful)
        {
            Console.WriteLine("Data sent successfully!");
            Console.WriteLine(response.Content);
        }
        else
        {
            Console.WriteLine("Error sending data!");
            Console.WriteLine(response.ErrorMessage);
        }
    }
}
