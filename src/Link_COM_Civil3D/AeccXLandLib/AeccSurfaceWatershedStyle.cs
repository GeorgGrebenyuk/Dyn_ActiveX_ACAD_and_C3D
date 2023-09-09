namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceWatershedStyle 
	{
		public AeccXLandLib.IAeccSurfaceWatershedStyle _i;
		internal AeccSurfaceWatershedStyle(object AeccSurfaceWatershedStyle_object) 
		{
			this._i = AeccSurfaceWatershedStyle_object as AeccXLandLib.IAeccSurfaceWatershedStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic PointScalingMethodType => this._i.PointScalingMethodType;

		///<summary>
		///
		///</summary>
		public void Set_PointScalingMethodType(AeccXLandLib.AeccScalingMethodType pVal) 
		{
			this._i.PointScalingMethodType = pVal;
		}

		///<summary>
		///
		///</summary>
		public double PointScale => this._i.PointScale;

		///<summary>
		///
		///</summary>
		public void Set_PointScale(double pVal) 
		{
			this._i.PointScale = pVal;
		}

		///<summary>
		///
		///</summary>
		public string LegendStyle => this._i.LegendStyle;

		///<summary>
		///
		///</summary>
		public void Set_LegendStyle(string pVal) 
		{
			this._i.LegendStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic BoundaryPointStyle => this._i.BoundaryPointStyle;

		///<summary>
		///
		///</summary>
		public dynamic BoundarySegmentStyle => this._i.BoundarySegmentStyle;

		///<summary>
		///
		///</summary>
		public dynamic DepressionStyle => this._i.DepressionStyle;

		///<summary>
		///
		///</summary>
		public dynamic FlatAreaStyle => this._i.FlatAreaStyle;

		///<summary>
		///
		///</summary>
		public dynamic MultiDrainStyle => this._i.MultiDrainStyle;

		///<summary>
		///
		///</summary>
		public dynamic MultiDrainNotchStyle => this._i.MultiDrainNotchStyle;

		///<summary>
		///
		///</summary>
		public dynamic DisplayStyle2d => this._i.DisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic DisplayStyle3d => this._i.DisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic DisplayStylePlan => this._i.DisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic DisplayStyleModel => this._i.DisplayStyleModel;
	}
}
