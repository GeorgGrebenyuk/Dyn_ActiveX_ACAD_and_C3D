namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceWatershedPointStyle 
	{
		public Autodesk.AECC.Interop.Land.IAeccSurfaceWatershedPointStyle _i;
		internal AeccSurfaceWatershedPointStyle(object AeccSurfaceWatershedPointStyle_object) 
		{
			this._i = AeccSurfaceWatershedPointStyle_object as Autodesk.AECC.Interop.Land.IAeccSurfaceWatershedPointStyle;
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
	}
}
