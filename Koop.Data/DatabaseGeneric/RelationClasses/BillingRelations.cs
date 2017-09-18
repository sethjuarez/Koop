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
	/// <summary>Implements the relations factory for the entity: Billing. </summary>
	public partial class BillingRelations
	{
		/// <summary>CTor</summary>
		public BillingRelations()
		{
		}

		/// <summary>Gets all relations of the BillingEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.JobEntityUsingJobId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between BillingEntity and JobEntity over the m:1 relation they have, using the relation between the fields:
		/// Billing.JobId - Job.JobId
		/// </summary>
		public virtual IEntityRelation JobEntityUsingJobId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Job", false);
				relation.AddEntityFieldPair(JobFields.JobId, BillingFields.JobId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("JobEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BillingEntity", true);
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
	internal static class StaticBillingRelations
	{
		internal static readonly IEntityRelation JobEntityUsingJobIdStatic = new BillingRelations().JobEntityUsingJobId;

		/// <summary>CTor</summary>
		static StaticBillingRelations()
		{
		}
	}
}
