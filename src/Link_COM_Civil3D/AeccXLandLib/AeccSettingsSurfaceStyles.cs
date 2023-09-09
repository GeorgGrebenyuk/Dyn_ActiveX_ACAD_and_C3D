namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsSurfaceStyles 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsSurfaceStyles _i;
		internal AeccSettingsSurfaceStyles(object AeccSettingsSurfaceStyles_object) 
		{
			this._i = AeccSettingsSurfaceStyles_object as Autodesk.AECC.Interop.Land.IAeccSettingsSurfaceStyles;
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
		public dynamic SpotElevationLabelStyle => this._i.SpotElevationLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic SlopeLabelStyle => this._i.SlopeLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic ContourLabelStyle => this._i.ContourLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic MinorContourLabelStyle => this._i.MinorContourLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic UserDefinedContourLabelStyle => this._i.UserDefinedContourLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic RenderMaterialStyle => this._i.RenderMaterialStyle;

		///<summary>
		///
		///</summary>
		public dynamic LabelAnchorMarkerStyle => this._i.LabelAnchorMarkerStyle;
	}
}
