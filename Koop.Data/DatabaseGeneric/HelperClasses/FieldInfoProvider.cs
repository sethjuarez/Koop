///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.2
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Koop.Data.HelperClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	
	/// <summary>Singleton implementation of the FieldInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the FieldInfoProviderBase class is threadsafe.</remarks>
	internal static class FieldInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IFieldInfoProvider _providerInstance = new FieldInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static FieldInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the FieldInfoProviderCore</summary>
		/// <returns>Instance of the FieldInfoProvider.</returns>
		public static IFieldInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the FieldInfoProvider. Used by singleton wrapper.</summary>
	internal class FieldInfoProviderCore : FieldInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="FieldInfoProviderCore"/> class.</summary>
		internal FieldInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores.</summary>
		private void Init()
		{
			this.InitClass();
			InitBillingEntityInfos();
			InitDamageEntityInfos();
			InitExpenseEntityInfos();
			InitGroupEntityInfos();
			InitJobEntityInfos();
			InitPaymentEntityInfos();
			InitPersonEntityInfos();
			InitRoleEntityInfos();
			InitSettingEntityInfos();
			InitStatusEntityInfos();
			InitVendorEntityInfos();

			this.ConstructElementFieldStructures(InheritanceInfoProviderSingleton.GetInstance());
		}

		/// <summary>Inits BillingEntity's FieldInfo objects</summary>
		private void InitBillingEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(BillingFieldIndex), "BillingEntity");
			this.AddElementFieldInfo("BillingEntity", "Amount", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)BillingFieldIndex.Amount, 0, 4, 19);
			this.AddElementFieldInfo("BillingEntity", "BillingId", typeof(System.Int32), true, false, true, false,  (int)BillingFieldIndex.BillingId, 0, 0, 10);
			this.AddElementFieldInfo("BillingEntity", "Date", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)BillingFieldIndex.Date, 0, 0, 0);
			this.AddElementFieldInfo("BillingEntity", "Description", typeof(System.String), false, false, false, true,  (int)BillingFieldIndex.Description, 1024, 0, 0);
			this.AddElementFieldInfo("BillingEntity", "JobId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)BillingFieldIndex.JobId, 0, 0, 10);
		}
		/// <summary>Inits DamageEntity's FieldInfo objects</summary>
		private void InitDamageEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(DamageFieldIndex), "DamageEntity");
			this.AddElementFieldInfo("DamageEntity", "Active", typeof(System.Boolean), false, false, false, false,  (int)DamageFieldIndex.Active, 0, 0, 0);
			this.AddElementFieldInfo("DamageEntity", "DamageId", typeof(System.Int32), true, false, true, false,  (int)DamageFieldIndex.DamageId, 0, 0, 10);
			this.AddElementFieldInfo("DamageEntity", "Description", typeof(System.String), false, false, false, true,  (int)DamageFieldIndex.Description, 1024, 0, 0);
			this.AddElementFieldInfo("DamageEntity", "Name", typeof(System.String), false, false, false, true,  (int)DamageFieldIndex.Name, 50, 0, 0);
		}
		/// <summary>Inits ExpenseEntity's FieldInfo objects</summary>
		private void InitExpenseEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ExpenseFieldIndex), "ExpenseEntity");
			this.AddElementFieldInfo("ExpenseEntity", "Description", typeof(System.String), false, false, false, true,  (int)ExpenseFieldIndex.Description, 1024, 0, 0);
			this.AddElementFieldInfo("ExpenseEntity", "ExpenseId", typeof(System.Int32), true, false, true, false,  (int)ExpenseFieldIndex.ExpenseId, 0, 0, 10);
			this.AddElementFieldInfo("ExpenseEntity", "ExternalInvoice", typeof(System.String), false, false, false, true,  (int)ExpenseFieldIndex.ExternalInvoice, 50, 0, 0);
			this.AddElementFieldInfo("ExpenseEntity", "InvoiceDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)ExpenseFieldIndex.InvoiceDate, 0, 0, 0);
			this.AddElementFieldInfo("ExpenseEntity", "JobId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)ExpenseFieldIndex.JobId, 0, 0, 10);
			this.AddElementFieldInfo("ExpenseEntity", "LaborCost", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)ExpenseFieldIndex.LaborCost, 0, 4, 19);
			this.AddElementFieldInfo("ExpenseEntity", "LaborHours", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)ExpenseFieldIndex.LaborHours, 0, 4, 19);
			this.AddElementFieldInfo("ExpenseEntity", "LaborRate", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)ExpenseFieldIndex.LaborRate, 0, 4, 19);
			this.AddElementFieldInfo("ExpenseEntity", "MaterialCost", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)ExpenseFieldIndex.MaterialCost, 0, 4, 19);
			this.AddElementFieldInfo("ExpenseEntity", "TotalCost", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)ExpenseFieldIndex.TotalCost, 0, 4, 19);
			this.AddElementFieldInfo("ExpenseEntity", "VendorId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)ExpenseFieldIndex.VendorId, 0, 0, 10);
		}
		/// <summary>Inits GroupEntity's FieldInfo objects</summary>
		private void InitGroupEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(GroupFieldIndex), "GroupEntity");
			this.AddElementFieldInfo("GroupEntity", "Active", typeof(System.Boolean), false, false, false, false,  (int)GroupFieldIndex.Active, 0, 0, 0);
			this.AddElementFieldInfo("GroupEntity", "Description", typeof(System.String), false, false, false, true,  (int)GroupFieldIndex.Description, 1024, 0, 0);
			this.AddElementFieldInfo("GroupEntity", "GroupId", typeof(System.Int32), true, false, true, false,  (int)GroupFieldIndex.GroupId, 0, 0, 10);
			this.AddElementFieldInfo("GroupEntity", "Name", typeof(System.String), false, false, false, false,  (int)GroupFieldIndex.Name, 50, 0, 0);
		}
		/// <summary>Inits JobEntity's FieldInfo objects</summary>
		private void InitJobEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(JobFieldIndex), "JobEntity");
			this.AddElementFieldInfo("JobEntity", "Address1", typeof(System.String), false, false, false, true,  (int)JobFieldIndex.Address1, 50, 0, 0);
			this.AddElementFieldInfo("JobEntity", "Address2", typeof(System.String), false, false, false, true,  (int)JobFieldIndex.Address2, 50, 0, 0);
			this.AddElementFieldInfo("JobEntity", "City", typeof(System.String), false, false, false, true,  (int)JobFieldIndex.City, 50, 0, 0);
			this.AddElementFieldInfo("JobEntity", "ContractedAmount", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)JobFieldIndex.ContractedAmount, 0, 4, 19);
			this.AddElementFieldInfo("JobEntity", "DamageId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)JobFieldIndex.DamageId, 0, 0, 10);
			this.AddElementFieldInfo("JobEntity", "Description", typeof(System.String), false, false, false, true,  (int)JobFieldIndex.Description, 1024, 0, 0);
			this.AddElementFieldInfo("JobEntity", "EndDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)JobFieldIndex.EndDate, 0, 0, 0);
			this.AddElementFieldInfo("JobEntity", "EstimatorId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)JobFieldIndex.EstimatorId, 0, 0, 10);
			this.AddElementFieldInfo("JobEntity", "GroupId", typeof(System.Int32), false, true, false, false,  (int)JobFieldIndex.GroupId, 0, 0, 10);
			this.AddElementFieldInfo("JobEntity", "IsAging", typeof(System.Boolean), false, false, false, false,  (int)JobFieldIndex.IsAging, 0, 0, 0);
			this.AddElementFieldInfo("JobEntity", "JobId", typeof(System.Int32), true, false, true, false,  (int)JobFieldIndex.JobId, 0, 0, 10);
			this.AddElementFieldInfo("JobEntity", "Name", typeof(System.String), false, false, false, true,  (int)JobFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("JobEntity", "Overhead", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)JobFieldIndex.Overhead, 0, 4, 19);
			this.AddElementFieldInfo("JobEntity", "PercentDone", typeof(System.Decimal), false, false, false, false,  (int)JobFieldIndex.PercentDone, 0, 4, 19);
			this.AddElementFieldInfo("JobEntity", "StartDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)JobFieldIndex.StartDate, 0, 0, 0);
			this.AddElementFieldInfo("JobEntity", "State", typeof(System.String), false, false, false, true,  (int)JobFieldIndex.State, 50, 0, 0);
			this.AddElementFieldInfo("JobEntity", "StatusId", typeof(System.Int32), false, true, false, false,  (int)JobFieldIndex.StatusId, 0, 0, 10);
			this.AddElementFieldInfo("JobEntity", "UpdateDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)JobFieldIndex.UpdateDate, 0, 0, 0);
			this.AddElementFieldInfo("JobEntity", "Zip", typeof(System.String), false, false, false, true,  (int)JobFieldIndex.Zip, 50, 0, 0);
		}
		/// <summary>Inits PaymentEntity's FieldInfo objects</summary>
		private void InitPaymentEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(PaymentFieldIndex), "PaymentEntity");
			this.AddElementFieldInfo("PaymentEntity", "Amount", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)PaymentFieldIndex.Amount, 0, 4, 19);
			this.AddElementFieldInfo("PaymentEntity", "Date", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)PaymentFieldIndex.Date, 0, 0, 0);
			this.AddElementFieldInfo("PaymentEntity", "Description", typeof(System.String), false, false, false, true,  (int)PaymentFieldIndex.Description, 1024, 0, 0);
			this.AddElementFieldInfo("PaymentEntity", "JobId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)PaymentFieldIndex.JobId, 0, 0, 10);
			this.AddElementFieldInfo("PaymentEntity", "PaymentId", typeof(System.Int32), true, false, true, false,  (int)PaymentFieldIndex.PaymentId, 0, 0, 10);
		}
		/// <summary>Inits PersonEntity's FieldInfo objects</summary>
		private void InitPersonEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(PersonFieldIndex), "PersonEntity");
			this.AddElementFieldInfo("PersonEntity", "Active", typeof(System.Boolean), false, false, false, false,  (int)PersonFieldIndex.Active, 0, 0, 0);
			this.AddElementFieldInfo("PersonEntity", "Description", typeof(System.String), false, false, false, true,  (int)PersonFieldIndex.Description, 1024, 0, 0);
			this.AddElementFieldInfo("PersonEntity", "FirstName", typeof(System.String), false, false, false, true,  (int)PersonFieldIndex.FirstName, 50, 0, 0);
			this.AddElementFieldInfo("PersonEntity", "LastName", typeof(System.String), false, false, false, true,  (int)PersonFieldIndex.LastName, 50, 0, 0);
			this.AddElementFieldInfo("PersonEntity", "Password", typeof(System.String), false, false, false, true,  (int)PersonFieldIndex.Password, 50, 0, 0);
			this.AddElementFieldInfo("PersonEntity", "PersonId", typeof(System.Int32), true, false, true, false,  (int)PersonFieldIndex.PersonId, 0, 0, 10);
			this.AddElementFieldInfo("PersonEntity", "RoleId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)PersonFieldIndex.RoleId, 0, 0, 10);
			this.AddElementFieldInfo("PersonEntity", "Username", typeof(System.String), false, false, false, true,  (int)PersonFieldIndex.Username, 50, 0, 0);
		}
		/// <summary>Inits RoleEntity's FieldInfo objects</summary>
		private void InitRoleEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(RoleFieldIndex), "RoleEntity");
			this.AddElementFieldInfo("RoleEntity", "Active", typeof(System.Boolean), false, false, false, false,  (int)RoleFieldIndex.Active, 0, 0, 0);
			this.AddElementFieldInfo("RoleEntity", "Description", typeof(System.String), false, false, false, true,  (int)RoleFieldIndex.Description, 1024, 0, 0);
			this.AddElementFieldInfo("RoleEntity", "Name", typeof(System.String), false, false, false, true,  (int)RoleFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("RoleEntity", "RoleId", typeof(System.Int32), true, false, true, false,  (int)RoleFieldIndex.RoleId, 0, 0, 10);
		}
		/// <summary>Inits SettingEntity's FieldInfo objects</summary>
		private void InitSettingEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SettingFieldIndex), "SettingEntity");
			this.AddElementFieldInfo("SettingEntity", "DbVersion", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)SettingFieldIndex.DbVersion, 0, 4, 19);
			this.AddElementFieldInfo("SettingEntity", "SettingsId", typeof(System.Int32), true, false, true, false,  (int)SettingFieldIndex.SettingsId, 0, 0, 10);
			this.AddElementFieldInfo("SettingEntity", "Xml", typeof(System.String), false, false, false, true,  (int)SettingFieldIndex.Xml, 2048, 0, 0);
		}
		/// <summary>Inits StatusEntity's FieldInfo objects</summary>
		private void InitStatusEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(StatusFieldIndex), "StatusEntity");
			this.AddElementFieldInfo("StatusEntity", "Active", typeof(System.Boolean), false, false, false, false,  (int)StatusFieldIndex.Active, 0, 0, 0);
			this.AddElementFieldInfo("StatusEntity", "Description", typeof(System.String), false, false, false, true,  (int)StatusFieldIndex.Description, 1024, 0, 0);
			this.AddElementFieldInfo("StatusEntity", "Name", typeof(System.String), false, false, false, true,  (int)StatusFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("StatusEntity", "StatusId", typeof(System.Int32), true, false, true, false,  (int)StatusFieldIndex.StatusId, 0, 0, 10);
		}
		/// <summary>Inits VendorEntity's FieldInfo objects</summary>
		private void InitVendorEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(VendorFieldIndex), "VendorEntity");
			this.AddElementFieldInfo("VendorEntity", "Active", typeof(System.Boolean), false, false, false, false,  (int)VendorFieldIndex.Active, 0, 0, 0);
			this.AddElementFieldInfo("VendorEntity", "Description", typeof(System.String), false, false, false, true,  (int)VendorFieldIndex.Description, 1024, 0, 0);
			this.AddElementFieldInfo("VendorEntity", "Name", typeof(System.String), false, false, false, true,  (int)VendorFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("VendorEntity", "VendorId", typeof(System.Int32), true, false, true, false,  (int)VendorFieldIndex.VendorId, 0, 0, 10);
		}
		
	}
}




