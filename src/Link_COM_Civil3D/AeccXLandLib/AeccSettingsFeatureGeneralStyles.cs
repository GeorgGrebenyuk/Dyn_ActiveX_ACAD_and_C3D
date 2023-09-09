namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsFeatureGeneralStyles 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsFeatureGeneralStyles _i;
		internal AeccSettingsFeatureGeneralStyles(object AeccSettingsFeatureGeneralStyles_object) 
		{
			this._i = AeccSettingsFeatureGeneralStyles_object as Autodesk.AECC.Interop.Land.IAeccSettingsFeatureGeneralStyles;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic NoteLabelStyle => this._i.NoteLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic LineLabelStyle => this._i.LineLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic CurveLabelStyle => this._i.CurveLabelStyle;
	}
}
