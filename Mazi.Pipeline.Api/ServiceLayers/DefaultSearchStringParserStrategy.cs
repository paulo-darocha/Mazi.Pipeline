using System;

namespace Mazi.Pipeline.Api.ServiceLayers;

public class DefaultSearchStringParserStrategy : ISearchStringParserStrategy
{
   private readonly string semiColonDelimiter = ";";
   private readonly string commaDelimiter = ",";

   public string[] Parse(string parseThis)
   {
      throw new NotImplementedException();
   }

   //
   //
   // Private Methods
   private string[] ParseNonEmptySearch(string parseThis)
   {
      throw new NotImplementedException();
   }
}
