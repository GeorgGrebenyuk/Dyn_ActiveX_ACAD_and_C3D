namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccUserDefinedProperties 
	{
		public Autodesk.AECC.Interop.Land.IAeccUserDefinedProperties _i;
		internal AeccUserDefinedProperties(object AeccUserDefinedProperties_object) 
		{
			this._i = AeccUserDefinedProperties_object as Autodesk.AECC.Interop.Land.IAeccUserDefinedProperties;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Item(object Index) 
		{
			return this._i.Item(Index);
		}

		///<summary>
		///
		///</summary>
		public dynamic Add(string Name,string Description,Autodesk.AECC.Interop.Land.AeccUDPPropertyFieldType PropertyFieldType,bool bLowerBoundInclusive,bool bUseDefaultLowerBoundValue,object LowerBoundValue,bool bUpperBoundInclusive,bool bUseDefaultUpperBoundValue,object UpperBoundValue,bool bUseDefaultValue,object DefaultValue,object EnumStringArray) 
		{
			return this._i.Add(Name,Description,PropertyFieldType,bLowerBoundInclusive,bUseDefaultLowerBoundValue,LowerBoundValue,bUpperBoundInclusive,bUseDefaultUpperBoundValue,UpperBoundValue,bUseDefaultValue,DefaultValue,EnumStringArray);
		}

		///<summary>
		///
		///</summary>
		public void Remove(object Index) 
		{
			this._i.Remove(Index);
		}
	}
}
