namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumTextJustification 
	{
		public AeccXLandLib.IAeccPropertyEnumTextJustification _i;
		internal AeccPropertyEnumTextJustification(object AeccPropertyEnumTextJustification_object) 
		{
			this._i = AeccPropertyEnumTextJustification_object as AeccXLandLib.IAeccPropertyEnumTextJustification;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccTextJustificationType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
