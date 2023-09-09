namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumQTOPipeLengthType 
	{
		public AeccXRoadwayLib.IAeccPropertyEnumQTOPipeLengthType _i;
		internal AeccPropertyEnumQTOPipeLengthType(object AeccPropertyEnumQTOPipeLengthType_object) 
		{
			this._i = AeccPropertyEnumQTOPipeLengthType_object as AeccXRoadwayLib.IAeccPropertyEnumQTOPipeLengthType;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXRoadwayLib.AeccQTOPipeLengthType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
