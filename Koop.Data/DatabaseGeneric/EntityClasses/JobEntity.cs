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
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Koop.Data;
using Koop.Data.HelperClasses;
using Koop.Data.FactoryClasses;
using Koop.Data.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Koop.Data.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>Entity class which represents the entity 'Job'.<br/><br/></summary>
	[Serializable]
	public partial class JobEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private EntityCollection<BillingEntity> _billings;
		private EntityCollection<ExpenseEntity> _expenses;
		private EntityCollection<PaymentEntity> _payments;
		private DamageEntity _damage;
		private GroupEntity _group;
		private PersonEntity _person;
		private StatusEntity _status;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Damage</summary>
			public static readonly string Damage = "Damage";
			/// <summary>Member name Group</summary>
			public static readonly string Group = "Group";
			/// <summary>Member name Person</summary>
			public static readonly string Person = "Person";
			/// <summary>Member name Status</summary>
			public static readonly string Status = "Status";
			/// <summary>Member name Billings</summary>
			public static readonly string Billings = "Billings";
			/// <summary>Member name Expenses</summary>
			public static readonly string Expenses = "Expenses";
			/// <summary>Member name Payments</summary>
			public static readonly string Payments = "Payments";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static JobEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public JobEntity():base("JobEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public JobEntity(IEntityFields2 fields):base("JobEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this JobEntity</param>
		public JobEntity(IValidator validator):base("JobEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="jobId">PK value for Job which data should be fetched into this Job object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public JobEntity(System.Int32 jobId):base("JobEntity")
		{
			InitClassEmpty(null, null);
			this.JobId = jobId;
		}

		/// <summary> CTor</summary>
		/// <param name="jobId">PK value for Job which data should be fetched into this Job object</param>
		/// <param name="validator">The custom validator object for this JobEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public JobEntity(System.Int32 jobId, IValidator validator):base("JobEntity")
		{
			InitClassEmpty(validator, null);
			this.JobId = jobId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected JobEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_billings = (EntityCollection<BillingEntity>)info.GetValue("_billings", typeof(EntityCollection<BillingEntity>));
				_expenses = (EntityCollection<ExpenseEntity>)info.GetValue("_expenses", typeof(EntityCollection<ExpenseEntity>));
				_payments = (EntityCollection<PaymentEntity>)info.GetValue("_payments", typeof(EntityCollection<PaymentEntity>));
				_damage = (DamageEntity)info.GetValue("_damage", typeof(DamageEntity));
				if(_damage!=null)
				{
					_damage.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_group = (GroupEntity)info.GetValue("_group", typeof(GroupEntity));
				if(_group!=null)
				{
					_group.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_person = (PersonEntity)info.GetValue("_person", typeof(PersonEntity));
				if(_person!=null)
				{
					_person.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_status = (StatusEntity)info.GetValue("_status", typeof(StatusEntity));
				if(_status!=null)
				{
					_status.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance());
			}
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((JobFieldIndex)fieldIndex)
			{
				case JobFieldIndex.DamageId:
					DesetupSyncDamage(true, false);
					break;
				case JobFieldIndex.EstimatorId:
					DesetupSyncPerson(true, false);
					break;
				case JobFieldIndex.GroupId:
					DesetupSyncGroup(true, false);
					break;
				case JobFieldIndex.StatusId:
					DesetupSyncStatus(true, false);
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		protected override void SetRelatedEntityProperty(string propertyName, IEntityCore entity)
		{
			switch(propertyName)
			{
				case "Damage":
					this.Damage = (DamageEntity)entity;
					break;
				case "Group":
					this.Group = (GroupEntity)entity;
					break;
				case "Person":
					this.Person = (PersonEntity)entity;
					break;
				case "Status":
					this.Status = (StatusEntity)entity;
					break;
				case "Billings":
					this.Billings.Add((BillingEntity)entity);
					break;
				case "Expenses":
					this.Expenses.Add((ExpenseEntity)entity);
					break;
				case "Payments":
					this.Payments.Add((PaymentEntity)entity);
					break;
				default:
					this.OnSetRelatedEntityProperty(propertyName, entity);
					break;
			}
		}
		
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		protected override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		internal static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "Damage":
					toReturn.Add(Relations.DamageEntityUsingDamageId);
					break;
				case "Group":
					toReturn.Add(Relations.GroupEntityUsingGroupId);
					break;
				case "Person":
					toReturn.Add(Relations.PersonEntityUsingEstimatorId);
					break;
				case "Status":
					toReturn.Add(Relations.StatusEntityUsingStatusId);
					break;
				case "Billings":
					toReturn.Add(Relations.BillingEntityUsingJobId);
					break;
				case "Expenses":
					toReturn.Add(Relations.ExpenseEntityUsingJobId);
					break;
				case "Payments":
					toReturn.Add(Relations.PaymentEntityUsingJobId);
					break;
				default:
					break;				
			}
			return toReturn;
		}

		/// <summary>Checks if the relation mapped by the property with the name specified is a one way / single sided relation. If the passed in name is null, it/ will return true if the entity has any single-sided relation</summary>
		/// <param name="propertyName">Name of the property which is mapped onto the relation to check, or null to check if the entity has any relation/ which is single sided</param>
		/// <returns>true if the relation is single sided / one way (so the opposite relation isn't present), false otherwise</returns>
		protected override bool CheckOneWayRelations(string propertyName)
		{
			int numberOfOneWayRelations = 0;
			switch(propertyName)
			{
				case null:
					return ((numberOfOneWayRelations > 0) || base.CheckOneWayRelations(null));
				default:
					return base.CheckOneWayRelations(propertyName);
			}
		}

		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		protected override void SetRelatedEntity(IEntityCore relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "Damage":
					SetupSyncDamage(relatedEntity);
					break;
				case "Group":
					SetupSyncGroup(relatedEntity);
					break;
				case "Person":
					SetupSyncPerson(relatedEntity);
					break;
				case "Status":
					SetupSyncStatus(relatedEntity);
					break;
				case "Billings":
					this.Billings.Add((BillingEntity)relatedEntity);
					break;
				case "Expenses":
					this.Expenses.Add((ExpenseEntity)relatedEntity);
					break;
				case "Payments":
					this.Payments.Add((PaymentEntity)relatedEntity);
					break;
				default:
					break;
			}
		}

		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		/// <param name="signalRelatedEntityManyToOne">if set to true it will notify the manytoone side, if applicable.</param>
		protected override void UnsetRelatedEntity(IEntityCore relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "Damage":
					DesetupSyncDamage(false, true);
					break;
				case "Group":
					DesetupSyncGroup(false, true);
					break;
				case "Person":
					DesetupSyncPerson(false, true);
					break;
				case "Status":
					DesetupSyncStatus(false, true);
					break;
				case "Billings":
					this.PerformRelatedEntityRemoval(this.Billings, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Expenses":
					this.PerformRelatedEntityRemoval(this.Expenses, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Payments":
					this.PerformRelatedEntityRemoval(this.Payments, relatedEntity, signalRelatedEntityManyToOne);
					break;
				default:
					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		protected override List<IEntity2> GetDependingRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();
			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		protected override List<IEntity2> GetDependentRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();
			if(_damage!=null)
			{
				toReturn.Add(_damage);
			}
			if(_group!=null)
			{
				toReturn.Add(_group);
			}
			if(_person!=null)
			{
				toReturn.Add(_person);
			}
			if(_status!=null)
			{
				toReturn.Add(_status);
			}
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.Billings);
			toReturn.Add(this.Expenses);
			toReturn.Add(this.Payments);
			return toReturn;
		}

		/// <summary>ISerializable member. Does custom serialization so event handlers do not get serialized. Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				info.AddValue("_billings", ((_billings!=null) && (_billings.Count>0) && !this.MarkedForDeletion)?_billings:null);
				info.AddValue("_expenses", ((_expenses!=null) && (_expenses.Count>0) && !this.MarkedForDeletion)?_expenses:null);
				info.AddValue("_payments", ((_payments!=null) && (_payments.Count>0) && !this.MarkedForDeletion)?_payments:null);
				info.AddValue("_damage", (!this.MarkedForDeletion?_damage:null));
				info.AddValue("_group", (!this.MarkedForDeletion?_group:null));
				info.AddValue("_person", (!this.MarkedForDeletion?_person:null));
				info.AddValue("_status", (!this.MarkedForDeletion?_status:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new JobRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Billing' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoBillings()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(BillingFields.JobId, null, ComparisonOperator.Equal, this.JobId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Expense' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoExpenses()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ExpenseFields.JobId, null, ComparisonOperator.Equal, this.JobId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Payment' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPayments()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PaymentFields.JobId, null, ComparisonOperator.Equal, this.JobId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Damage' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDamage()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(DamageFields.DamageId, null, ComparisonOperator.Equal, this.DamageId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Group' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoGroup()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(GroupFields.GroupId, null, ComparisonOperator.Equal, this.GroupId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Person' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPerson()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PersonFields.PersonId, null, ComparisonOperator.Equal, this.EstimatorId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Status' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoStatus()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(StatusFields.StatusId, null, ComparisonOperator.Equal, this.StatusId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(JobEntityFactory));
		}

		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._billings);
			collectionsQueue.Enqueue(this._expenses);
			collectionsQueue.Enqueue(this._payments);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._billings = (EntityCollection<BillingEntity>) collectionsQueue.Dequeue();
			this._expenses = (EntityCollection<ExpenseEntity>) collectionsQueue.Dequeue();
			this._payments = (EntityCollection<PaymentEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._billings != null);
			toReturn |=(this._expenses != null);
			toReturn |=(this._payments != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<BillingEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BillingEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ExpenseEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ExpenseEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<PaymentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PaymentEntityFactory))) : null);
		}

		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Damage", _damage);
			toReturn.Add("Group", _group);
			toReturn.Add("Person", _person);
			toReturn.Add("Status", _status);
			toReturn.Add("Billings", _billings);
			toReturn.Add("Expenses", _expenses);
			toReturn.Add("Payments", _payments);
			return toReturn;
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			OnInitClassMembersComplete();
		}


		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Dictionary<string, string>();
			_fieldsCustomProperties = new Dictionary<string, Dictionary<string, string>>();
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Address1", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Address2", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("City", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ContractedAmount", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DamageId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Description", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("EndDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("EstimatorId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("GroupId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("IsAging", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("JobId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Overhead", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PercentDone", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("StartDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("State", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("StatusId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("UpdateDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Zip", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _damage</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncDamage(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _damage, new PropertyChangedEventHandler( OnDamagePropertyChanged ), "Damage", Koop.Data.RelationClasses.StaticJobRelations.DamageEntityUsingDamageIdStatic, true, signalRelatedEntity, "Jobs", resetFKFields, new int[] { (int)JobFieldIndex.DamageId } );
			_damage = null;
		}

		/// <summary> setups the sync logic for member _damage</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncDamage(IEntityCore relatedEntity)
		{
			if(_damage!=relatedEntity)
			{
				DesetupSyncDamage(true, true);
				_damage = (DamageEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _damage, new PropertyChangedEventHandler( OnDamagePropertyChanged ), "Damage", Koop.Data.RelationClasses.StaticJobRelations.DamageEntityUsingDamageIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnDamagePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _group</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncGroup(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _group, new PropertyChangedEventHandler( OnGroupPropertyChanged ), "Group", Koop.Data.RelationClasses.StaticJobRelations.GroupEntityUsingGroupIdStatic, true, signalRelatedEntity, "Jobs", resetFKFields, new int[] { (int)JobFieldIndex.GroupId } );
			_group = null;
		}

		/// <summary> setups the sync logic for member _group</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncGroup(IEntityCore relatedEntity)
		{
			if(_group!=relatedEntity)
			{
				DesetupSyncGroup(true, true);
				_group = (GroupEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _group, new PropertyChangedEventHandler( OnGroupPropertyChanged ), "Group", Koop.Data.RelationClasses.StaticJobRelations.GroupEntityUsingGroupIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnGroupPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _person</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncPerson(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _person, new PropertyChangedEventHandler( OnPersonPropertyChanged ), "Person", Koop.Data.RelationClasses.StaticJobRelations.PersonEntityUsingEstimatorIdStatic, true, signalRelatedEntity, "Jobs", resetFKFields, new int[] { (int)JobFieldIndex.EstimatorId } );
			_person = null;
		}

		/// <summary> setups the sync logic for member _person</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncPerson(IEntityCore relatedEntity)
		{
			if(_person!=relatedEntity)
			{
				DesetupSyncPerson(true, true);
				_person = (PersonEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _person, new PropertyChangedEventHandler( OnPersonPropertyChanged ), "Person", Koop.Data.RelationClasses.StaticJobRelations.PersonEntityUsingEstimatorIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnPersonPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _status</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncStatus(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _status, new PropertyChangedEventHandler( OnStatusPropertyChanged ), "Status", Koop.Data.RelationClasses.StaticJobRelations.StatusEntityUsingStatusIdStatic, true, signalRelatedEntity, "Jobs", resetFKFields, new int[] { (int)JobFieldIndex.StatusId } );
			_status = null;
		}

		/// <summary> setups the sync logic for member _status</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncStatus(IEntityCore relatedEntity)
		{
			if(_status!=relatedEntity)
			{
				DesetupSyncStatus(true, true);
				_status = (StatusEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _status, new PropertyChangedEventHandler( OnStatusPropertyChanged ), "Status", Koop.Data.RelationClasses.StaticJobRelations.StatusEntityUsingStatusIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnStatusPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this JobEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();

		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static JobRelations Relations
		{
			get	{ return new JobRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Billing' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathBillings
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<BillingEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BillingEntityFactory))), (IEntityRelation)GetRelationsForField("Billings")[0], (int)Koop.Data.EntityType.JobEntity, (int)Koop.Data.EntityType.BillingEntity, 0, null, null, null, null, "Billings", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Expense' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathExpenses
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<ExpenseEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ExpenseEntityFactory))), (IEntityRelation)GetRelationsForField("Expenses")[0], (int)Koop.Data.EntityType.JobEntity, (int)Koop.Data.EntityType.ExpenseEntity, 0, null, null, null, null, "Expenses", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Payment' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPayments
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<PaymentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PaymentEntityFactory))), (IEntityRelation)GetRelationsForField("Payments")[0], (int)Koop.Data.EntityType.JobEntity, (int)Koop.Data.EntityType.PaymentEntity, 0, null, null, null, null, "Payments", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Damage' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathDamage
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(DamageEntityFactory))),	(IEntityRelation)GetRelationsForField("Damage")[0], (int)Koop.Data.EntityType.JobEntity, (int)Koop.Data.EntityType.DamageEntity, 0, null, null, null, null, "Damage", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Group' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathGroup
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(GroupEntityFactory))),	(IEntityRelation)GetRelationsForField("Group")[0], (int)Koop.Data.EntityType.JobEntity, (int)Koop.Data.EntityType.GroupEntity, 0, null, null, null, null, "Group", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Person' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPerson
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(PersonEntityFactory))),	(IEntityRelation)GetRelationsForField("Person")[0], (int)Koop.Data.EntityType.JobEntity, (int)Koop.Data.EntityType.PersonEntity, 0, null, null, null, null, "Person", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Status' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathStatus
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(StatusEntityFactory))),	(IEntityRelation)GetRelationsForField("Status")[0], (int)Koop.Data.EntityType.JobEntity, (int)Koop.Data.EntityType.StatusEntity, 0, null, null, null, null, "Status", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, Dictionary<string, string>> FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary> The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, Dictionary<string, string>> FieldsCustomPropertiesOfType
		{
			get { return FieldsCustomProperties;}
		}

		/// <summary> The Address1 property of the Entity Job<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Job"."Address1"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Address1
		{
			get { return (System.String)GetValue((int)JobFieldIndex.Address1, true); }
			set	{ SetValue((int)JobFieldIndex.Address1, value); }
		}

		/// <summary> The Address2 property of the Entity Job<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Job"."Address2"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Address2
		{
			get { return (System.String)GetValue((int)JobFieldIndex.Address2, true); }
			set	{ SetValue((int)JobFieldIndex.Address2, value); }
		}

		/// <summary> The City property of the Entity Job<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Job"."City"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String City
		{
			get { return (System.String)GetValue((int)JobFieldIndex.City, true); }
			set	{ SetValue((int)JobFieldIndex.City, value); }
		}

		/// <summary> The ContractedAmount property of the Entity Job<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Job"."ContractedAmount"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> ContractedAmount
		{
			get { return (Nullable<System.Decimal>)GetValue((int)JobFieldIndex.ContractedAmount, false); }
			set	{ SetValue((int)JobFieldIndex.ContractedAmount, value); }
		}

		/// <summary> The DamageId property of the Entity Job<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Job"."DamageId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> DamageId
		{
			get { return (Nullable<System.Int32>)GetValue((int)JobFieldIndex.DamageId, false); }
			set	{ SetValue((int)JobFieldIndex.DamageId, value); }
		}

		/// <summary> The Description property of the Entity Job<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Job"."Description"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 1024<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Description
		{
			get { return (System.String)GetValue((int)JobFieldIndex.Description, true); }
			set	{ SetValue((int)JobFieldIndex.Description, value); }
		}

		/// <summary> The EndDate property of the Entity Job<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Job"."EndDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> EndDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)JobFieldIndex.EndDate, false); }
			set	{ SetValue((int)JobFieldIndex.EndDate, value); }
		}

		/// <summary> The EstimatorId property of the Entity Job<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Job"."EstimatorId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> EstimatorId
		{
			get { return (Nullable<System.Int32>)GetValue((int)JobFieldIndex.EstimatorId, false); }
			set	{ SetValue((int)JobFieldIndex.EstimatorId, value); }
		}

		/// <summary> The GroupId property of the Entity Job<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Job"."GroupId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 GroupId
		{
			get { return (System.Int32)GetValue((int)JobFieldIndex.GroupId, true); }
			set	{ SetValue((int)JobFieldIndex.GroupId, value); }
		}

		/// <summary> The IsAging property of the Entity Job<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Job"."IsAging"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsAging
		{
			get { return (System.Boolean)GetValue((int)JobFieldIndex.IsAging, true); }
			set	{ SetValue((int)JobFieldIndex.IsAging, value); }
		}

		/// <summary> The JobId property of the Entity Job<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Job"."JobId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 JobId
		{
			get { return (System.Int32)GetValue((int)JobFieldIndex.JobId, true); }
			set	{ SetValue((int)JobFieldIndex.JobId, value); }
		}

		/// <summary> The Name property of the Entity Job<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Job"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)JobFieldIndex.Name, true); }
			set	{ SetValue((int)JobFieldIndex.Name, value); }
		}

		/// <summary> The Overhead property of the Entity Job<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Job"."Overhead"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Overhead
		{
			get { return (Nullable<System.Decimal>)GetValue((int)JobFieldIndex.Overhead, false); }
			set	{ SetValue((int)JobFieldIndex.Overhead, value); }
		}

		/// <summary> The PercentDone property of the Entity Job<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Job"."PercentDone"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal PercentDone
		{
			get { return (System.Decimal)GetValue((int)JobFieldIndex.PercentDone, true); }
			set	{ SetValue((int)JobFieldIndex.PercentDone, value); }
		}

		/// <summary> The StartDate property of the Entity Job<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Job"."StartDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> StartDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)JobFieldIndex.StartDate, false); }
			set	{ SetValue((int)JobFieldIndex.StartDate, value); }
		}

		/// <summary> The State property of the Entity Job<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Job"."State"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String State
		{
			get { return (System.String)GetValue((int)JobFieldIndex.State, true); }
			set	{ SetValue((int)JobFieldIndex.State, value); }
		}

		/// <summary> The StatusId property of the Entity Job<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Job"."StatusId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 StatusId
		{
			get { return (System.Int32)GetValue((int)JobFieldIndex.StatusId, true); }
			set	{ SetValue((int)JobFieldIndex.StatusId, value); }
		}

		/// <summary> The UpdateDate property of the Entity Job<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Job"."UpdateDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> UpdateDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)JobFieldIndex.UpdateDate, false); }
			set	{ SetValue((int)JobFieldIndex.UpdateDate, value); }
		}

		/// <summary> The Zip property of the Entity Job<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Job"."Zip"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Zip
		{
			get { return (System.String)GetValue((int)JobFieldIndex.Zip, true); }
			set	{ SetValue((int)JobFieldIndex.Zip, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'BillingEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(BillingEntity))]
		public virtual EntityCollection<BillingEntity> Billings
		{
			get { return GetOrCreateEntityCollection<BillingEntity, BillingEntityFactory>("Job", true, false, ref _billings);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ExpenseEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ExpenseEntity))]
		public virtual EntityCollection<ExpenseEntity> Expenses
		{
			get { return GetOrCreateEntityCollection<ExpenseEntity, ExpenseEntityFactory>("Job", true, false, ref _expenses);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'PaymentEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(PaymentEntity))]
		public virtual EntityCollection<PaymentEntity> Payments
		{
			get { return GetOrCreateEntityCollection<PaymentEntity, PaymentEntityFactory>("Job", true, false, ref _payments);	}
		}

		/// <summary> Gets / sets related entity of type 'DamageEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual DamageEntity Damage
		{
			get	{ return _damage; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncDamage(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Jobs", "Damage", _damage, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'GroupEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual GroupEntity Group
		{
			get	{ return _group; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncGroup(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Jobs", "Group", _group, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'PersonEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual PersonEntity Person
		{
			get	{ return _person; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncPerson(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Jobs", "Person", _person, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'StatusEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual StatusEntity Status
		{
			get	{ return _status; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncStatus(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Jobs", "Status", _status, true); 
				}
			}
		}
	
		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}
		
		/// <summary>Returns the Koop.Data.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)Koop.Data.EntityType.JobEntity; }
		}

		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Included code

		#endregion
	}
}
