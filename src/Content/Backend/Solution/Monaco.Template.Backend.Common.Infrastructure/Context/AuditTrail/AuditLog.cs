﻿using Serilog;

namespace Monaco.Template.Backend.Common.Infrastructure.Context.AuditTrail;

public static class AuditLog
{
	public static ILogger Audit(List<AuditEntry> auditEntries)
	{
		return Log.ForContext("AuditEntries", auditEntries, true);
	}
}