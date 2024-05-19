using Mazi.Pipeline.Api.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Mazi.Pipeline.Api.DataAccess;

public interface IMaziAppDbContext
{
   DbSet<ConfigurationItemEntity> ConfigurationItemEntities { get; set; }
   DbSet<FeedbackEntity> FeedbackEntities { get; set; }
   DbSet<LogEntryEntity> LogEntryEntities { get; set; }
   DbSet<LookupEntity> LookupEntities { get; set; }
   DbSet<PersonEntity> PersonEntities { get; set; }
   DbSet<UserEntity> UserEntities { get; set; }
   DbSet<UserClaimEntity> UserClaimEntities { get; set; }
}
