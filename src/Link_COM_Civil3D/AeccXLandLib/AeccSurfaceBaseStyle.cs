namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceBaseStyle 
	{
		public Autodesk.AECC.Interop.Land.IAeccSurfaceBaseStyle _i;
		internal AeccSurfaceBaseStyle(object AeccSurfaceBaseStyle_object) 
		{
			this._i = AeccSurfaceBaseStyle_object as Autodesk.AECC.Interop.Land.IAeccSurfaceBaseStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Display3dType => this._i.Display3dType;

		///<summary>
		///
		///</summary>
		public void Set_Display3dType(Autodesk.AECC.Interop.Land.AeccDisplay3dType pVal) 
		{
			this._i.Display3dType = pVal;
		}

		///<summary>
		///
		///</summary>
		public double FlattenToElevationBy => this._i.FlattenToElevationBy;

		///<summary>
		///
		///</summary>
		public void Set_FlattenToElevationBy(double pVal) 
		{
			this._i.FlattenToElevationBy = pVal;
		}

		///<summary>
		///
		///</summary>
		public double ExaggerateElevationBy => this._i.ExaggerateElevationBy;

		///<summary>
		///
		///</summary>
		public void Set_ExaggerateElevationBy(double pVal) 
		{
			this._i.ExaggerateElevationBy = pVal;
		}
	}
}
