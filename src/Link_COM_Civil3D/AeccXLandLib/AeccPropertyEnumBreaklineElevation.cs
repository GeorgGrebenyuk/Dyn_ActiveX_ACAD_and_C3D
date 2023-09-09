namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumBreaklineElevation 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumBreaklineElevation _i;
		internal AeccPropertyEnumBreaklineElevation(object AeccPropertyEnumBreaklineElevation_object) 
		{
			this._i = AeccPropertyEnumBreaklineElevation_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumBreaklineElevation;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccBreaklineElevationToUseType pValue) 
		{
			this._i.Value = pValue;
		}
	}
}
