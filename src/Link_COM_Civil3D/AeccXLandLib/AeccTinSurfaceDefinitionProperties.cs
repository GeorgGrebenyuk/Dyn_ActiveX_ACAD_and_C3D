namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccTinSurfaceDefinitionProperties 
	{
		public AeccXLandLib.IAeccTinSurfaceDefinitionProperties _i;
		internal AeccTinSurfaceDefinitionProperties(object AeccTinSurfaceDefinitionProperties_object) 
		{
			this._i = AeccTinSurfaceDefinitionProperties_object as AeccXLandLib.IAeccTinSurfaceDefinitionProperties;
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
		public void Set_ElevationToUse(AeccXLandLib.AeccBreaklineElevationToUseType pVal) 
		{
			this._i.ElevationToUse = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UseBreaklines => this._i.UseBreaklines;

		///<summary>
		///
		///</summary>
		public void Set_UseBreaklines(bool pVal) 
		{
			this._i.UseBreaklines = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UseContourData => this._i.UseContourData;

		///<summary>
		///
		///</summary>
		public void Set_UseContourData(bool pVal) 
		{
			this._i.UseContourData = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UseDEMFiles => this._i.UseDEMFiles;

		///<summary>
		///
		///</summary>
		public void Set_UseDEMFiles(bool pVal) 
		{
			this._i.UseDEMFiles = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UsePointFiles => this._i.UsePointFiles;

		///<summary>
		///
		///</summary>
		public void Set_UsePointFiles(bool pVal) 
		{
			this._i.UsePointFiles = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UsePointGroups => this._i.UsePointGroups;

		///<summary>
		///
		///</summary>
		public void Set_UsePointGroups(bool pVal) 
		{
			this._i.UsePointGroups = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UseDrawingObjects => this._i.UseDrawingObjects;

		///<summary>
		///
		///</summary>
		public void Set_UseDrawingObjects(bool pVal) 
		{
			this._i.UseDrawingObjects = pVal;
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
		public bool UseSmoothSurface => this._i.UseSmoothSurface;

		///<summary>
		///
		///</summary>
		public void Set_UseSmoothSurface(bool pVal) 
		{
			this._i.UseSmoothSurface = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UsePasteSurface => this._i.UsePasteSurface;

		///<summary>
		///
		///</summary>
		public void Set_UsePasteSurface(bool pVal) 
		{
			this._i.UsePasteSurface = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UseImportLandXML => this._i.UseImportLandXML;

		///<summary>
		///
		///</summary>
		public void Set_UseImportLandXML(bool pVal) 
		{
			this._i.UseImportLandXML = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UseImportTIN => this._i.UseImportTIN;

		///<summary>
		///
		///</summary>
		public void Set_UseImportTIN(bool pVal) 
		{
			this._i.UseImportTIN = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UseRaiseLowerSurface => this._i.UseRaiseLowerSurface;

		///<summary>
		///
		///</summary>
		public void Set_UseRaiseLowerSurface(bool pVal) 
		{
			this._i.UseRaiseLowerSurface = pVal;
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
