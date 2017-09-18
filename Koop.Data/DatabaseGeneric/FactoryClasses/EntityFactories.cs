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
using System.Collections.Generic;
using Koop.Data.EntityClasses;
using Koop.Data.HelperClasses;
using Koop.Data.RelationClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Koop.Data.FactoryClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	
	/// <summary>general base class for the generated factories</summary>
	[Serializable]
	public partial class EntityFactoryBase2<TEntity> : EntityFactoryCore2
		where TEntity : EntityBase2, IEntity2
	{
		private readonly Koop.Data.EntityType _typeOfEntity;
		private readonly bool _isInHierarchy;
		
		/// <summary>CTor</summary>
		/// <param name="entityName">Name of the entity.</param>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <param name="isInHierarchy">If true, the entity of this factory is in an inheritance hierarchy, false otherwise</param>
		public EntityFactoryBase2(string entityName, Koop.Data.EntityType typeOfEntity, bool isInHierarchy) : base(entityName)
		{
			_typeOfEntity = typeOfEntity;
			_isInHierarchy = isInHierarchy;
		}
		
		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields2 object for the entity to create.</summary>
		/// <returns>Empty IEntityFields2 object.</returns>
		public override IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(_typeOfEntity);
		}
		
		/// <summary>Creates a new entity instance using the GeneralEntityFactory in the generated code, using the passed in entitytype value</summary>
		/// <param name="entityTypeValue">The entity type value of the entity to create an instance for.</param>
		/// <returns>new IEntity instance</returns>
		public override IEntity2 CreateEntityFromEntityTypeValue(int entityTypeValue)
		{
			return GeneralEntityFactory.Create((Koop.Data.EntityType)entityTypeValue);
		}

		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <param name="objectAlias">The object alias to use for the elements in the relations.</param>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public override IRelationCollection CreateHierarchyRelations(string objectAlias) 
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetHierarchyRelations(this.ForEntityName, objectAlias);
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public override IEntityFactory2 GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity) 
		{
			IEntityFactory2 toReturn = (IEntityFactory2)InheritanceInfoProviderSingleton.GetInstance().GetEntityFactory(this.ForEntityName, fieldValues, entityFieldStartIndexesPerEntity);
			if(toReturn == null)
			{
				toReturn = this;
			}
			return toReturn;
		}
		
		/// <summary>Gets a predicateexpression which filters on the entity with type belonging to this factory.</summary>
		/// <param name="negate">Flag to produce a NOT filter, (true), or a normal filter (false). </param>
		/// <param name="objectAlias">The object alias to use for the predicate(s).</param>
		/// <returns>ready to use predicateexpression, or an empty predicate expression if the belonging entity isn't a hierarchical type.</returns>
		public override IPredicateExpression GetEntityTypeFilter(bool negate, string objectAlias) 
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetEntityTypeFilter(this.ForEntityName, objectAlias, negate);
		}
						
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity which this factory belongs to.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<TEntity>(this);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields2 object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public override IEntityFields2 CreateHierarchyFields() 
		{
			return _isInHierarchy ? new EntityFields2(InheritanceInfoProviderSingleton.GetInstance().GetHierarchyFields(this.ForEntityName), InheritanceInfoProviderSingleton.GetInstance(), null) : base.CreateHierarchyFields();
		}
	}

	/// <summary>Factory to create new, empty BillingEntity objects.</summary>
	[Serializable]
	public partial class BillingEntityFactory : EntityFactoryBase2<BillingEntity> {
		/// <summary>CTor</summary>
		public BillingEntityFactory() : base("BillingEntity", Koop.Data.EntityType.BillingEntity, false) { }
		
		/// <summary>Creates a new BillingEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new BillingEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewBillingUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty DamageEntity objects.</summary>
	[Serializable]
	public partial class DamageEntityFactory : EntityFactoryBase2<DamageEntity> {
		/// <summary>CTor</summary>
		public DamageEntityFactory() : base("DamageEntity", Koop.Data.EntityType.DamageEntity, false) { }
		
		/// <summary>Creates a new DamageEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new DamageEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDamageUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty ExpenseEntity objects.</summary>
	[Serializable]
	public partial class ExpenseEntityFactory : EntityFactoryBase2<ExpenseEntity> {
		/// <summary>CTor</summary>
		public ExpenseEntityFactory() : base("ExpenseEntity", Koop.Data.EntityType.ExpenseEntity, false) { }
		
		/// <summary>Creates a new ExpenseEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ExpenseEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewExpenseUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty GroupEntity objects.</summary>
	[Serializable]
	public partial class GroupEntityFactory : EntityFactoryBase2<GroupEntity> {
		/// <summary>CTor</summary>
		public GroupEntityFactory() : base("GroupEntity", Koop.Data.EntityType.GroupEntity, false) { }
		
		/// <summary>Creates a new GroupEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new GroupEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewGroupUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty JobEntity objects.</summary>
	[Serializable]
	public partial class JobEntityFactory : EntityFactoryBase2<JobEntity> {
		/// <summary>CTor</summary>
		public JobEntityFactory() : base("JobEntity", Koop.Data.EntityType.JobEntity, false) { }
		
		/// <summary>Creates a new JobEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new JobEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewJobUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty PaymentEntity objects.</summary>
	[Serializable]
	public partial class PaymentEntityFactory : EntityFactoryBase2<PaymentEntity> {
		/// <summary>CTor</summary>
		public PaymentEntityFactory() : base("PaymentEntity", Koop.Data.EntityType.PaymentEntity, false) { }
		
		/// <summary>Creates a new PaymentEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new PaymentEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPaymentUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty PersonEntity objects.</summary>
	[Serializable]
	public partial class PersonEntityFactory : EntityFactoryBase2<PersonEntity> {
		/// <summary>CTor</summary>
		public PersonEntityFactory() : base("PersonEntity", Koop.Data.EntityType.PersonEntity, false) { }
		
		/// <summary>Creates a new PersonEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new PersonEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPersonUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty RoleEntity objects.</summary>
	[Serializable]
	public partial class RoleEntityFactory : EntityFactoryBase2<RoleEntity> {
		/// <summary>CTor</summary>
		public RoleEntityFactory() : base("RoleEntity", Koop.Data.EntityType.RoleEntity, false) { }
		
		/// <summary>Creates a new RoleEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new RoleEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewRoleUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SettingEntity objects.</summary>
	[Serializable]
	public partial class SettingEntityFactory : EntityFactoryBase2<SettingEntity> {
		/// <summary>CTor</summary>
		public SettingEntityFactory() : base("SettingEntity", Koop.Data.EntityType.SettingEntity, false) { }
		
		/// <summary>Creates a new SettingEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SettingEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSettingUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty StatusEntity objects.</summary>
	[Serializable]
	public partial class StatusEntityFactory : EntityFactoryBase2<StatusEntity> {
		/// <summary>CTor</summary>
		public StatusEntityFactory() : base("StatusEntity", Koop.Data.EntityType.StatusEntity, false) { }
		
		/// <summary>Creates a new StatusEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new StatusEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewStatusUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty VendorEntity objects.</summary>
	[Serializable]
	public partial class VendorEntityFactory : EntityFactoryBase2<VendorEntity> {
		/// <summary>CTor</summary>
		public VendorEntityFactory() : base("VendorEntity", Koop.Data.EntityType.VendorEntity, false) { }
		
		/// <summary>Creates a new VendorEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new VendorEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewVendorUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty Entity objects based on the entity type specified. Uses  entity specific factory objects</summary>
	[Serializable]
	public partial class GeneralEntityFactory
	{
		/// <summary>Creates a new, empty Entity object of the type specified</summary>
		/// <param name="entityTypeToCreate">The entity type to create.</param>
		/// <returns>A new, empty Entity object.</returns>
		public static IEntity2 Create(Koop.Data.EntityType entityTypeToCreate)
		{
			IEntityFactory2 factoryToUse = null;
			switch(entityTypeToCreate)
			{
				case Koop.Data.EntityType.BillingEntity:
					factoryToUse = new BillingEntityFactory();
					break;
				case Koop.Data.EntityType.DamageEntity:
					factoryToUse = new DamageEntityFactory();
					break;
				case Koop.Data.EntityType.ExpenseEntity:
					factoryToUse = new ExpenseEntityFactory();
					break;
				case Koop.Data.EntityType.GroupEntity:
					factoryToUse = new GroupEntityFactory();
					break;
				case Koop.Data.EntityType.JobEntity:
					factoryToUse = new JobEntityFactory();
					break;
				case Koop.Data.EntityType.PaymentEntity:
					factoryToUse = new PaymentEntityFactory();
					break;
				case Koop.Data.EntityType.PersonEntity:
					factoryToUse = new PersonEntityFactory();
					break;
				case Koop.Data.EntityType.RoleEntity:
					factoryToUse = new RoleEntityFactory();
					break;
				case Koop.Data.EntityType.SettingEntity:
					factoryToUse = new SettingEntityFactory();
					break;
				case Koop.Data.EntityType.StatusEntity:
					factoryToUse = new StatusEntityFactory();
					break;
				case Koop.Data.EntityType.VendorEntity:
					factoryToUse = new VendorEntityFactory();
					break;
			}
			IEntity2 toReturn = null;
			if(factoryToUse != null)
			{
				toReturn = factoryToUse.Create();
			}
			return toReturn;
		}		
	}
		
	/// <summary>Class which is used to obtain the entity factory based on the .NET type of the entity. </summary>
	[Serializable]
	public static class EntityFactoryFactory
	{
		private static Dictionary<Type, IEntityFactory2> _factoryPerType = new Dictionary<Type, IEntityFactory2>();

		/// <summary>Initializes the <see cref="EntityFactoryFactory"/> class.</summary>
		static EntityFactoryFactory()
		{
			Array entityTypeValues = Enum.GetValues(typeof(Koop.Data.EntityType));
			foreach(int entityTypeValue in entityTypeValues)
			{
				IEntity2 dummy = GeneralEntityFactory.Create((Koop.Data.EntityType)entityTypeValue);
				_factoryPerType.Add(dummy.GetType(), dummy.GetEntityFactory());
			}
		}

		/// <summary>Gets the factory of the entity with the .NET type specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory2 GetFactory(Type typeOfEntity)
		{
			IEntityFactory2 toReturn = null;
			_factoryPerType.TryGetValue(typeOfEntity, out toReturn);
			return toReturn;
		}

		/// <summary>Gets the factory of the entity with the Koop.Data.EntityType specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory2 GetFactory(Koop.Data.EntityType typeOfEntity)
		{
			return GetFactory(GeneralEntityFactory.Create(typeOfEntity).GetType());
		}
	}
		
	/// <summary>Element creator for creating project elements from somewhere else, like inside Linq providers.</summary>
	public class ElementCreator : ElementCreatorBase, IElementCreator2
	{
		/// <summary>Gets the factory of the Entity type with the Koop.Data.EntityType value passed in</summary>
		/// <param name="entityTypeValue">The entity type value.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory2 GetFactory(int entityTypeValue)
		{
			return (IEntityFactory2)this.GetFactoryImpl(entityTypeValue);
		}
		
		/// <summary>Gets the factory of the Entity type with the .NET type passed in</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory2 GetFactory(Type typeOfEntity)
		{
			return (IEntityFactory2)this.GetFactoryImpl(typeOfEntity);
		}

		/// <summary>Creates a new resultset fields object with the number of field slots reserved as specified</summary>
		/// <param name="numberOfFields">The number of fields.</param>
		/// <returns>ready to use resultsetfields object</returns>
		public IEntityFields2 CreateResultsetFields(int numberOfFields)
		{
			return new ResultsetFields(numberOfFields);
		}
		
		/// <summary>Obtains the inheritance info provider instance from the singleton </summary>
		/// <returns>The singleton instance of the inheritance info provider</returns>
		public override IInheritanceInfoProvider ObtainInheritanceInfoProviderInstance()
		{
			return InheritanceInfoProviderSingleton.GetInstance();
		}


		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand)
		{
			return new DynamicRelation(leftOperand);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperand">The right operand.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, DerivedTableDefinition rightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, rightOperand, onClause);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperand">The right operand.</param>
		/// <param name="aliasLeftOperand">The alias of the left operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(IEntityFieldCore leftOperand, JoinHint joinType, DerivedTableDefinition rightOperand, string aliasLeftOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, rightOperand, aliasLeftOperand, onClause);
		}


		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperandEntityName">Name of the entity, which is used as the right operand.</param>
		/// <param name="aliasRightOperand">The alias of the right operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, string rightOperandEntityName, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, (Koop.Data.EntityType)Enum.Parse(typeof(Koop.Data.EntityType), rightOperandEntityName, false), aliasRightOperand, onClause);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperandEntityName">Name of the entity which is used as the left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperandEntityName">Name of the entity, which is used as the right operand.</param>
		/// <param name="aliasLeftOperand">The alias of the left operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="aliasRightOperand">The alias of the right operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(string leftOperandEntityName, JoinHint joinType, string rightOperandEntityName, string aliasLeftOperand, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation((Koop.Data.EntityType)Enum.Parse(typeof(Koop.Data.EntityType), leftOperandEntityName, false), joinType, (Koop.Data.EntityType)Enum.Parse(typeof(Koop.Data.EntityType), rightOperandEntityName, false), aliasLeftOperand, aliasRightOperand, onClause);
		}
		
		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperandEntityName">Name of the entity, which is used as the right operand.</param>
		/// <param name="aliasLeftOperand">The alias of the left operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="aliasRightOperand">The alias of the right operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(IEntityFieldCore leftOperand, JoinHint joinType, string rightOperandEntityName, string aliasLeftOperand, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, (Koop.Data.EntityType)Enum.Parse(typeof(Koop.Data.EntityType), rightOperandEntityName, false), aliasLeftOperand, aliasRightOperand, onClause);
		}
		
		/// <summary>Implementation of the routine which gets the factory of the Entity type with the Koop.Data.EntityType value passed in</summary>
		/// <param name="entityTypeValue">The entity type value.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		protected override IEntityFactoryCore GetFactoryImpl(int entityTypeValue)
		{
			return EntityFactoryFactory.GetFactory((Koop.Data.EntityType)entityTypeValue);
		}

		/// <summary>Implementation of the routine which gets the factory of the Entity type with the .NET type passed in</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		protected override IEntityFactoryCore GetFactoryImpl(Type typeOfEntity)
		{
			return EntityFactoryFactory.GetFactory(typeOfEntity);
		}

	}
}
