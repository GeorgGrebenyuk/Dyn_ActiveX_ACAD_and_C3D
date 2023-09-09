namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceWatershedPointSegmentStyle 
	{
		public Autodesk.AECC.Interop.Land.IAeccSurfaceWatershedPointSegmentStyle _i;
		internal AeccSurfaceWatershedPointSegmentStyle(object AeccSurfaceWatershedPointSegmentStyle_object) 
		{
			this._i = AeccSurfaceWatershedPointSegmentStyle_object as Autodesk.AECC.Interop.Land.IAeccSurfaceWatershedPointSegmentStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public bool DrawDrainTargetPoint => this._i.DrawDrainTargetPoint;

		///<summary>
		///
		///</summary>
		public void Set_DrawDrainTargetPoint(bool pVal) 
		{
			this._i.DrawDrainTargetPoint = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic DrainTargetPointDisplayType => this._i.DrainTargetPointDisplayType;

		///<summary>
		///
		///</summary>
		public void Set_DrainTargetPointDisplayType(dynamic pVal) 
		{
			this._i.DrainTargetPointDisplayType = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic DrainTargetPointColor => this._i.DrainTargetPointColor;

		///<summary>
		///
		///</summary>
		public void Set_DrainTargetPointColor(dynamic pVal) 
		{
			this._i.DrainTargetPointColor = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic DrainTargetPointTrueColor => this._i.DrainTargetPointTrueColor;

		///<summary>
		///
		///</summary>
		public void Put_DrainTargetPointTrueColor(dynamic pVal) 
		{
			this._i.DrainTargetPointTrueColor = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool DrawDrainTargetSegment => this._i.DrawDrainTargetSegment;

		///<summary>
		///
		///</summary>
		public void Set_DrawDrainTargetSegment(bool pVal) 
		{
			this._i.DrawDrainTargetSegment = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic DrainTargetSegmentColor => this._i.DrainTargetSegmentColor;

		///<summary>
		///
		///</summary>
		public void Set_DrainTargetSegmentColor(dynamic pVal) 
		{
			this._i.DrainTargetSegmentColor = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic DrainTargetSegmentTrueColor => this._i.DrainTargetSegmentTrueColor;

		///<summary>
		///
		///</summary>
		public void Put_DrainTargetSegmentTrueColor(dynamic pVal) 
		{
			this._i.DrainTargetSegmentTrueColor = pVal;
		}

		///<summary>
		///
		///</summary>
		public string DrainTargetSegmentLinetype => this._i.DrainTargetSegmentLinetype;

		///<summary>
		///
		///</summary>
		public void Set_DrainTargetSegmentLinetype(string pVal) 
		{
			this._i.DrainTargetSegmentLinetype = pVal;
		}
	}
}
