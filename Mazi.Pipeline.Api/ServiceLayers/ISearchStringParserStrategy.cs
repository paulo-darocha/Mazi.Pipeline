namespace Mazi.Pipeline.Api.ServiceLayers;

public interface ISearchStringParserStrategy
{
   string[] Parse(string parseThis);
}
