namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccTinVolumeSurfaceDefinitionProperties 
	{
		public Autodesk.AECC.Interop.Land.IAeccTinVolumeSurfaceDefinitionProperties _i;
		internal AeccTinVolumeSurfaceDefinitionProperties(object AeccTinVolumeSurfaceDefinitionProperties_object) 
		{
			this._i = AeccTinVolumeSurfaceDefinitionProperties_object as Autodesk.AECC.Interop.Land.IAeccTinVolumeSurfaceDefinitionProperties;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public bool UseMaximumTriangleLength => this._i.UseMaximumTriangleLength;

		///<summary>
		///
		///</summary>
		public void Set_UseMaximumTriangleLength(bool pVal) 
		{
			this._i.UseMaximumTriangleLength = pVal;
		}

		///<summary>
		///
		///</summary>
		public double MaximumTriangleLength => this._i.MaximumTriangleLength;

		///<summary>
		///
		///</summary>
		public void Set_MaximumTriangleLength(double pVal) 
		{
			this._i.MaximumTriangleLength = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool ConvertToStandardBreaklines => this._i.ConvertToStandardBreaklines;

		///<summary>
		///
		///</summary>
		public void Set_ConvertToStandardBreaklines(bool pVal) 
		{
			this._i.ConvertToStandardBreaklines = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool AllowCrossingBreaklines => this._i.AllowCrossingBreaklines;

		///<summary>
		///
		///</summary>
		public void Set_AllowCrossingBreaklines(bool pVal) 
		{
			this._i.AllowCrossingBreaklines = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic ElevationToUse => this._i.ElevationToUse;

		///<summary>
		///
		///</summary>
		public void Set_ElevationToUse(Autodesk.AECC.Interop.Land.AeccBreaklineElevationToUseType pVal) 
		{
			this._i.ElevationToUse = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UseAddLine => this._i.UseAddLine;

		///<summary>
		///
		///</summary>
		public void Set_UseAddLine(bool pVal) 
		{
			this._i.UseAddLine = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UseSwapEdge => this._i.UseSwapEdge;

		///<summary>
		///
		///</summary>
		public void Set_UseSwapEdge(bool pVal) 
		{
			this._i.UseSwapEdge = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UseMinimizeFlatFaces => this._i.UseMinimizeFlatFaces;

		///<summary>
		///
		///</summary>
		public void Set_UseMinimizeFlatFaces(bool pVal) 
		{
			this._i.UseMinimizeFlatFaces = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UseMovePoint => this._i.UseMovePoint;

		///<summary>
		///
		///</summary>
		public void Set_UseMovePoint(bool pVal) 
		{
			this._i.UseMovePoint = pVal;
		}
	}
}
