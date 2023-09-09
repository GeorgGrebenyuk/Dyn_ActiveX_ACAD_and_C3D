namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccUserDefinedProperty 
	{
		public AeccXLandLib.IAeccUserDefinedProperty _i;
		internal AeccUserDefinedProperty(object AeccUserDefinedProperty_object) 
		{
			this._i = AeccUserDefinedProperty_object as AeccXLandLib.IAeccUserDefinedProperty;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public string Description => this._i.Description;

		///<summary>
		///
		///</summary>
		public void Set_Description(string pVal) 
		{
			this._i.Description = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic PropertyFieldType => this._i.PropertyFieldType;

		///<summary>
		///
		///</summary>
		public void Set_PropertyFieldType(AeccXLandLib.AeccUDPPropertyFieldType pVal) 
		{
			this._i.PropertyFieldType = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool LowerBoundInclusive => this._i.LowerBoundInclusive;

		///<summary>
		///
		///</summary>
		public void Set_LowerBoundInclusive(bool pVal) 
		{
			this._i.LowerBoundInclusive = pVal;
		}

		///<summary>
		///
		///</summary>
		public object LowerBoundValue => this._i.LowerBoundValue;

		///<summary>
		///
		///</summary>
		public void Set_LowerBoundValue(object pVal) 
		{
			this._i.LowerBoundValue = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UpperBoundInclusive => this._i.UpperBoundInclusive;

		///<summary>
		///
		///</summary>
		public void Set_UpperBoundInclusive(bool pVal) 
		{
			this._i.UpperBoundInclusive = pVal;
		}

		///<summary>
		///
		///</summary>
		public object UpperBoundValue => this._i.UpperBoundValue;

		///<summary>
		///
		///</summary>
		public void Set_UpperBoundValue(object pVal) 
		{
			this._i.UpperBoundValue = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UseDefaultValue => this._i.UseDefaultValue;

		///<summary>
		///
		///</summary>
		public void Set_UseDefaultValue(bool pVal) 
		{
			this._i.UseDefaultValue = pVal;
		}

		///<summary>
		///
		///</summary>
		public object DefaultValue => this._i.DefaultValue;

		///<summary>
		///
		///</summary>
		public void Set_DefaultValue(object pVal) 
		{
			this._i.DefaultValue = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Classification => this._i.Classification;

		///<summary>
		///
		///</summary>
		public dynamic AttrId => this._i.AttrId;
	}
}
