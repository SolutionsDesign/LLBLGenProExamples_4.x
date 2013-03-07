///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.0
// Code is generated on: donderdag 19 juli 2012 13:46:12
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using Northwind.SSDAL;
using Northwind.SSDAL.FactoryClasses;
using Northwind.SSDAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.SSDAL.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Region. </summary>
	public partial class RegionRelations
	{
		/// <summary>CTor</summary>
		public RegionRelations()
		{
		}

		/// <summary>Gets all relations of the RegionEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.EmployeeEntityUsingRegionId);
			toReturn.Add(this.TerritoryEntityUsingRegionId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between RegionEntity and EmployeeEntity over the 1:n relation they have, using the relation between the fields:
		/// Region.RegionId - Employee.RegionId
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingRegionId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Employees" , true);
				relation.AddEntityFieldPair(RegionFields.RegionId, EmployeeFields.RegionId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RegionEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between RegionEntity and TerritoryEntity over the 1:n relation they have, using the relation between the fields:
		/// Region.RegionId - Territory.RegionId
		/// </summary>
		public virtual IEntityRelation TerritoryEntityUsingRegionId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Territories" , true);
				relation.AddEntityFieldPair(RegionFields.RegionId, TerritoryFields.RegionId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RegionEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TerritoryEntity", false);
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
	internal static class StaticRegionRelations
	{
		internal static readonly IEntityRelation EmployeeEntityUsingRegionIdStatic = new RegionRelations().EmployeeEntityUsingRegionId;
		internal static readonly IEntityRelation TerritoryEntityUsingRegionIdStatic = new RegionRelations().TerritoryEntityUsingRegionId;

		/// <summary>CTor</summary>
		static StaticRegionRelations()
		{
		}
	}
}
