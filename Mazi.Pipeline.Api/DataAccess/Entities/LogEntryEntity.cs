﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mazi.Pipeline.Api.DataAccess.Entities;

[Table("LogEntry", Schema = "dbo")]
public partial class LogEntryEntity : EntityBase
{
   [Column(Order = 1)]
   public string Category { get; set; }

   [Column(Order = 2)]
   public string LogLevel { get; set; }

   [Column(Order = 3)]
   public string LogText { get; set; }

   [Column(Order = 4)]
   public string ExceptionText { get; set; }

   [Column(Order = 5)]
   public string EventId { get; set; }

   [Column(Order = 6)]
   public string State { get; set; }

   [Column(Order = 7)]
   public DateTime LogDate { get; set; }
}
