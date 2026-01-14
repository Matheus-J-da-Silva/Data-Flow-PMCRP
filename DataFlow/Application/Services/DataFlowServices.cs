using DataFlow.Services.Interfaces;
using DataFlow.Conf.Settings;
using Microsoft.VisualBasic;
using System.Net;
using Sprache;


namespace DataFlow.Services.Implementations

{
    public class DataFlowServices : IDataFlowServices
    {
        public async Task DataFlowGetPageResource()
        {
        Settings settings = new Settings();

        var ANP_PEG = Environment.GetEnvironmentVariable("ANP_PEG");

        using var httpClient = new HttpClient();
        var response = await httpClient.GetAsync(ANP_PEG);
        var result = response.Content;

        Console.WriteLine(result);


        

    
        }

        public void DataFlowGetLinksInPage(string resource)
        {
            // Implementation code here
        }

        public string DataFlowSaveDocuments(string destination, string content)
        {
            // Implementation code here
            return "Document saved successfully.";
        }
    }
}