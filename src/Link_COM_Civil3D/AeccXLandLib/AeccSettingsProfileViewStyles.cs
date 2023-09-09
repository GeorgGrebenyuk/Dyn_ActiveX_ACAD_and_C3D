namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsProfileViewStyles 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsProfileViewStyles _i;
		internal AeccSettingsProfileViewStyles(object AeccSettingsProfileViewStyles_object) 
		{
			this._i = AeccSettingsProfileViewStyles_object as Autodesk.AECC.Interop.Land.IAeccSettingsProfileViewStyles;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Style => this._i.Style;

		///<summary>
		///
		///</summary>
		public dynamic PointStyle => this._i.PointStyle;

		///<summary>
		///
		///</summary>
		public dynamic BandStyleSet => this._i.BandStyleSet;

		///<summary>
		///
		///</summary>
		public dynamic StationElevationLabelStyle => this._i.StationElevationLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic DepthLabelStyle => this._i.DepthLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic LabelStyleSet => this._i.LabelStyleSet;

		///<summary>
		///
		///</summary>
		public dynamic LabelAnchorMarkerStyle => this._i.LabelAnchorMarkerStyle;

		///<summary>
		///
		///</summary>
		public dynamic FirstSplitViewStyle => this._i.FirstSplitViewStyle;

		///<summary>
		///
		///</summary>
		public dynamic IntermediateSplitViewStyle => this._i.IntermediateSplitViewStyle;

		///<summary>
		///
		///</summary>
		public dynamic LastSplitViewStyle => this._i.LastSplitViewStyle;
	}
}
