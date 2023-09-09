namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsPointStyles 
	{
		public AeccXLandLib.IAeccSettingsPointStyles _i;
		internal AeccSettingsPointStyles(object AeccSettingsPointStyles_object) 
		{
			this._i = AeccSettingsPointStyles_object as AeccXLandLib.IAeccSettingsPointStyles;
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
