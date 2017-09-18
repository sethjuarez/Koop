///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.2
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Linq;
using System.Collections.Generic;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

using Koop.Data;
using Koop.Data.EntityClasses;
using Koop.Data.FactoryClasses;
using Koop.Data.HelperClasses;
using Koop.Data.RelationClasses;

namespace Koop.Data.Linq
{
	/// <summary>Meta-data class for the construction of Linq queries which are to be executed using LLBLGen Pro code.</summary>
	public partial class LinqMetaData: ILinqMetaData
	{
		#region Class Member Declarations
		private IDataAccessAdapter _adapterToUse;
		private FunctionMappingStore _customFunctionMappings;
		private Context _contextToUse;
		#endregion
		
		/// <summary>CTor. Using this ctor will leave the IDataAccessAdapter object to use empty. To be able to execute the query, an IDataAccessAdapter instance
		/// is required, and has to be set on the LLBLGenProProvider2 object in the query to execute. </summary>
		public LinqMetaData() : this(null, null)
		{
		}
		
		/// <summary>CTor which accepts an IDataAccessAdapter implementing object, which will be used to execute queries created with this metadata class.</summary>
		/// <param name="adapterToUse">the IDataAccessAdapter to use in queries created with this meta data</param>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public LinqMetaData(IDataAccessAdapter adapterToUse) : this (adapterToUse, null)
		{
		}

		/// <summary>CTor which accepts an IDataAccessAdapter implementing object, which will be used to execute queries created with this metadata class.</summary>
		/// <param name="adapterToUse">the IDataAccessAdapter to use in queries created with this meta data</param>
		/// <param name="customFunctionMappings">The custom function mappings to use. These take higher precedence than the ones in the DQE to use.</param>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public LinqMetaData(IDataAccessAdapter adapterToUse, FunctionMappingStore customFunctionMappings)
		{
			_adapterToUse = adapterToUse;
			_customFunctionMappings = customFunctionMappings;
		}
	
		/// <summary>returns the datasource to use in a Linq query for the entity type specified</summary>
		/// <param name="typeOfEntity">the type of the entity to get the datasource for</param>
		/// <returns>the requested datasource</returns>
		public IDataSource GetQueryableForEntity(int typeOfEntity)
		{
			IDataSource toReturn = null;
			switch((Koop.Data.EntityType)typeOfEntity)
			{
				case Koop.Data.EntityType.BillingEntity:
					toReturn = this.Billing;
					break;
				case Koop.Data.EntityType.DamageEntity:
					toReturn = this.Damage;
					break;
				case Koop.Data.EntityType.ExpenseEntity:
					toReturn = this.Expense;
					break;
				case Koop.Data.EntityType.GroupEntity:
					toReturn = this.Group;
					break;
				case Koop.Data.EntityType.JobEntity:
					toReturn = this.Job;
					break;
				case Koop.Data.EntityType.PaymentEntity:
					toReturn = this.Payment;
					break;
				case Koop.Data.EntityType.PersonEntity:
					toReturn = this.Person;
					break;
				case Koop.Data.EntityType.RoleEntity:
					toReturn = this.Role;
					break;
				case Koop.Data.EntityType.SettingEntity:
					toReturn = this.Setting;
					break;
				case Koop.Data.EntityType.StatusEntity:
					toReturn = this.Status;
					break;
				case Koop.Data.EntityType.VendorEntity:
					toReturn = this.Vendor;
					break;
				default:
					toReturn = null;
					break;
			}
			return toReturn;
		}

		/// <summary>returns the datasource to use in a Linq query for the entity type specified</summary>
		/// <typeparam name="TEntity">the type of the entity to get the datasource for</typeparam>
		/// <returns>the requested datasource</returns>
		public DataSource2<TEntity> GetQueryableForEntity<TEntity>()
				where TEntity : class
		{
			return new DataSource2<TEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse);
		}

		/// <summary>returns the datasource to use in a Linq query when targeting BillingEntity instances in the database.</summary>
		public DataSource2<BillingEntity> Billing
		{
			get { return new DataSource2<BillingEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting DamageEntity instances in the database.</summary>
		public DataSource2<DamageEntity> Damage
		{
			get { return new DataSource2<DamageEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ExpenseEntity instances in the database.</summary>
		public DataSource2<ExpenseEntity> Expense
		{
			get { return new DataSource2<ExpenseEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting GroupEntity instances in the database.</summary>
		public DataSource2<GroupEntity> Group
		{
			get { return new DataSource2<GroupEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting JobEntity instances in the database.</summary>
		public DataSource2<JobEntity> Job
		{
			get { return new DataSource2<JobEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting PaymentEntity instances in the database.</summary>
		public DataSource2<PaymentEntity> Payment
		{
			get { return new DataSource2<PaymentEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting PersonEntity instances in the database.</summary>
		public DataSource2<PersonEntity> Person
		{
			get { return new DataSource2<PersonEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting RoleEntity instances in the database.</summary>
		public DataSource2<RoleEntity> Role
		{
			get { return new DataSource2<RoleEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SettingEntity instances in the database.</summary>
		public DataSource2<SettingEntity> Setting
		{
			get { return new DataSource2<SettingEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting StatusEntity instances in the database.</summary>
		public DataSource2<StatusEntity> Status
		{
			get { return new DataSource2<StatusEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting VendorEntity instances in the database.</summary>
		public DataSource2<VendorEntity> Vendor
		{
			get { return new DataSource2<VendorEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		

		#region Class Property Declarations
		/// <summary> Gets / sets the IDataAccessAdapter to use for the queries created with this meta data object.</summary>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public IDataAccessAdapter AdapterToUse
		{
			get { return _adapterToUse;}
			set { _adapterToUse = value;}
		}

		/// <summary>Gets or sets the custom function mappings to use. These take higher precedence than the ones in the DQE to use</summary>
		public FunctionMappingStore CustomFunctionMappings
		{
			get { return _customFunctionMappings; }
			set { _customFunctionMappings = value; }
		}
		
		/// <summary>Gets or sets the Context instance to use for entity fetches.</summary>
		public Context ContextToUse
		{
			get { return _contextToUse;}
			set { _contextToUse = value;}
		}
		#endregion
	}
}