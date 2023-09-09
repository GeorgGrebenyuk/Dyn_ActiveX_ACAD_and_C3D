namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumAnchorLocation 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumAnchorLocation _i;
		internal AeccPropertyEnumAnchorLocation(object AeccPropertyEnumAnchorLocation_object) 
		{
			this._i = AeccPropertyEnumAnchorLocation_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumAnchorLocation;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccAnchorLocationType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
