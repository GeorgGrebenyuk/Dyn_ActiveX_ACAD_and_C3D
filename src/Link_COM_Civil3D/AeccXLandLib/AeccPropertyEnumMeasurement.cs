namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumMeasurement 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumMeasurement _i;
		internal AeccPropertyEnumMeasurement(object AeccPropertyEnumMeasurement_object) 
		{
			this._i = AeccPropertyEnumMeasurement_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumMeasurement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccMeasurementType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
