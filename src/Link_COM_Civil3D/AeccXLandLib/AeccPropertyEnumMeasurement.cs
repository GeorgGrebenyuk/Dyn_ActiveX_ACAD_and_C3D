namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumMeasurement 
	{
		public AeccXLandLib.IAeccPropertyEnumMeasurement _i;
		internal AeccPropertyEnumMeasurement(object AeccPropertyEnumMeasurement_object) 
		{
			this._i = AeccPropertyEnumMeasurement_object as AeccXLandLib.IAeccPropertyEnumMeasurement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccMeasurementType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
