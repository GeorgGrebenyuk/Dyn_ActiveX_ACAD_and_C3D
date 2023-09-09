namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumQTOPipeLengthType 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccPropertyEnumQTOPipeLengthType _i;
		internal AeccPropertyEnumQTOPipeLengthType(object AeccPropertyEnumQTOPipeLengthType_object) 
		{
			this._i = AeccPropertyEnumQTOPipeLengthType_object as Autodesk.AECC.Interop.Roadway.IAeccPropertyEnumQTOPipeLengthType;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Roadway.AeccQTOPipeLengthType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
