namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumBreaklineElevation 
	{
		public AeccXLandLib.IAeccPropertyEnumBreaklineElevation _i;
		internal AeccPropertyEnumBreaklineElevation(object AeccPropertyEnumBreaklineElevation_object) 
		{
			this._i = AeccPropertyEnumBreaklineElevation_object as AeccXLandLib.IAeccPropertyEnumBreaklineElevation;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccBreaklineElevationToUseType pValue) 
		{
			this._i.Value = pValue;
		}
	}
}
