﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.2
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
////////////////////////////////////////////////////////////// 
using System;
using System.Linq;
using Koop.Data.EntityClasses;
using Koop.Data.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.QuerySpec;

namespace Koop.Data.FactoryClasses
{
	/// <summary>Factory class to produce DynamicQuery instances and EntityQuery instances</summary>
	public partial class QueryFactory
	{
		private int _aliasCounter = 0;

		/// <summary>Creates a new DynamicQuery instance with no alias set.</summary>
		/// <returns>Ready to use DynamicQuery instance</returns>
		public DynamicQuery Create()
		{
			return Create(string.Empty);
		}

		/// <summary>Creates a new DynamicQuery instance with the alias specified as the alias set.</summary>
		/// <param name="alias">The alias.</param>
		/// <returns>Ready to use DynamicQuery instance</returns>
		public DynamicQuery Create(string alias)
		{
			return new DynamicQuery(new ElementCreator(), alias, this.GetNextAliasCounterValue());
		}

		/// <summary>Creates a new DynamicQuery which wraps the specified TableValuedFunction call</summary>
		/// <param name="toWrap">The table valued function call to wrap.</param>
		/// <returns>toWrap wrapped in a DynamicQuery.</returns>
		public DynamicQuery Create(TableValuedFunctionCall toWrap)
		{
			return this.Create().From(new TvfCallWrapper(toWrap)).Select(toWrap.GetFieldsAsArray().Select(f => this.Field(toWrap.Alias, f.Alias)).ToArray());
		}

		/// <summary>Creates a new EntityQuery for the entity of the type specified with no alias set.</summary>
		/// <typeparam name="TEntity">The type of the entity to produce the query for.</typeparam>
		/// <returns>ready to use EntityQuery instance</returns>
		public EntityQuery<TEntity> Create<TEntity>()
			where TEntity : IEntityCore
		{
			return Create<TEntity>(string.Empty);
		}

		/// <summary>Creates a new EntityQuery for the entity of the type specified with the alias specified as the alias set.</summary>
		/// <typeparam name="TEntity">The type of the entity to produce the query for.</typeparam>
		/// <param name="alias">The alias.</param>
		/// <returns>ready to use EntityQuery instance</returns>
		public EntityQuery<TEntity> Create<TEntity>(string alias)
			where TEntity : IEntityCore
		{
			return new EntityQuery<TEntity>(new ElementCreator(), alias, this.GetNextAliasCounterValue());
		}
				
		/// <summary>Creates a new field object with the name specified and of resulttype 'object'. Used for referring to aliased fields in another projection.</summary>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField2 Field(string fieldName)
		{
			return Field<object>(string.Empty, fieldName);
		}

		/// <summary>Creates a new field object with the name specified and of resulttype 'object'. Used for referring to aliased fields in another projection.</summary>
		/// <param name="targetAlias">The alias of the table/query to target.</param>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField2 Field(string targetAlias, string fieldName)
		{
			return Field<object>(targetAlias, fieldName);
		}

		/// <summary>Creates a new field object with the name specified and of resulttype 'TValue'. Used for referring to aliased fields in another projection.</summary>
		/// <typeparam name="TValue">The type of the value represented by the field.</typeparam>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField2 Field<TValue>(string fieldName)
		{
			return Field<TValue>(string.Empty, fieldName);
		}

		/// <summary>Creates a new field object with the name specified and of resulttype 'TValue'. Used for referring to aliased fields in another projection.</summary>
		/// <typeparam name="TValue">The type of the value.</typeparam>
		/// <param name="targetAlias">The alias of the table/query to target.</param>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField2 Field<TValue>(string targetAlias, string fieldName)
		{
			return new EntityField2(fieldName, targetAlias, typeof(TValue));
		}
		
		/// <summary>Gets the next alias counter value to produce artifical aliases with</summary>
		private int GetNextAliasCounterValue()
		{
			_aliasCounter++;
			return _aliasCounter;
		}
		

		/// <summary>Creates and returns a new EntityQuery for the Billing entity</summary>
		public EntityQuery<BillingEntity> Billing
		{
			get { return Create<BillingEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Damage entity</summary>
		public EntityQuery<DamageEntity> Damage
		{
			get { return Create<DamageEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Expense entity</summary>
		public EntityQuery<ExpenseEntity> Expense
		{
			get { return Create<ExpenseEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Group entity</summary>
		public EntityQuery<GroupEntity> Group
		{
			get { return Create<GroupEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Job entity</summary>
		public EntityQuery<JobEntity> Job
		{
			get { return Create<JobEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Payment entity</summary>
		public EntityQuery<PaymentEntity> Payment
		{
			get { return Create<PaymentEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Person entity</summary>
		public EntityQuery<PersonEntity> Person
		{
			get { return Create<PersonEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Role entity</summary>
		public EntityQuery<RoleEntity> Role
		{
			get { return Create<RoleEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Setting entity</summary>
		public EntityQuery<SettingEntity> Setting
		{
			get { return Create<SettingEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Status entity</summary>
		public EntityQuery<StatusEntity> Status
		{
			get { return Create<StatusEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Vendor entity</summary>
		public EntityQuery<VendorEntity> Vendor
		{
			get { return Create<VendorEntity>(); }
		}


 
	}
}