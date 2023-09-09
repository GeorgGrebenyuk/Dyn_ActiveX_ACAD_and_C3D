namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumAngleUnit 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumAngleUnit _i;
		internal AeccPropertyEnumAngleUnit(object AeccPropertyEnumAngleUnit_object) 
		{
			this._i = AeccPropertyEnumAngleUnit_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumAngleUnit;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccAngleUnitType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
