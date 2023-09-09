namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccBandProfileDataStyle 
	{
		public AeccXLandLib.IAeccBandProfileDataStyle _i;
		internal AeccBandProfileDataStyle(object AeccBandProfileDataStyle_object) 
		{
			this._i = AeccBandProfileDataStyle_object as AeccXLandLib.IAeccBandProfileDataStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic MajorIncrementLabelStyle => this._i.MajorIncrementLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic MinorIncrementLabelStyle => this._i.MinorIncrementLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic StationEquationLabelStyle => this._i.StationEquationLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic HGPLabelStyle => this._i.HGPLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic VGPLabelStyle => this._i.VGPLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic MajorTickDisplayStyle2d => this._i.MajorTickDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic MinorTickDisplayStyle2d => this._i.MinorTickDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic VGPTickDisplayStyle2d => this._i.VGPTickDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic HGPTickDisplayStyle2d => this._i.HGPTickDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic MajorStationLabelDisplayStyle2d => this._i.MajorStationLabelDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic MinorStationLabelDisplayStyle2d => this._i.MinorStationLabelDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic VGPLabelDisplayStyle2d => this._i.VGPLabelDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic HGPLabelDisplayStyle2d => this._i.HGPLabelDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic StationEquationTickDisplayStyle2d => this._i.StationEquationTickDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic StationEquationLabelDisplayStyle2d => this._i.StationEquationLabelDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic MajorTickDisplayStylePlan => this._i.MajorTickDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic MinorTickDisplayStylePlan => this._i.MinorTickDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic VGPTickDisplayStylePlan => this._i.VGPTickDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic HGPTickDisplayStylePlan => this._i.HGPTickDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic MajorStationLabelDisplayStylePlan => this._i.MajorStationLabelDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic MinorStationLabelDisplayStylePlan => this._i.MinorStationLabelDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic VGPLabelDisplayStylePlan => this._i.VGPLabelDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic HGPLabelDisplayStylePlan => this._i.HGPLabelDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic StationEquationTickDisplayStylePlan => this._i.StationEquationTickDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic StationEquationLabelDisplayStylePlan => this._i.StationEquationLabelDisplayStylePlan;
	}
}
