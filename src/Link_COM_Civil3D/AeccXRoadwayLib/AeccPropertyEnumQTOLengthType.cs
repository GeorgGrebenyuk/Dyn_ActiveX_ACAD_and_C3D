namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumQTOLengthType 
	{
		public AeccXRoadwayLib.IAeccPropertyEnumQTOLengthType _i;
		internal AeccPropertyEnumQTOLengthType(object AeccPropertyEnumQTOLengthType_object) 
		{
			this._i = AeccPropertyEnumQTOLengthType_object as AeccXRoadwayLib.IAeccPropertyEnumQTOLengthType;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXRoadwayLib.AeccQTOLengthType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
