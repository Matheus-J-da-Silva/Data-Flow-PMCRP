using System.Net;

namespace DataFlow.Services.Interfaces;
public interface IDataFlowServices
{
     public Task DataFlowGetPageResource();
    public void DataFlowGetLinksInPage(string resource);
    public string DataFlowSaveDocuments(string destination, string content);
}