namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPointStyle 
	{
		public AeccXLandLib.IAeccPointStyle _i;
		internal AeccPointStyle(object AeccPointStyle_object) 
		{
			this._i = AeccPointStyle_object as AeccXLandLib.IAeccPointStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Display3dType => this._i.Display3dType;

		///<summary>
		///
		///</summary>
		public void Set_Display3dType(AeccXLandLib.AeccPointDisplay3dType pVal) 
		{
			this._i.Display3dType = pVal;
		}

		///<summary>
		///
		///</summary>
		public double Elevation => this._i.Elevation;

		///<summary>
		///
		///</summary>
		public void Set_Elevation(double pVal) 
		{
			this._i.Elevation = pVal;
		}

		///<summary>
		///
		///</summary>
		public double ScaleFactor => this._i.ScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_ScaleFactor(double pVal) 
		{
			this._i.ScaleFactor = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic MarkerType => this._i.MarkerType;

		///<summary>
		///
		///</summary>
		public void Set_MarkerType(AeccXLandLib.AeccMarkerDisplayType pVal) 
		{
			this._i.MarkerType = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic CustomMarkerStyle => this._i.CustomMarkerStyle;

		///<summary>
		///
		///</summary>
		public void Set_CustomMarkerStyle(AeccXLandLib.AeccCustomMarkerType pVal) 
		{
			this._i.CustomMarkerStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic CustomMarkerSuperimposeStyle => this._i.CustomMarkerSuperimposeStyle;

		///<summary>
		///
		///</summary>
		public void Set_CustomMarkerSuperimposeStyle(AeccXLandLib.AeccCustomMarkerSuperimposeType pVal) 
		{
			this._i.CustomMarkerSuperimposeStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public string MarkerSymbolName => this._i.MarkerSymbolName;

		///<summary>
		///
		///</summary>
		public void Set_MarkerSymbolName(string pVal) 
		{
			this._i.MarkerSymbolName = pVal;
		}

		///<summary>
		///
		///</summary>
		public double MarkerRotationAngle => this._i.MarkerRotationAngle;

		///<summary>
		///
		///</summary>
		public void Set_MarkerRotationAngle(double pVal) 
		{
			this._i.MarkerRotationAngle = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic MarkerSizeType => this._i.MarkerSizeType;

		///<summary>
		///
		///</summary>
		public void Set_MarkerSizeType(AeccXLandLib.AeccMarkerSizeType pVal) 
		{
			this._i.MarkerSizeType = pVal;
		}

		///<summary>
		///
		///</summary>
		public double MarkerSize => this._i.MarkerSize;

		///<summary>
		///
		///</summary>
		public void Set_MarkerSize(double pVal) 
		{
			this._i.MarkerSize = pVal;
		}

		///<summary>
		///
		///</summary>
		public object MarkerFixedScale => this._i.MarkerFixedScale;

		///<summary>
		///
		///</summary>
		public void Set_MarkerFixedScale(object pVal) 
		{
			this._i.MarkerFixedScale = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic OrientationReference => this._i.OrientationReference;

		///<summary>
		///
		///</summary>
		public void Set_OrientationReference(AeccXLandLib.AeccMarkerOrientationType pVal) 
		{
			this._i.OrientationReference = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic MarkerDisplayStyle2d => this._i.MarkerDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic MarkerDisplayStyle3d => this._i.MarkerDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic LabelDisplayStyle2d => this._i.LabelDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic LabelDisplayStyle3d => this._i.LabelDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic MarkerDisplayStylePlan => this._i.MarkerDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic MarkerDisplayStyleModel => this._i.MarkerDisplayStyleModel;

		///<summary>
		///
		///</summary>
		public dynamic MarkerDisplayStyleProfile => this._i.MarkerDisplayStyleProfile;

		///<summary>
		///
		///</summary>
		public dynamic MarkerDisplayStyleSection => this._i.MarkerDisplayStyleSection;

		///<summary>
		///
		///</summary>
		public dynamic LabelDisplayStylePlan => this._i.LabelDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic LabelDisplayStyleModel => this._i.LabelDisplayStyleModel;
	}
}
