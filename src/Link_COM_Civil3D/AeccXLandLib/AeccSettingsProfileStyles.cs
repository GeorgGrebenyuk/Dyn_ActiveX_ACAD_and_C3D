namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsProfileStyles 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsProfileStyles _i;
		internal AeccSettingsProfileStyles(object AeccSettingsProfileStyles_object) 
		{
			this._i = AeccSettingsProfileStyles_object as Autodesk.AECC.Interop.Land.IAeccSettingsProfileStyles;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Style => this._i.Style;
	}
}
