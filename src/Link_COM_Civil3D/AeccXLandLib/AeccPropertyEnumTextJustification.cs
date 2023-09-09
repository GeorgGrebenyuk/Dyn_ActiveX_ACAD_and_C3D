namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumTextJustification 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumTextJustification _i;
		internal AeccPropertyEnumTextJustification(object AeccPropertyEnumTextJustification_object) 
		{
			this._i = AeccPropertyEnumTextJustification_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumTextJustification;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccTextJustificationType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
