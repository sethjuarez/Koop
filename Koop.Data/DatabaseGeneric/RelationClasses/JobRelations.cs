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
using System.Collections;
using System.Collections.Generic;
using Koop.Data;
using Koop.Data.FactoryClasses;
using Koop.Data.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Koop.Data.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Job. </summary>
	public partial class JobRelations
	{
		/// <summary>CTor</summary>
		public JobRelations()
		{
		}

		/// <summary>Gets all relations of the JobEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.BillingEntityUsingJobId);
			toReturn.Add(this.ExpenseEntityUsingJobId);
			toReturn.Add(this.PaymentEntityUsingJobId);
			toReturn.Add(this.DamageEntityUsingDamageId);
			toReturn.Add(this.GroupEntityUsingGroupId);
			toReturn.Add(this.PersonEntityUsingEstimatorId);
			toReturn.Add(this.StatusEntityUsingStatusId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between JobEntity and BillingEntity over the 1:n relation they have, using the relation between the fields:
		/// Job.JobId - Billing.JobId
		/// </summary>
		public virtual IEntityRelation BillingEntityUsingJobId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Billings" , true);
				relation.AddEntityFieldPair(JobFields.JobId, BillingFields.JobId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("JobEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BillingEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between JobEntity and ExpenseEntity over the 1:n relation they have, using the relation between the fields:
		/// Job.JobId - Expense.JobId
		/// </summary>
		public virtual IEntityRelation ExpenseEntityUsingJobId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Expenses" , true);
				relation.AddEntityFieldPair(JobFields.JobId, ExpenseFields.JobId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("JobEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ExpenseEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between JobEntity and PaymentEntity over the 1:n relation they have, using the relation between the fields:
		/// Job.JobId - Payment.JobId
		/// </summary>
		public virtual IEntityRelation PaymentEntityUsingJobId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Payments" , true);
				relation.AddEntityFieldPair(JobFields.JobId, PaymentFields.JobId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("JobEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PaymentEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between JobEntity and DamageEntity over the m:1 relation they have, using the relation between the fields:
		/// Job.DamageId - Damage.DamageId
		/// </summary>
		public virtual IEntityRelation DamageEntityUsingDamageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Damage", false);
				relation.AddEntityFieldPair(DamageFields.DamageId, JobFields.DamageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DamageEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("JobEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between JobEntity and GroupEntity over the m:1 relation they have, using the relation between the fields:
		/// Job.GroupId - Group.GroupId
		/// </summary>
		public virtual IEntityRelation GroupEntityUsingGroupId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Group", false);
				relation.AddEntityFieldPair(GroupFields.GroupId, JobFields.GroupId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("GroupEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("JobEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between JobEntity and PersonEntity over the m:1 relation they have, using the relation between the fields:
		/// Job.EstimatorId - Person.PersonId
		/// </summary>
		public virtual IEntityRelation PersonEntityUsingEstimatorId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Person", false);
				relation.AddEntityFieldPair(PersonFields.PersonId, JobFields.EstimatorId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PersonEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("JobEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between JobEntity and StatusEntity over the m:1 relation they have, using the relation between the fields:
		/// Job.StatusId - Status.StatusId
		/// </summary>
		public virtual IEntityRelation StatusEntityUsingStatusId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Status", false);
				relation.AddEntityFieldPair(StatusFields.StatusId, JobFields.StatusId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StatusEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("JobEntity", true);
				return relation;
			}
		}
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName) { return null; }
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSuperTypeRelation() { return null;}
		#endregion

		#region Included Code

		#endregion
	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticJobRelations
	{
		internal static readonly IEntityRelation BillingEntityUsingJobIdStatic = new JobRelations().BillingEntityUsingJobId;
		internal static readonly IEntityRelation ExpenseEntityUsingJobIdStatic = new JobRelations().ExpenseEntityUsingJobId;
		internal static readonly IEntityRelation PaymentEntityUsingJobIdStatic = new JobRelations().PaymentEntityUsingJobId;
		internal static readonly IEntityRelation DamageEntityUsingDamageIdStatic = new JobRelations().DamageEntityUsingDamageId;
		internal static readonly IEntityRelation GroupEntityUsingGroupIdStatic = new JobRelations().GroupEntityUsingGroupId;
		internal static readonly IEntityRelation PersonEntityUsingEstimatorIdStatic = new JobRelations().PersonEntityUsingEstimatorId;
		internal static readonly IEntityRelation StatusEntityUsingStatusIdStatic = new JobRelations().StatusEntityUsingStatusId;

		/// <summary>CTor</summary>
		static StaticJobRelations()
		{
		}
	}
}
