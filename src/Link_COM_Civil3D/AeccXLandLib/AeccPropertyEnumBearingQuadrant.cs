namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumBearingQuadrant 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumBearingQuadrant _i;
		internal AeccPropertyEnumBearingQuadrant(object AeccPropertyEnumBearingQuadrant_object) 
		{
			this._i = AeccPropertyEnumBearingQuadrant_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumBearingQuadrant;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccBearingQuadrantType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
