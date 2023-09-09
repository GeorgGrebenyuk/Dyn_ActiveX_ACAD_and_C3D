namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsParcelStyles 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsParcelStyles _i;
		internal AeccSettingsParcelStyles(object AeccSettingsParcelStyles_object) 
		{
			this._i = AeccSettingsParcelStyles_object as Autodesk.AECC.Interop.Land.IAeccSettingsParcelStyles;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Style => this._i.Style;

		///<summary>
		///
		///</summary>
		public dynamic LineLabelStyle => this._i.LineLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic CurveLabelStyle => this._i.CurveLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic AreaLabelStyle => this._i.AreaLabelStyle;
	}
}
