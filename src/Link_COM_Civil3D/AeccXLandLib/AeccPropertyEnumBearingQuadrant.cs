namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumBearingQuadrant 
	{
		public AeccXLandLib.IAeccPropertyEnumBearingQuadrant _i;
		internal AeccPropertyEnumBearingQuadrant(object AeccPropertyEnumBearingQuadrant_object) 
		{
			this._i = AeccPropertyEnumBearingQuadrant_object as AeccXLandLib.IAeccPropertyEnumBearingQuadrant;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccBearingQuadrantType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
