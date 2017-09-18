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
	/// <summary>Implements the relations factory for the entity: Role. </summary>
	public partial class RoleRelations
	{
		/// <summary>CTor</summary>
		public RoleRelations()
		{
		}

		/// <summary>Gets all relations of the RoleEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.PersonEntityUsingRoleId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between RoleEntity and PersonEntity over the 1:n relation they have, using the relation between the fields:
		/// Role.RoleId - Person.RoleId
		/// </summary>
		public virtual IEntityRelation PersonEntityUsingRoleId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "People" , true);
				relation.AddEntityFieldPair(RoleFields.RoleId, PersonFields.RoleId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RoleEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PersonEntity", false);
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
	internal static class StaticRoleRelations
	{
		internal static readonly IEntityRelation PersonEntityUsingRoleIdStatic = new RoleRelations().PersonEntityUsingRoleId;

		/// <summary>CTor</summary>
		static StaticRoleRelations()
		{
		}
	}
}
