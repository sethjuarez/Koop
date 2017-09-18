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
	
	/// <summary>Entity class which represents the entity 'Expense'.<br/><br/></summary>
	[Serializable]
	public partial class ExpenseEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private JobEntity _job;
		private VendorEntity _vendor;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Job</summary>
			public static readonly string Job = "Job";
			/// <summary>Member name Vendor</summary>
			public static readonly string Vendor = "Vendor";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ExpenseEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public ExpenseEntity():base("ExpenseEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public ExpenseEntity(IEntityFields2 fields):base("ExpenseEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this ExpenseEntity</param>
		public ExpenseEntity(IValidator validator):base("ExpenseEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="expenseId">PK value for Expense which data should be fetched into this Expense object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public ExpenseEntity(System.Int32 expenseId):base("ExpenseEntity")
		{
			InitClassEmpty(null, null);
			this.ExpenseId = expenseId;
		}

		/// <summary> CTor</summary>
		/// <param name="expenseId">PK value for Expense which data should be fetched into this Expense object</param>
		/// <param name="validator">The custom validator object for this ExpenseEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public ExpenseEntity(System.Int32 expenseId, IValidator validator):base("ExpenseEntity")
		{
			InitClassEmpty(validator, null);
			this.ExpenseId = expenseId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected ExpenseEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_job = (JobEntity)info.GetValue("_job", typeof(JobEntity));
				if(_job!=null)
				{
					_job.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_vendor = (VendorEntity)info.GetValue("_vendor", typeof(VendorEntity));
				if(_vendor!=null)
				{
					_vendor.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((ExpenseFieldIndex)fieldIndex)
			{
				case ExpenseFieldIndex.JobId:
					DesetupSyncJob(true, false);
					break;
				case ExpenseFieldIndex.VendorId:
					DesetupSyncVendor(true, false);
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
				case "Job":
					this.Job = (JobEntity)entity;
					break;
				case "Vendor":
					this.Vendor = (VendorEntity)entity;
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
				case "Job":
					toReturn.Add(Relations.JobEntityUsingJobId);
					break;
				case "Vendor":
					toReturn.Add(Relations.VendorEntityUsingVendorId);
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
				case "Job":
					SetupSyncJob(relatedEntity);
					break;
				case "Vendor":
					SetupSyncVendor(relatedEntity);
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
				case "Job":
					DesetupSyncJob(false, true);
					break;
				case "Vendor":
					DesetupSyncVendor(false, true);
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
			if(_job!=null)
			{
				toReturn.Add(_job);
			}
			if(_vendor!=null)
			{
				toReturn.Add(_vendor);
			}
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
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
				info.AddValue("_job", (!this.MarkedForDeletion?_job:null));
				info.AddValue("_vendor", (!this.MarkedForDeletion?_vendor:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new ExpenseRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Job' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoJob()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(JobFields.JobId, null, ComparisonOperator.Equal, this.JobId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Vendor' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoVendor()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(VendorFields.VendorId, null, ComparisonOperator.Equal, this.VendorId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(ExpenseEntityFactory));
		}

		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
		}

		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Job", _job);
			toReturn.Add("Vendor", _vendor);
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
			_fieldsCustomProperties.Add("Description", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ExpenseId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ExternalInvoice", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("InvoiceDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("JobId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("LaborCost", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("LaborHours", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("LaborRate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("MaterialCost", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("TotalCost", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("VendorId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _job</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncJob(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _job, new PropertyChangedEventHandler( OnJobPropertyChanged ), "Job", Koop.Data.RelationClasses.StaticExpenseRelations.JobEntityUsingJobIdStatic, true, signalRelatedEntity, "Expenses", resetFKFields, new int[] { (int)ExpenseFieldIndex.JobId } );
			_job = null;
		}

		/// <summary> setups the sync logic for member _job</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncJob(IEntityCore relatedEntity)
		{
			if(_job!=relatedEntity)
			{
				DesetupSyncJob(true, true);
				_job = (JobEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _job, new PropertyChangedEventHandler( OnJobPropertyChanged ), "Job", Koop.Data.RelationClasses.StaticExpenseRelations.JobEntityUsingJobIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnJobPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _vendor</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncVendor(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _vendor, new PropertyChangedEventHandler( OnVendorPropertyChanged ), "Vendor", Koop.Data.RelationClasses.StaticExpenseRelations.VendorEntityUsingVendorIdStatic, true, signalRelatedEntity, "Expenses", resetFKFields, new int[] { (int)ExpenseFieldIndex.VendorId } );
			_vendor = null;
		}

		/// <summary> setups the sync logic for member _vendor</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncVendor(IEntityCore relatedEntity)
		{
			if(_vendor!=relatedEntity)
			{
				DesetupSyncVendor(true, true);
				_vendor = (VendorEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _vendor, new PropertyChangedEventHandler( OnVendorPropertyChanged ), "Vendor", Koop.Data.RelationClasses.StaticExpenseRelations.VendorEntityUsingVendorIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnVendorPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this ExpenseEntity</param>
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
		public  static ExpenseRelations Relations
		{
			get	{ return new ExpenseRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Job' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathJob
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(JobEntityFactory))),	(IEntityRelation)GetRelationsForField("Job")[0], (int)Koop.Data.EntityType.ExpenseEntity, (int)Koop.Data.EntityType.JobEntity, 0, null, null, null, null, "Job", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Vendor' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathVendor
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(VendorEntityFactory))),	(IEntityRelation)GetRelationsForField("Vendor")[0], (int)Koop.Data.EntityType.ExpenseEntity, (int)Koop.Data.EntityType.VendorEntity, 0, null, null, null, null, "Vendor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The Description property of the Entity Expense<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Expense"."Description"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 1024<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Description
		{
			get { return (System.String)GetValue((int)ExpenseFieldIndex.Description, true); }
			set	{ SetValue((int)ExpenseFieldIndex.Description, value); }
		}

		/// <summary> The ExpenseId property of the Entity Expense<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Expense"."ExpenseId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ExpenseId
		{
			get { return (System.Int32)GetValue((int)ExpenseFieldIndex.ExpenseId, true); }
			set	{ SetValue((int)ExpenseFieldIndex.ExpenseId, value); }
		}

		/// <summary> The ExternalInvoice property of the Entity Expense<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Expense"."ExternalInvoice"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ExternalInvoice
		{
			get { return (System.String)GetValue((int)ExpenseFieldIndex.ExternalInvoice, true); }
			set	{ SetValue((int)ExpenseFieldIndex.ExternalInvoice, value); }
		}

		/// <summary> The InvoiceDate property of the Entity Expense<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Expense"."InvoiceDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> InvoiceDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)ExpenseFieldIndex.InvoiceDate, false); }
			set	{ SetValue((int)ExpenseFieldIndex.InvoiceDate, value); }
		}

		/// <summary> The JobId property of the Entity Expense<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Expense"."JobId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> JobId
		{
			get { return (Nullable<System.Int32>)GetValue((int)ExpenseFieldIndex.JobId, false); }
			set	{ SetValue((int)ExpenseFieldIndex.JobId, value); }
		}

		/// <summary> The LaborCost property of the Entity Expense<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Expense"."LaborCost"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> LaborCost
		{
			get { return (Nullable<System.Decimal>)GetValue((int)ExpenseFieldIndex.LaborCost, false); }
			set	{ SetValue((int)ExpenseFieldIndex.LaborCost, value); }
		}

		/// <summary> The LaborHours property of the Entity Expense<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Expense"."LaborHours"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> LaborHours
		{
			get { return (Nullable<System.Decimal>)GetValue((int)ExpenseFieldIndex.LaborHours, false); }
			set	{ SetValue((int)ExpenseFieldIndex.LaborHours, value); }
		}

		/// <summary> The LaborRate property of the Entity Expense<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Expense"."LaborRate"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> LaborRate
		{
			get { return (Nullable<System.Decimal>)GetValue((int)ExpenseFieldIndex.LaborRate, false); }
			set	{ SetValue((int)ExpenseFieldIndex.LaborRate, value); }
		}

		/// <summary> The MaterialCost property of the Entity Expense<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Expense"."MaterialCost"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> MaterialCost
		{
			get { return (Nullable<System.Decimal>)GetValue((int)ExpenseFieldIndex.MaterialCost, false); }
			set	{ SetValue((int)ExpenseFieldIndex.MaterialCost, value); }
		}

		/// <summary> The TotalCost property of the Entity Expense<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Expense"."TotalCost"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> TotalCost
		{
			get { return (Nullable<System.Decimal>)GetValue((int)ExpenseFieldIndex.TotalCost, false); }
			set	{ SetValue((int)ExpenseFieldIndex.TotalCost, value); }
		}

		/// <summary> The VendorId property of the Entity Expense<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Expense"."VendorId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> VendorId
		{
			get { return (Nullable<System.Int32>)GetValue((int)ExpenseFieldIndex.VendorId, false); }
			set	{ SetValue((int)ExpenseFieldIndex.VendorId, value); }
		}

		/// <summary> Gets / sets related entity of type 'JobEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual JobEntity Job
		{
			get	{ return _job; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncJob(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Expenses", "Job", _job, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'VendorEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual VendorEntity Vendor
		{
			get	{ return _vendor; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncVendor(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Expenses", "Vendor", _vendor, true); 
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
			get { return (int)Koop.Data.EntityType.ExpenseEntity; }
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
