namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyTrueColor 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyTrueColor _i;
		internal AeccPropertyTrueColor(object AeccPropertyTrueColor_object) 
		{
			this._i = AeccPropertyTrueColor_object as Autodesk.AECC.Interop.Land.IAeccPropertyTrueColor;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Put_Value(dynamic pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
