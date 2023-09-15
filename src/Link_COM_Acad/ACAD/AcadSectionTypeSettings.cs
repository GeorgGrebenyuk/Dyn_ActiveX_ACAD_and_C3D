namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadSectionTypeSettings 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadSectionTypeSettings _i;
		internal AcadSectionTypeSettings(object AcadSectionTypeSettings_object) 
		{
			this._i = AcadSectionTypeSettings_object as Autodesk.AutoCAD.Interop.Common.AcadSectionTypeSettings;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public object GenerationOptions => this._i.GenerationOptions;

		///<summary>
		///
		///</summary>
		public void Set_GenerationOptions(Autodesk.AutoCAD.Interop.Common.AcSectionGeneration pVal) 
		{
			this._i.GenerationOptions = pVal;
		}

		///<summary>
		///
		///</summary>
		public object SourceObjects => this._i.SourceObjects;

		///<summary>
		///
		///</summary>
		public void Set_SourceObjects(object pVal) 
		{
			this._i.SourceObjects = pVal;
		}

		///<summary>
		///
		///</summary>
		public object DestinationBlock => this._i.DestinationBlock;

		///<summary>
		///
		///</summary>
		public void Set_DestinationBlock(object pVal) 
		{
			this._i.DestinationBlock = pVal;
		}

		///<summary>
		///
		///</summary>
		public string DestinationFile => this._i.DestinationFile;

		///<summary>
		///
		///</summary>
		public void Set_DestinationFile(string pVal) 
		{
			this._i.DestinationFile = pVal;
		}

		///<summary>
		///
		///</summary>
		public AcadAcCmColor IntersectionBoundaryColor => new AcadAcCmColor(this._i.IntersectionBoundaryColor);

		///<summary>
		///
		///</summary>
		public void Set_IntersectionBoundaryColor(AcadAcCmColor pColor) 
		{
			this._i.IntersectionBoundaryColor = pColor._i;
		}

		///<summary>
		///
		///</summary>
		public string IntersectionBoundaryLayer => this._i.IntersectionBoundaryLayer;

		///<summary>
		///
		///</summary>
		public void Set_IntersectionBoundaryLayer(string Layer) 
		{
			this._i.IntersectionBoundaryLayer = Layer;
		}

		///<summary>
		///
		///</summary>
		public string IntersectionBoundaryLinetype => this._i.IntersectionBoundaryLinetype;

		///<summary>
		///
		///</summary>
		public void Set_IntersectionBoundaryLinetype(string Linetype) 
		{
			this._i.IntersectionBoundaryLinetype = Linetype;
		}

		///<summary>
		///
		///</summary>
		public double IntersectionBoundaryLinetypeScale => this._i.IntersectionBoundaryLinetypeScale;

		///<summary>
		///
		///</summary>
		public void Set_IntersectionBoundaryLinetypeScale(double ltScale) 
		{
			this._i.IntersectionBoundaryLinetypeScale = ltScale;
		}

		///<summary>
		///
		///</summary>
		public string IntersectionBoundaryPlotStyleName => this._i.IntersectionBoundaryPlotStyleName;

		///<summary>
		///
		///</summary>
		public void Set_IntersectionBoundaryPlotStyleName(string plotStyle) 
		{
			this._i.IntersectionBoundaryPlotStyleName = plotStyle;
		}

		///<summary>
		///
		///</summary>
		public object IntersectionBoundaryLineweight => this._i.IntersectionBoundaryLineweight;

		///<summary>
		///
		///</summary>
		public void Set_IntersectionBoundaryLineweight(dynamic Lineweight) 
		{
			this._i.IntersectionBoundaryLineweight = Lineweight;
		}

		///<summary>
		///
		///</summary>
		public bool IntersectionBoundaryDivisionLines => this._i.IntersectionBoundaryDivisionLines;

		///<summary>
		///
		///</summary>
		public void Set_IntersectionBoundaryDivisionLines(bool pVal) 
		{
			this._i.IntersectionBoundaryDivisionLines = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool IntersectionFillVisible => this._i.IntersectionFillVisible;

		///<summary>
		///
		///</summary>
		public void Set_IntersectionFillVisible(bool pVal) 
		{
			this._i.IntersectionFillVisible = pVal;
		}

		///<summary>
		///
		///</summary>
		public object IntersectionFillHatchPatternType => this._i.IntersectionFillHatchPatternType;

		///<summary>
		///
		///</summary>
		public void Set_IntersectionFillHatchPatternType(Autodesk.AutoCAD.Interop.Common.AcPatternType pVal) 
		{
			this._i.IntersectionFillHatchPatternType = pVal;
		}

		///<summary>
		///
		///</summary>
		public string IntersectionFillHatchPatternName => this._i.IntersectionFillHatchPatternName;

		///<summary>
		///
		///</summary>
		public void Set_IntersectionFillHatchPatternName(string pVal) 
		{
			this._i.IntersectionFillHatchPatternName = pVal;
		}

		///<summary>
		///
		///</summary>
		public double IntersectionFillHatchAngle => this._i.IntersectionFillHatchAngle;

		///<summary>
		///
		///</summary>
		public void Set_IntersectionFillHatchAngle(double pVal) 
		{
			this._i.IntersectionFillHatchAngle = pVal;
		}

		///<summary>
		///
		///</summary>
		public double IntersectionFillHatchScale => this._i.IntersectionFillHatchScale;

		///<summary>
		///
		///</summary>
		public void Set_IntersectionFillHatchScale(double pVal) 
		{
			this._i.IntersectionFillHatchScale = pVal;
		}

		///<summary>
		///
		///</summary>
		public double IntersectionFillHatchSpacing => this._i.IntersectionFillHatchSpacing;

		///<summary>
		///
		///</summary>
		public void Set_IntersectionFillHatchSpacing(double pVal) 
		{
			this._i.IntersectionFillHatchSpacing = pVal;
		}

		///<summary>
		///
		///</summary>
		public AcadAcCmColor IntersectionFillColor => new AcadAcCmColor(this._i.IntersectionFillColor);

		///<summary>
		///
		///</summary>
		public void Set_IntersectionFillColor(dynamic pColor) 
		{
			this._i.IntersectionFillColor = pColor;
		}

		///<summary>
		///
		///</summary>
		public string IntersectionFillLayer => this._i.IntersectionFillLayer;

		///<summary>
		///
		///</summary>
		public void Set_IntersectionFillLayer(string Layer) 
		{
			this._i.IntersectionFillLayer = Layer;
		}

		///<summary>
		///
		///</summary>
		public string IntersectionFillLinetype => this._i.IntersectionFillLinetype;

		///<summary>
		///
		///</summary>
		public void Set_IntersectionFillLinetype(string Linetype) 
		{
			this._i.IntersectionFillLinetype = Linetype;
		}

		///<summary>
		///
		///</summary>
		public double IntersectionFillLinetypeScale => this._i.IntersectionFillLinetypeScale;

		///<summary>
		///
		///</summary>
		public void Set_IntersectionFillLinetypeScale(double ltScale) 
		{
			this._i.IntersectionFillLinetypeScale = ltScale;
		}

		///<summary>
		///
		///</summary>
		public string IntersectionFillPlotStyleName => this._i.IntersectionFillPlotStyleName;

		///<summary>
		///
		///</summary>
		public void Set_IntersectionFillPlotStyleName(string plotStyle) 
		{
			this._i.IntersectionFillPlotStyleName = plotStyle;
		}

		///<summary>
		///
		///</summary>
		public object IntersectionFillLineweight => this._i.IntersectionFillLineweight;

		///<summary>
		///
		///</summary>
		public void Set_IntersectionFillLineweight(dynamic Lineweight) 
		{
			this._i.IntersectionFillLineweight = Lineweight;
		}

		///<summary>
		///
		///</summary>
		public int IntersectionFillFaceTransparency => this._i.IntersectionFillFaceTransparency;

		///<summary>
		///
		///</summary>
		public void Set_IntersectionFillFaceTransparency(int pVal) 
		{
			this._i.IntersectionFillFaceTransparency = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool BackgroundLinesVisible => this._i.BackgroundLinesVisible;

		///<summary>
		///
		///</summary>
		public void Set_BackgroundLinesVisible(bool pVal) 
		{
			this._i.BackgroundLinesVisible = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool BackgroundLinesHiddenLine => this._i.BackgroundLinesHiddenLine;

		///<summary>
		///
		///</summary>
		public void Set_BackgroundLinesHiddenLine(bool pVal) 
		{
			this._i.BackgroundLinesHiddenLine = pVal;
		}

		///<summary>
		///
		///</summary>
		public AcadAcCmColor BackgroundLinesColor => new AcadAcCmColor(this._i.BackgroundLinesColor);

		///<summary>
		///
		///</summary>
		public void Set_BackgroundLinesColor(AcadAcCmColor pColor) 
		{
			this._i.BackgroundLinesColor = pColor._i;
		}

		///<summary>
		///
		///</summary>
		public string BackgroundLinesLayer => this._i.BackgroundLinesLayer;

		///<summary>
		///
		///</summary>
		public void Set_BackgroundLinesLayer(string Layer) 
		{
			this._i.BackgroundLinesLayer = Layer;
		}

		///<summary>
		///
		///</summary>
		public string BackgroundLinesLinetype => this._i.BackgroundLinesLinetype;

		///<summary>
		///
		///</summary>
		public void Set_BackgroundLinesLinetype(string Linetype) 
		{
			this._i.BackgroundLinesLinetype = Linetype;
		}

		///<summary>
		///
		///</summary>
		public double BackgroundLinesLinetypeScale => this._i.BackgroundLinesLinetypeScale;

		///<summary>
		///
		///</summary>
		public void Set_BackgroundLinesLinetypeScale(double ltScale) 
		{
			this._i.BackgroundLinesLinetypeScale = ltScale;
		}

		///<summary>
		///
		///</summary>
		public string BackgroundLinesPlotStyleName => this._i.BackgroundLinesPlotStyleName;

		///<summary>
		///
		///</summary>
		public void Set_BackgroundLinesPlotStyleName(string plotStyle) 
		{
			this._i.BackgroundLinesPlotStyleName = plotStyle;
		}

		///<summary>
		///
		///</summary>
		public object BackgroundLinesLineweight => this._i.BackgroundLinesLineweight;

		///<summary>
		///
		///</summary>
		public void Set_BackgroundLinesLineweight(dynamic Lineweight) 
		{
			this._i.BackgroundLinesLineweight = Lineweight;
		}

		///<summary>
		///
		///</summary>
		public bool ForegroundLinesVisible => this._i.ForegroundLinesVisible;

		///<summary>
		///
		///</summary>
		public void Set_ForegroundLinesVisible(bool pVal) 
		{
			this._i.ForegroundLinesVisible = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool ForegroundLinesHiddenLine => this._i.ForegroundLinesHiddenLine;

		///<summary>
		///
		///</summary>
		public void Set_ForegroundLinesHiddenLine(bool pVal) 
		{
			this._i.ForegroundLinesHiddenLine = pVal;
		}

		///<summary>
		///
		///</summary>
		public AcadAcCmColor ForegroundLinesColor => new AcadAcCmColor(this._i.ForegroundLinesColor);

		///<summary>
		///
		///</summary>
		public void Set_ForegroundLinesColor(dynamic pColor) 
		{
			this._i.ForegroundLinesColor = pColor;
		}

		///<summary>
		///
		///</summary>
		public string ForegroundLinesLayer => this._i.ForegroundLinesLayer;

		///<summary>
		///
		///</summary>
		public void Set_ForegroundLinesLayer(string Layer) 
		{
			this._i.ForegroundLinesLayer = Layer;
		}

		///<summary>
		///
		///</summary>
		public string ForegroundLinesLinetype => this._i.ForegroundLinesLinetype;

		///<summary>
		///
		///</summary>
		public void Set_ForegroundLinesLinetype(string Linetype) 
		{
			this._i.ForegroundLinesLinetype = Linetype;
		}

		///<summary>
		///
		///</summary>
		public AcadSectionTypeSettings ForegroundLinesLinetypeScale => 
			new AcadSectionTypeSettings(this._i.ForegroundLinesLinetypeScale);

		///<summary>
		///
		///</summary>
		public void Set_ForegroundLinesLinetypeScale(dynamic ltScale) 
		{
			this._i.ForegroundLinesLinetypeScale = ltScale;
		}

		///<summary>
		///
		///</summary>
		public string ForegroundLinesPlotStyleName => this._i.ForegroundLinesPlotStyleName;

		///<summary>
		///
		///</summary>
		public void Set_ForegroundLinesPlotStyleName(string plotStyle) 
		{
			this._i.ForegroundLinesPlotStyleName = plotStyle;
		}

		///<summary>
		///
		///</summary>
		public object ForegroundLinesLineweight => this._i.ForegroundLinesLineweight;

		///<summary>
		///
		///</summary>
		public void Set_ForegroundLinesLineweight(dynamic Lineweight) 
		{
			this._i.ForegroundLinesLineweight = Lineweight;
		}

		///<summary>
		///
		///</summary>
		public AcadSectionTypeSettings ForegroundLinesFaceTransparency =>
			new AcadSectionTypeSettings(this._i.ForegroundLinesFaceTransparency);

		///<summary>
		///
		///</summary>
		public void Set_ForegroundLinesFaceTransparency(dynamic pVal) 
		{
			this._i.ForegroundLinesFaceTransparency = pVal;
		}

		///<summary>
		///
		///</summary>
		public int ForegroundLinesEdgeTransparency => this._i.ForegroundLinesEdgeTransparency;

		///<summary>
		///
		///</summary>
		public void Set_ForegroundLinesEdgeTransparency(int pVal) 
		{
			this._i.ForegroundLinesEdgeTransparency = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool CurveTangencyLinesVisible => this._i.CurveTangencyLinesVisible;

		///<summary>
		///
		///</summary>
		public void Set_CurveTangencyLinesVisible(bool pVal) 
		{
			this._i.CurveTangencyLinesVisible = pVal;
		}

		///<summary>
		///
		///</summary>
		public AcadAcCmColor CurveTangencyLinesColor => new AcadAcCmColor(this._i.CurveTangencyLinesColor);

		///<summary>
		///
		///</summary>
		public void Set_CurveTangencyLinesColor(AcadAcCmColor pColor) 
		{
			this._i.CurveTangencyLinesColor = pColor._i;
		}

		///<summary>
		///
		///</summary>
		public string CurveTangencyLinesLayer => this._i.CurveTangencyLinesLayer;

		///<summary>
		///
		///</summary>
		public void Set_CurveTangencyLinesLayer(string Layer) 
		{
			this._i.CurveTangencyLinesLayer = Layer;
		}

		///<summary>
		///
		///</summary>
		public string CurveTangencyLinesLinetype => this._i.CurveTangencyLinesLinetype;

		///<summary>
		///
		///</summary>
		public void Set_CurveTangencyLinesLinetype(string Linetype) 
		{
			this._i.CurveTangencyLinesLinetype = Linetype;
		}

		///<summary>
		///
		///</summary>
		public double CurveTangencyLinesLinetypeScale => this._i.CurveTangencyLinesLinetypeScale;

		///<summary>
		///
		///</summary>
		public void Set_CurveTangencyLinesLinetypeScale(double ltScale) 
		{
			this._i.CurveTangencyLinesLinetypeScale = ltScale;
		}

		///<summary>
		///
		///</summary>
		public string CurveTangencyLinesPlotStyleName => this._i.CurveTangencyLinesPlotStyleName;

		///<summary>
		///
		///</summary>
		public void Set_CurveTangencyLinesPlotStyleName(string plotStyle) 
		{
			this._i.CurveTangencyLinesPlotStyleName = plotStyle;
		}

		///<summary>
		///
		///</summary>
		public object CurveTangencyLinesLineweight => this._i.CurveTangencyLinesLineweight;

		///<summary>
		///
		///</summary>
		public void Set_CurveTangencyLinesLineweight(dynamic Lineweight) 
		{
			this._i.CurveTangencyLinesLineweight = Lineweight;
		}
	}
}
