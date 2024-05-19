using Microsoft.Extensions.Logging;

namespace Mazi.Pipeline.Api.Logging;

public class SqlDatabaseLoggerOptions
{
   public LogLevel LogLevel { get; set; }
   public string ConnectionString { get; set; }
}
