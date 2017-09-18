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

namespace Koop.Data
{
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Billing.</summary>
	public enum BillingFieldIndex
	{
		///<summary>Amount. </summary>
		Amount,
		///<summary>BillingId. </summary>
		BillingId,
		///<summary>Date. </summary>
		Date,
		///<summary>Description. </summary>
		Description,
		///<summary>JobId. </summary>
		JobId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Damage.</summary>
	public enum DamageFieldIndex
	{
		///<summary>Active. </summary>
		Active,
		///<summary>DamageId. </summary>
		DamageId,
		///<summary>Description. </summary>
		Description,
		///<summary>Name. </summary>
		Name,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Expense.</summary>
	public enum ExpenseFieldIndex
	{
		///<summary>Description. </summary>
		Description,
		///<summary>ExpenseId. </summary>
		ExpenseId,
		///<summary>ExternalInvoice. </summary>
		ExternalInvoice,
		///<summary>InvoiceDate. </summary>
		InvoiceDate,
		///<summary>JobId. </summary>
		JobId,
		///<summary>LaborCost. </summary>
		LaborCost,
		///<summary>LaborHours. </summary>
		LaborHours,
		///<summary>LaborRate. </summary>
		LaborRate,
		///<summary>MaterialCost. </summary>
		MaterialCost,
		///<summary>TotalCost. </summary>
		TotalCost,
		///<summary>VendorId. </summary>
		VendorId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Group.</summary>
	public enum GroupFieldIndex
	{
		///<summary>Active. </summary>
		Active,
		///<summary>Description. </summary>
		Description,
		///<summary>GroupId. </summary>
		GroupId,
		///<summary>Name. </summary>
		Name,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Job.</summary>
	public enum JobFieldIndex
	{
		///<summary>Address1. </summary>
		Address1,
		///<summary>Address2. </summary>
		Address2,
		///<summary>City. </summary>
		City,
		///<summary>ContractedAmount. </summary>
		ContractedAmount,
		///<summary>DamageId. </summary>
		DamageId,
		///<summary>Description. </summary>
		Description,
		///<summary>EndDate. </summary>
		EndDate,
		///<summary>EstimatorId. </summary>
		EstimatorId,
		///<summary>GroupId. </summary>
		GroupId,
		///<summary>IsAging. </summary>
		IsAging,
		///<summary>JobId. </summary>
		JobId,
		///<summary>Name. </summary>
		Name,
		///<summary>Overhead. </summary>
		Overhead,
		///<summary>PercentDone. </summary>
		PercentDone,
		///<summary>StartDate. </summary>
		StartDate,
		///<summary>State. </summary>
		State,
		///<summary>StatusId. </summary>
		StatusId,
		///<summary>UpdateDate. </summary>
		UpdateDate,
		///<summary>Zip. </summary>
		Zip,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Payment.</summary>
	public enum PaymentFieldIndex
	{
		///<summary>Amount. </summary>
		Amount,
		///<summary>Date. </summary>
		Date,
		///<summary>Description. </summary>
		Description,
		///<summary>JobId. </summary>
		JobId,
		///<summary>PaymentId. </summary>
		PaymentId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Person.</summary>
	public enum PersonFieldIndex
	{
		///<summary>Active. </summary>
		Active,
		///<summary>Description. </summary>
		Description,
		///<summary>FirstName. </summary>
		FirstName,
		///<summary>LastName. </summary>
		LastName,
		///<summary>Password. </summary>
		Password,
		///<summary>PersonId. </summary>
		PersonId,
		///<summary>RoleId. </summary>
		RoleId,
		///<summary>Username. </summary>
		Username,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Role.</summary>
	public enum RoleFieldIndex
	{
		///<summary>Active. </summary>
		Active,
		///<summary>Description. </summary>
		Description,
		///<summary>Name. </summary>
		Name,
		///<summary>RoleId. </summary>
		RoleId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Setting.</summary>
	public enum SettingFieldIndex
	{
		///<summary>DbVersion. </summary>
		DbVersion,
		///<summary>SettingsId. </summary>
		SettingsId,
		///<summary>Xml. </summary>
		Xml,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Status.</summary>
	public enum StatusFieldIndex
	{
		///<summary>Active. </summary>
		Active,
		///<summary>Description. </summary>
		Description,
		///<summary>Name. </summary>
		Name,
		///<summary>StatusId. </summary>
		StatusId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Vendor.</summary>
	public enum VendorFieldIndex
	{
		///<summary>Active. </summary>
		Active,
		///<summary>Description. </summary>
		Description,
		///<summary>Name. </summary>
		Name,
		///<summary>VendorId. </summary>
		VendorId,
		/// <summary></summary>
		AmountOfFields
	}



	/// <summary>Enum definition for all the entity types defined in this namespace. Used by the entityfields factory.</summary>
	public enum EntityType
	{
		///<summary>Billing</summary>
		BillingEntity,
		///<summary>Damage</summary>
		DamageEntity,
		///<summary>Expense</summary>
		ExpenseEntity,
		///<summary>Group</summary>
		GroupEntity,
		///<summary>Job</summary>
		JobEntity,
		///<summary>Payment</summary>
		PaymentEntity,
		///<summary>Person</summary>
		PersonEntity,
		///<summary>Role</summary>
		RoleEntity,
		///<summary>Setting</summary>
		SettingEntity,
		///<summary>Status</summary>
		StatusEntity,
		///<summary>Vendor</summary>
		VendorEntity
	}


	#region Custom ConstantsEnums Code
	
	// __LLBLGENPRO_USER_CODE_REGION_START CustomUserConstants
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	#endregion

	#region Included code

	#endregion
}

