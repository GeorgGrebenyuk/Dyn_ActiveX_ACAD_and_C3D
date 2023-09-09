namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccFeatureLineStyle 
	{
		public AeccXLandLib.IAeccFeatureLineStyle _i;
		internal AeccFeatureLineStyle(object AeccFeatureLineStyle_object) 
		{
			this._i = AeccFeatureLineStyle_object as AeccXLandLib.IAeccFeatureLineStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic FeatureLineDisplayStylePlan => this._i.FeatureLineDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic FeatureLineDisplayStyleModel => this._i.FeatureLineDisplayStyleModel;

		///<summary>
		///
		///</summary>
		public dynamic SectionMarkerStyle => this._i.SectionMarkerStyle;

		///<summary>
		///
		///</summary>
		public void Set_SectionMarkerStyle(object pValue) 
		{
			this._i.SectionMarkerStyle = pValue;
		}

		///<summary>
		///
		///</summary>
		public dynamic SectionMarkerDisplayStyleSection => this._i.SectionMarkerDisplayStyleSection;
	}
}
