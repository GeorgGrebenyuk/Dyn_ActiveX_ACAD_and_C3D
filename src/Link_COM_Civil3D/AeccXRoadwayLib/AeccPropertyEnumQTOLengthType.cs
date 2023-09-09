namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumQTOLengthType 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccPropertyEnumQTOLengthType _i;
		internal AeccPropertyEnumQTOLengthType(object AeccPropertyEnumQTOLengthType_object) 
		{
			this._i = AeccPropertyEnumQTOLengthType_object as Autodesk.AECC.Interop.Roadway.IAeccPropertyEnumQTOLengthType;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Roadway.AeccQTOLengthType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
