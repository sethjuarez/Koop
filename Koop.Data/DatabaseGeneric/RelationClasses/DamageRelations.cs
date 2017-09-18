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
	/// <summary>Implements the relations factory for the entity: Damage. </summary>
	public partial class DamageRelations
	{
		/// <summary>CTor</summary>
		public DamageRelations()
		{
		}

		/// <summary>Gets all relations of the DamageEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.JobEntityUsingDamageId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between DamageEntity and JobEntity over the 1:n relation they have, using the relation between the fields:
		/// Damage.DamageId - Job.DamageId
		/// </summary>
		public virtual IEntityRelation JobEntityUsingDamageId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Jobs" , true);
				relation.AddEntityFieldPair(DamageFields.DamageId, JobFields.DamageId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DamageEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("JobEntity", false);
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
	internal static class StaticDamageRelations
	{
		internal static readonly IEntityRelation JobEntityUsingDamageIdStatic = new DamageRelations().JobEntityUsingDamageId;

		/// <summary>CTor</summary>
		static StaticDamageRelations()
		{
		}
	}
}
