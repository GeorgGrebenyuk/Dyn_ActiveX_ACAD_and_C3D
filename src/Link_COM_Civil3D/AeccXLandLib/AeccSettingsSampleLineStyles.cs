namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsSampleLineStyles 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsSampleLineStyles _i;
		internal AeccSettingsSampleLineStyles(object AeccSettingsSampleLineStyles_object) 
		{
			this._i = AeccSettingsSampleLineStyles_object as Autodesk.AECC.Interop.Land.IAeccSettingsSampleLineStyles;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Style => this._i.Style;

		///<summary>
		///
		///</summary>
		public dynamic GroupStyle => this._i.GroupStyle;

		///<summary>
		///
		///</summary>
		public dynamic LabelStyle => this._i.LabelStyle;
	}
}
