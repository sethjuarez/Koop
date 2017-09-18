///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.2
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Data;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Koop.Data.DatabaseSpecific
{
	/// <summary>Singleton implementation of the PersistenceInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the PersistenceInfoProviderBase class is threadsafe.</remarks>
	internal static class PersistenceInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IPersistenceInfoProvider _providerInstance = new PersistenceInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static PersistenceInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the PersistenceInfoProviderCore</summary>
		/// <returns>Instance of the PersistenceInfoProvider.</returns>
		public static IPersistenceInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the PersistenceInfoProvider. Used by singleton wrapper.</summary>
	internal class PersistenceInfoProviderCore : PersistenceInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="PersistenceInfoProviderCore"/> class.</summary>
		internal PersistenceInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores with the structure of hierarchical types.</summary>
		private void Init()
		{
			this.InitClass();
			InitBillingEntityMappings();
			InitDamageEntityMappings();
			InitExpenseEntityMappings();
			InitGroupEntityMappings();
			InitJobEntityMappings();
			InitPaymentEntityMappings();
			InitPersonEntityMappings();
			InitRoleEntityMappings();
			InitSettingEntityMappings();
			InitStatusEntityMappings();
			InitVendorEntityMappings();
		}

		/// <summary>Inits BillingEntity's mappings</summary>
		private void InitBillingEntityMappings()
		{
			this.AddElementMapping("BillingEntity", @"Job", @"dbo", "Billing", 5, 0);
			this.AddElementFieldMapping("BillingEntity", "Amount", "Amount", true, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 0);
			this.AddElementFieldMapping("BillingEntity", "BillingId", "BillingId", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("BillingEntity", "Date", "Date", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("BillingEntity", "Description", "Description", true, "NVarChar", 1024, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("BillingEntity", "JobId", "JobId", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
		}

		/// <summary>Inits DamageEntity's mappings</summary>
		private void InitDamageEntityMappings()
		{
			this.AddElementMapping("DamageEntity", @"Job", @"dbo", "Damage", 4, 0);
			this.AddElementFieldMapping("DamageEntity", "Active", "Active", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 0);
			this.AddElementFieldMapping("DamageEntity", "DamageId", "DamageId", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("DamageEntity", "Description", "Description", true, "NVarChar", 1024, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("DamageEntity", "Name", "Name", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 3);
		}

		/// <summary>Inits ExpenseEntity's mappings</summary>
		private void InitExpenseEntityMappings()
		{
			this.AddElementMapping("ExpenseEntity", @"Job", @"dbo", "Expense", 11, 0);
			this.AddElementFieldMapping("ExpenseEntity", "Description", "Description", true, "NVarChar", 1024, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("ExpenseEntity", "ExpenseId", "ExpenseId", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("ExpenseEntity", "ExternalInvoice", "ExternalInvoice", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("ExpenseEntity", "InvoiceDate", "InvoiceDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3);
			this.AddElementFieldMapping("ExpenseEntity", "JobId", "JobId", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("ExpenseEntity", "LaborCost", "LaborCost", true, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 5);
			this.AddElementFieldMapping("ExpenseEntity", "LaborHours", "LaborHours", true, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 6);
			this.AddElementFieldMapping("ExpenseEntity", "LaborRate", "LaborRate", true, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 7);
			this.AddElementFieldMapping("ExpenseEntity", "MaterialCost", "MaterialCost", true, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 8);
			this.AddElementFieldMapping("ExpenseEntity", "TotalCost", "TotalCost", true, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 9);
			this.AddElementFieldMapping("ExpenseEntity", "VendorId", "VendorId", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 10);
		}

		/// <summary>Inits GroupEntity's mappings</summary>
		private void InitGroupEntityMappings()
		{
			this.AddElementMapping("GroupEntity", @"Job", @"dbo", "Group", 4, 0);
			this.AddElementFieldMapping("GroupEntity", "Active", "Active", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 0);
			this.AddElementFieldMapping("GroupEntity", "Description", "Description", true, "NVarChar", 1024, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("GroupEntity", "GroupId", "GroupId", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("GroupEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 3);
		}

		/// <summary>Inits JobEntity's mappings</summary>
		private void InitJobEntityMappings()
		{
			this.AddElementMapping("JobEntity", @"Job", @"dbo", "Job", 19, 0);
			this.AddElementFieldMapping("JobEntity", "Address1", "Address1", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("JobEntity", "Address2", "Address2", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("JobEntity", "City", "City", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("JobEntity", "ContractedAmount", "ContractedAmount", true, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 3);
			this.AddElementFieldMapping("JobEntity", "DamageId", "DamageId", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("JobEntity", "Description", "Description", true, "NVarChar", 1024, 0, 0, false, "", null, typeof(System.String), 5);
			this.AddElementFieldMapping("JobEntity", "EndDate", "EndDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 6);
			this.AddElementFieldMapping("JobEntity", "EstimatorId", "EstimatorId", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 7);
			this.AddElementFieldMapping("JobEntity", "GroupId", "GroupId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 8);
			this.AddElementFieldMapping("JobEntity", "IsAging", "IsAging", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 9);
			this.AddElementFieldMapping("JobEntity", "JobId", "JobId", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 10);
			this.AddElementFieldMapping("JobEntity", "Name", "Name", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 11);
			this.AddElementFieldMapping("JobEntity", "Overhead", "Overhead", true, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 12);
			this.AddElementFieldMapping("JobEntity", "PercentDone", "PercentDone", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 13);
			this.AddElementFieldMapping("JobEntity", "StartDate", "StartDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 14);
			this.AddElementFieldMapping("JobEntity", "State", "State", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 15);
			this.AddElementFieldMapping("JobEntity", "StatusId", "StatusId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 16);
			this.AddElementFieldMapping("JobEntity", "UpdateDate", "UpdateDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 17);
			this.AddElementFieldMapping("JobEntity", "Zip", "Zip", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 18);
		}

		/// <summary>Inits PaymentEntity's mappings</summary>
		private void InitPaymentEntityMappings()
		{
			this.AddElementMapping("PaymentEntity", @"Job", @"dbo", "Payment", 5, 0);
			this.AddElementFieldMapping("PaymentEntity", "Amount", "Amount", true, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 0);
			this.AddElementFieldMapping("PaymentEntity", "Date", "Date", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("PaymentEntity", "Description", "Description", true, "NVarChar", 1024, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("PaymentEntity", "JobId", "JobId", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("PaymentEntity", "PaymentId", "PaymentId", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 4);
		}

		/// <summary>Inits PersonEntity's mappings</summary>
		private void InitPersonEntityMappings()
		{
			this.AddElementMapping("PersonEntity", @"Job", @"dbo", "Person", 8, 0);
			this.AddElementFieldMapping("PersonEntity", "Active", "Active", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 0);
			this.AddElementFieldMapping("PersonEntity", "Description", "Description", true, "NVarChar", 1024, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("PersonEntity", "FirstName", "FirstName", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("PersonEntity", "LastName", "LastName", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("PersonEntity", "Password", "Password", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 4);
			this.AddElementFieldMapping("PersonEntity", "PersonId", "PersonId", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 5);
			this.AddElementFieldMapping("PersonEntity", "RoleId", "RoleId", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 6);
			this.AddElementFieldMapping("PersonEntity", "Username", "Username", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 7);
		}

		/// <summary>Inits RoleEntity's mappings</summary>
		private void InitRoleEntityMappings()
		{
			this.AddElementMapping("RoleEntity", @"Job", @"dbo", "Role", 4, 0);
			this.AddElementFieldMapping("RoleEntity", "Active", "Active", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 0);
			this.AddElementFieldMapping("RoleEntity", "Description", "Description", true, "NVarChar", 1024, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("RoleEntity", "Name", "Name", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("RoleEntity", "RoleId", "RoleId", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 3);
		}

		/// <summary>Inits SettingEntity's mappings</summary>
		private void InitSettingEntityMappings()
		{
			this.AddElementMapping("SettingEntity", @"Job", @"dbo", "Settings", 3, 0);
			this.AddElementFieldMapping("SettingEntity", "DbVersion", "DbVersion", true, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 0);
			this.AddElementFieldMapping("SettingEntity", "SettingsId", "SettingsId", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("SettingEntity", "Xml", "Xml", true, "NVarChar", 2048, 0, 0, false, "", null, typeof(System.String), 2);
		}

		/// <summary>Inits StatusEntity's mappings</summary>
		private void InitStatusEntityMappings()
		{
			this.AddElementMapping("StatusEntity", @"Job", @"dbo", "Status", 4, 0);
			this.AddElementFieldMapping("StatusEntity", "Active", "Active", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 0);
			this.AddElementFieldMapping("StatusEntity", "Description", "Description", true, "NVarChar", 1024, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("StatusEntity", "Name", "Name", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("StatusEntity", "StatusId", "StatusId", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 3);
		}

		/// <summary>Inits VendorEntity's mappings</summary>
		private void InitVendorEntityMappings()
		{
			this.AddElementMapping("VendorEntity", @"Job", @"dbo", "Vendor", 4, 0);
			this.AddElementFieldMapping("VendorEntity", "Active", "Active", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 0);
			this.AddElementFieldMapping("VendorEntity", "Description", "Description", true, "NVarChar", 1024, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("VendorEntity", "Name", "Name", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("VendorEntity", "VendorId", "VendorId", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 3);
		}

	}
}
