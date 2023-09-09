namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceWatershedSegmentStyle 
	{
		public Autodesk.AECC.Interop.Land.IAeccSurfaceWatershedSegmentStyle _i;
		internal AeccSurfaceWatershedSegmentStyle(object AeccSurfaceWatershedSegmentStyle_object) 
		{
			this._i = AeccSurfaceWatershedSegmentStyle_object as Autodesk.AECC.Interop.Land.IAeccSurfaceWatershedSegmentStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
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
