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
	/// <summary>Implements the relations factory for the entity: Person. </summary>
	public partial class PersonRelations
	{
		/// <summary>CTor</summary>
		public PersonRelations()
		{
		}

		/// <summary>Gets all relations of the PersonEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.JobEntityUsingEstimatorId);
			toReturn.Add(this.RoleEntityUsingRoleId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between PersonEntity and JobEntity over the 1:n relation they have, using the relation between the fields:
		/// Person.PersonId - Job.EstimatorId
		/// </summary>
		public virtual IEntityRelation JobEntityUsingEstimatorId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Jobs" , true);
				relation.AddEntityFieldPair(PersonFields.PersonId, JobFields.EstimatorId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PersonEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("JobEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between PersonEntity and RoleEntity over the m:1 relation they have, using the relation between the fields:
		/// Person.RoleId - Role.RoleId
		/// </summary>
		public virtual IEntityRelation RoleEntityUsingRoleId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Role", false);
				relation.AddEntityFieldPair(RoleFields.RoleId, PersonFields.RoleId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RoleEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PersonEntity", true);
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
	internal static class StaticPersonRelations
	{
		internal static readonly IEntityRelation JobEntityUsingEstimatorIdStatic = new PersonRelations().JobEntityUsingEstimatorId;
		internal static readonly IEntityRelation RoleEntityUsingRoleIdStatic = new PersonRelations().RoleEntityUsingRoleId;

		/// <summary>CTor</summary>
		static StaticPersonRelations()
		{
		}
	}
}
