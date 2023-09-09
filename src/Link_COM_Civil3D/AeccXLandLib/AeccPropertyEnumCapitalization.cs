namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumCapitalization 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumCapitalization _i;
		internal AeccPropertyEnumCapitalization(object AeccPropertyEnumCapitalization_object) 
		{
			this._i = AeccPropertyEnumCapitalization_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumCapitalization;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccCapitalizationType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
