namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsPointStyles 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsPointStyles _i;
		internal AeccSettingsPointStyles(object AeccSettingsPointStyles_object) 
		{
			this._i = AeccSettingsPointStyles_object as Autodesk.AECC.Interop.Land.IAeccSettingsPointStyles;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Style => this._i.Style;

		///<summary>
		///
		///</summary>
		public dynamic LabelStyle => this._i.LabelStyle;
	}
}
