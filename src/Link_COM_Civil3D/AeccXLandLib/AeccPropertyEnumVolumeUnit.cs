namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumVolumeUnit 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumVolumeUnit _i;
		internal AeccPropertyEnumVolumeUnit(object AeccPropertyEnumVolumeUnit_object) 
		{
			this._i = AeccPropertyEnumVolumeUnit_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumVolumeUnit;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccVolumeUnitType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
