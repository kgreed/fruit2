﻿using System;
using System.Data;
using System.Linq;
using System.Data.Entity;
using System.Data.Common;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.ComponentModel;
using DevExpress.ExpressApp.EF.Updating;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.ExpressApp.Design;
using DevExpress.ExpressApp.EF.DesignTime;
using DevExpress.Persistent.BaseImpl.EF.PermissionPolicy;

namespace fruit2.Module.BusinessObjects {
	public class fruit2ContextInitializer : DbContextTypesInfoInitializerBase {
		protected override DbContext CreateDbContext() {
			DbContextInfo contextInfo = new DbContextInfo(typeof(fruit2DbContext), new DbProviderInfo(providerInvariantName: "System.Data.SqlClient", providerManifestToken: "2008"));
            return contextInfo.CreateInstance();
		}
	}
	[TypesInfoInitializer(typeof(fruit2ContextInitializer))]
	public class fruit2DbContext : DbContext {
		public fruit2DbContext(String connectionString)
			: base(connectionString) {
		}
		public fruit2DbContext(DbConnection connection)
			: base(connection, false) {
		}
		public fruit2DbContext() {
		}
		public DbSet<ModuleInfo> ModulesInfo { get; set; }
	    public DbSet<PermissionPolicyRole> Roles { get; set; }
		public DbSet<PermissionPolicyTypePermissionObject> TypePermissionObjects { get; set; }
		public DbSet<PermissionPolicyUser> Users { get; set; }
		public DbSet<ModelDifference> ModelDifferences { get; set; }
		public DbSet<ModelDifferenceAspect> ModelDifferenceAspects { get; set; }
	}
}