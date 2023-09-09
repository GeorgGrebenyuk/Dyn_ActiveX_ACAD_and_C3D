namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccMarkerStyle 
	{
		public Autodesk.AECC.Interop.Land.IAeccMarkerStyle _i;
		internal AeccMarkerStyle(object AeccMarkerStyle_object) 
		{
			this._i = AeccMarkerStyle_object as Autodesk.AECC.Interop.Land.IAeccMarkerStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic MarkerType => this._i.MarkerType;

		///<summary>
		///
		///</summary>
		public void Set_MarkerType(Autodesk.AECC.Interop.Land.AeccMarkerDisplayType pVal) 
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
		public void Set_CustomMarkerStyle(Autodesk.AECC.Interop.Land.AeccCustomMarkerType pVal) 
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
		public void Set_CustomMarkerSuperimposeStyle(Autodesk.AECC.Interop.Land.AeccCustomMarkerSuperimposeType pVal) 
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
		public void Set_MarkerSizeType(Autodesk.AECC.Interop.Land.AeccMarkerSizeType pVal) 
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
		public dynamic Orientation => this._i.Orientation;

		///<summary>
		///
		///</summary>
		public void Set_Orientation(Autodesk.AECC.Interop.Land.AeccMarkerOrientationType pVal) 
		{
			this._i.Orientation = pVal;
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
	}
}
