﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.2
// Code is generated on: vrijdag 20 juni 2014 12:58:55
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Xml.Serialization;
using SD.LLBLGen.Pro.Examples.Auditing;
using SD.LLBLGen.Pro.Examples.Auditing.HelperClasses;
using SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses;
using SD.LLBLGen.Pro.Examples.Auditing.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SD.LLBLGen.Pro.Examples.Auditing.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'Product'.<br/><br/></summary>
	[Serializable]
	public partial class ProductEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<OrderDetailEntity> _orderDetails;
		private EntityCollection<OrderEntity> _ordersCollectionViaOrderDetails;
		private CategoryEntity _categories;
		private SupplierEntity _suppliers;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Categories</summary>
			public static readonly string Categories = "Categories";
			/// <summary>Member name Suppliers</summary>
			public static readonly string Suppliers = "Suppliers";
			/// <summary>Member name OrderDetails</summary>
			public static readonly string OrderDetails = "OrderDetails";
			/// <summary>Member name OrdersCollectionViaOrderDetails</summary>
			public static readonly string OrdersCollectionViaOrderDetails = "OrdersCollectionViaOrderDetails";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ProductEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public ProductEntity():base("ProductEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public ProductEntity(IEntityFields2 fields):base("ProductEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this ProductEntity</param>
		public ProductEntity(IValidator validator):base("ProductEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public ProductEntity(System.Int32 productId):base("ProductEntity")
		{
			InitClassEmpty(null, null);
			this.ProductId = productId;
		}

		/// <summary> CTor</summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="validator">The custom validator object for this ProductEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public ProductEntity(System.Int32 productId, IValidator validator):base("ProductEntity")
		{
			InitClassEmpty(validator, null);
			this.ProductId = productId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected ProductEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_orderDetails = (EntityCollection<OrderDetailEntity>)info.GetValue("_orderDetails", typeof(EntityCollection<OrderDetailEntity>));
				_ordersCollectionViaOrderDetails = (EntityCollection<OrderEntity>)info.GetValue("_ordersCollectionViaOrderDetails", typeof(EntityCollection<OrderEntity>));
				_categories = (CategoryEntity)info.GetValue("_categories", typeof(CategoryEntity));
				if(_categories!=null)
				{
					_categories.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_suppliers = (SupplierEntity)info.GetValue("_suppliers", typeof(SupplierEntity));
				if(_suppliers!=null)
				{
					_suppliers.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((ProductFieldIndex)fieldIndex)
			{
				case ProductFieldIndex.CategoryId:
					DesetupSyncCategories(true, false);
					break;
				case ProductFieldIndex.SupplierId:
					DesetupSyncSuppliers(true, false);
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
				case "Categories":
					this.Categories = (CategoryEntity)entity;
					break;
				case "Suppliers":
					this.Suppliers = (SupplierEntity)entity;
					break;
				case "OrderDetails":
					this.OrderDetails.Add((OrderDetailEntity)entity);
					break;
				case "OrdersCollectionViaOrderDetails":
					this.OrdersCollectionViaOrderDetails.IsReadOnly = false;
					this.OrdersCollectionViaOrderDetails.Add((OrderEntity)entity);
					this.OrdersCollectionViaOrderDetails.IsReadOnly = true;
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
				case "Categories":
					toReturn.Add(Relations.CategoryEntityUsingCategoryId);
					break;
				case "Suppliers":
					toReturn.Add(Relations.SupplierEntityUsingSupplierId);
					break;
				case "OrderDetails":
					toReturn.Add(Relations.OrderDetailEntityUsingProductId);
					break;
				case "OrdersCollectionViaOrderDetails":
					toReturn.Add(Relations.OrderDetailEntityUsingProductId, "ProductEntity__", "OrderDetail_", JoinHint.None);
					toReturn.Add(OrderDetailEntity.Relations.OrderEntityUsingOrderId, "OrderDetail_", string.Empty, JoinHint.None);
					break;
				default:
					break;				
			}
			return toReturn;
		}
#if !CF
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
#endif
		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		protected override void SetRelatedEntity(IEntityCore relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "Categories":
					SetupSyncCategories(relatedEntity);
					break;
				case "Suppliers":
					SetupSyncSuppliers(relatedEntity);
					break;
				case "OrderDetails":
					this.OrderDetails.Add((OrderDetailEntity)relatedEntity);
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
				case "Categories":
					DesetupSyncCategories(false, true);
					break;
				case "Suppliers":
					DesetupSyncSuppliers(false, true);
					break;
				case "OrderDetails":
					this.PerformRelatedEntityRemoval(this.OrderDetails, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_categories!=null)
			{
				toReturn.Add(_categories);
			}
			if(_suppliers!=null)
			{
				toReturn.Add(_suppliers);
			}
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.OrderDetails);
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
				info.AddValue("_orderDetails", ((_orderDetails!=null) && (_orderDetails.Count>0) && !this.MarkedForDeletion)?_orderDetails:null);
				info.AddValue("_ordersCollectionViaOrderDetails", ((_ordersCollectionViaOrderDetails!=null) && (_ordersCollectionViaOrderDetails.Count>0) && !this.MarkedForDeletion)?_ordersCollectionViaOrderDetails:null);
				info.AddValue("_categories", (!this.MarkedForDeletion?_categories:null));
				info.AddValue("_suppliers", (!this.MarkedForDeletion?_suppliers:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new ProductRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'OrderDetail' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoOrderDetails()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(OrderDetailFields.ProductId, null, ComparisonOperator.Equal, this.ProductId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Order' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoOrdersCollectionViaOrderDetails()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("OrdersCollectionViaOrderDetails"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductFields.ProductId, null, ComparisonOperator.Equal, this.ProductId, "ProductEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Category' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCategories()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CategoryFields.CategoryId, null, ComparisonOperator.Equal, this.CategoryId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Supplier' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSuppliers()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SupplierFields.SupplierId, null, ComparisonOperator.Equal, this.SupplierId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(ProductEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._orderDetails);
			collectionsQueue.Enqueue(this._ordersCollectionViaOrderDetails);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._orderDetails = (EntityCollection<OrderDetailEntity>) collectionsQueue.Dequeue();
			this._ordersCollectionViaOrderDetails = (EntityCollection<OrderEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._orderDetails != null);
			toReturn |= (this._ordersCollectionViaOrderDetails != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<OrderDetailEntity>(EntityFactoryCache2.GetEntityFactory(typeof(OrderDetailEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<OrderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(OrderEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Categories", _categories);
			toReturn.Add("Suppliers", _suppliers);
			toReturn.Add("OrderDetails", _orderDetails);
			toReturn.Add("OrdersCollectionViaOrderDetails", _ordersCollectionViaOrderDetails);
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
			_fieldsCustomProperties.Add("CategoryId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Discontinued", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ProductId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ProductName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("QuantityPerUnit", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ReorderLevel", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SupplierId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("UnitPrice", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("UnitsInStock", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("UnitsOnOrder", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _categories</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCategories(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _categories, new PropertyChangedEventHandler( OnCategoriesPropertyChanged ), "Categories", SD.LLBLGen.Pro.Examples.Auditing.RelationClasses.StaticProductRelations.CategoryEntityUsingCategoryIdStatic, true, signalRelatedEntity, "Products", resetFKFields, new int[] { (int)ProductFieldIndex.CategoryId } );
			_categories = null;
		}

		/// <summary> setups the sync logic for member _categories</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCategories(IEntityCore relatedEntity)
		{
			if(_categories!=relatedEntity)
			{
				DesetupSyncCategories(true, true);
				_categories = (CategoryEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _categories, new PropertyChangedEventHandler( OnCategoriesPropertyChanged ), "Categories", SD.LLBLGen.Pro.Examples.Auditing.RelationClasses.StaticProductRelations.CategoryEntityUsingCategoryIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCategoriesPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _suppliers</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSuppliers(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _suppliers, new PropertyChangedEventHandler( OnSuppliersPropertyChanged ), "Suppliers", SD.LLBLGen.Pro.Examples.Auditing.RelationClasses.StaticProductRelations.SupplierEntityUsingSupplierIdStatic, true, signalRelatedEntity, "Products", resetFKFields, new int[] { (int)ProductFieldIndex.SupplierId } );
			_suppliers = null;
		}

		/// <summary> setups the sync logic for member _suppliers</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSuppliers(IEntityCore relatedEntity)
		{
			if(_suppliers!=relatedEntity)
			{
				DesetupSyncSuppliers(true, true);
				_suppliers = (SupplierEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _suppliers, new PropertyChangedEventHandler( OnSuppliersPropertyChanged ), "Suppliers", SD.LLBLGen.Pro.Examples.Auditing.RelationClasses.StaticProductRelations.SupplierEntityUsingSupplierIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnSuppliersPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this ProductEntity</param>
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
		public  static ProductRelations Relations
		{
			get	{ return new ProductRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'OrderDetail' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathOrderDetails
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<OrderDetailEntity>(EntityFactoryCache2.GetEntityFactory(typeof(OrderDetailEntityFactory))), (IEntityRelation)GetRelationsForField("OrderDetails")[0], (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.ProductEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.OrderDetailEntity, 0, null, null, null, null, "OrderDetails", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Order' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathOrdersCollectionViaOrderDetails
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.OrderDetailEntityUsingProductId;
				intermediateRelation.SetAliases(string.Empty, "OrderDetail_");
				return new PrefetchPathElement2(new EntityCollection<OrderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(OrderEntityFactory))), intermediateRelation,
					(int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.ProductEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.OrderEntity, 0, null, null, GetRelationsForField("OrdersCollectionViaOrderDetails"), null, "OrdersCollectionViaOrderDetails", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Category' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCategories
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(CategoryEntityFactory))),	(IEntityRelation)GetRelationsForField("Categories")[0], (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.ProductEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.CategoryEntity, 0, null, null, null, null, "Categories", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Supplier' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSuppliers
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(SupplierEntityFactory))),	(IEntityRelation)GetRelationsForField("Suppliers")[0], (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.ProductEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.SupplierEntity, 0, null, null, null, null, "Suppliers", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The CategoryId property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."CategoryID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> CategoryId
		{
			get { return (Nullable<System.Int32>)GetValue((int)ProductFieldIndex.CategoryId, false); }
			set	{ SetValue((int)ProductFieldIndex.CategoryId, value); }
		}

		/// <summary> The Discontinued property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."Discontinued"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean Discontinued
		{
			get { return (System.Boolean)GetValue((int)ProductFieldIndex.Discontinued, true); }
			set	{ SetValue((int)ProductFieldIndex.Discontinued, value); }
		}

		/// <summary> The ProductId property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."ProductID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ProductId
		{
			get { return (System.Int32)GetValue((int)ProductFieldIndex.ProductId, true); }
			set	{ SetValue((int)ProductFieldIndex.ProductId, value); }
		}

		/// <summary> The ProductName property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."ProductName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 40<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String ProductName
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.ProductName, true); }
			set	{ SetValue((int)ProductFieldIndex.ProductName, value); }
		}

		/// <summary> The QuantityPerUnit property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."QuantityPerUnit"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 20<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String QuantityPerUnit
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.QuantityPerUnit, true); }
			set	{ SetValue((int)ProductFieldIndex.QuantityPerUnit, value); }
		}

		/// <summary> The ReorderLevel property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."ReorderLevel"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int16> ReorderLevel
		{
			get { return (Nullable<System.Int16>)GetValue((int)ProductFieldIndex.ReorderLevel, false); }
			set	{ SetValue((int)ProductFieldIndex.ReorderLevel, value); }
		}

		/// <summary> The SupplierId property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."SupplierID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> SupplierId
		{
			get { return (Nullable<System.Int32>)GetValue((int)ProductFieldIndex.SupplierId, false); }
			set	{ SetValue((int)ProductFieldIndex.SupplierId, value); }
		}

		/// <summary> The UnitPrice property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."UnitPrice"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> UnitPrice
		{
			get { return (Nullable<System.Decimal>)GetValue((int)ProductFieldIndex.UnitPrice, false); }
			set	{ SetValue((int)ProductFieldIndex.UnitPrice, value); }
		}

		/// <summary> The UnitsInStock property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."UnitsInStock"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int16> UnitsInStock
		{
			get { return (Nullable<System.Int16>)GetValue((int)ProductFieldIndex.UnitsInStock, false); }
			set	{ SetValue((int)ProductFieldIndex.UnitsInStock, value); }
		}

		/// <summary> The UnitsOnOrder property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."UnitsOnOrder"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int16> UnitsOnOrder
		{
			get { return (Nullable<System.Int16>)GetValue((int)ProductFieldIndex.UnitsOnOrder, false); }
			set	{ SetValue((int)ProductFieldIndex.UnitsOnOrder, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'OrderDetailEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(OrderDetailEntity))]
		public virtual EntityCollection<OrderDetailEntity> OrderDetails
		{
			get { return GetOrCreateEntityCollection<OrderDetailEntity, OrderDetailEntityFactory>("Products", true, false, ref _orderDetails);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'OrderEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(OrderEntity))]
		public virtual EntityCollection<OrderEntity> OrdersCollectionViaOrderDetails
		{
			get { return GetOrCreateEntityCollection<OrderEntity, OrderEntityFactory>("ProductsCollectionViaOrderDetails", false, true, ref _ordersCollectionViaOrderDetails);	}
		}

		/// <summary> Gets / sets related entity of type 'CategoryEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual CategoryEntity Categories
		{
			get	{ return _categories; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncCategories(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Products", "Categories", _categories, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'SupplierEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual SupplierEntity Suppliers
		{
			get	{ return _suppliers; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncSuppliers(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Products", "Suppliers", _suppliers, true); 
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
		
		/// <summary>Returns the SD.LLBLGen.Pro.Examples.Auditing.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.ProductEntity; }
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
