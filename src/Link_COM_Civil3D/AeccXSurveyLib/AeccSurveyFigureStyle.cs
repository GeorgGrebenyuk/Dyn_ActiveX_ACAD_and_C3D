namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyFigureStyle 
	{
		public Autodesk.AECC.Interop.Survey.IAeccSurveyFigureStyle _i;
		internal AeccSurveyFigureStyle(object AeccSurveyFigureStyle_object) 
		{
			this._i = AeccSurveyFigureStyle_object as Autodesk.AECC.Interop.Survey.IAeccSurveyFigureStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic FigureLinesDisplayStyle2d => this._i.FigureLinesDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic FigureLinesDisplayStyle3d => this._i.FigureLinesDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic VertexMarkersDisplayStyle2d => this._i.VertexMarkersDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic VertexMarkersDisplayStyle3d => this._i.VertexMarkersDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic AdditionalMarkersDisplayStyle2d => this._i.AdditionalMarkersDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic AdditionalMarkersDisplayStyle3d => this._i.AdditionalMarkersDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic MidpointMarkersDisplayStyle2d => this._i.MidpointMarkersDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic MidpointMarkersDisplayStyle3d => this._i.MidpointMarkersDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic EndpointMarkersDisplayStyle2d => this._i.EndpointMarkersDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic EndpointMarkersDisplayStyle3d => this._i.EndpointMarkersDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public double FlattenFigureElevation => this._i.FlattenFigureElevation;

		///<summary>
		///
		///</summary>
		public void Set_FlattenFigureElevation(double pdElevation) 
		{
			this._i.FlattenFigureElevation = pdElevation;
		}

		///<summary>
		///
		///</summary>
		public dynamic FigureDisplayMode => this._i.FigureDisplayMode;

		///<summary>
		///
		///</summary>
		public void Set_FigureDisplayMode(Autodesk.AECC.Interop.Survey.AeccSurveyFigureElevationDisplayMode pDisplayMode) 
		{
			this._i.FigureDisplayMode = pDisplayMode;
		}

		///<summary>
		///
		///</summary>
		public double FigureElevationScaleFactor => this._i.FigureElevationScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_FigureElevationScaleFactor(double pdScaleFactor) 
		{
			this._i.FigureElevationScaleFactor = pdScaleFactor;
		}

		///<summary>
		///
		///</summary>
		public dynamic MarkerStyleForVertices => this._i.MarkerStyleForVertices;

		///<summary>
		///
		///</summary>
		public void Put_MarkerStyleForVertices(dynamic ppiMarkerStyle) 
		{
			this._i.MarkerStyleForVertices = ppiMarkerStyle;
		}

		///<summary>
		///
		///</summary>
		public dynamic MarkerStyleForMidPoint => this._i.MarkerStyleForMidPoint;

		///<summary>
		///
		///</summary>
		public void Put_MarkerStyleForMidPoint(dynamic ppiMarkerStyle) 
		{
			this._i.MarkerStyleForMidPoint = ppiMarkerStyle;
		}

		///<summary>
		///
		///</summary>
		public dynamic MarkerStyleForStartPoint => this._i.MarkerStyleForStartPoint;

		///<summary>
		///
		///</summary>
		public void Put_MarkerStyleForStartPoint(dynamic ppiMarkerStyle) 
		{
			this._i.MarkerStyleForStartPoint = ppiMarkerStyle;
		}

		///<summary>
		///
		///</summary>
		public dynamic MarkerStyleForEndPoint => this._i.MarkerStyleForEndPoint;

		///<summary>
		///
		///</summary>
		public void Put_MarkerStyleForEndPoint(dynamic ppiMarkerStyle) 
		{
			this._i.MarkerStyleForEndPoint = ppiMarkerStyle;
		}

		///<summary>
		///
		///</summary>
		public dynamic AdditionalMarkerStyle => this._i.AdditionalMarkerStyle;

		///<summary>
		///
		///</summary>
		public void Put_AdditionalMarkerStyle(dynamic ppiMarkerStyle) 
		{
			this._i.AdditionalMarkerStyle = ppiMarkerStyle;
		}

		///<summary>
		///
		///</summary>
		public bool IsAlignVertexMarkersWithFigure => this._i.IsAlignVertexMarkersWithFigure;

		///<summary>
		///
		///</summary>
		public void Set_IsAlignVertexMarkersWithFigure(bool pbValue) 
		{
			this._i.IsAlignVertexMarkersWithFigure = pbValue;
		}

		///<summary>
		///
		///</summary>
		public bool IsAlignMidPointMarkersWithFigure => this._i.IsAlignMidPointMarkersWithFigure;

		///<summary>
		///
		///</summary>
		public void Set_IsAlignMidPointMarkersWithFigure(bool pbValue) 
		{
			this._i.IsAlignMidPointMarkersWithFigure = pbValue;
		}

		///<summary>
		///
		///</summary>
		public bool IsAlignStartAndEndPointMarkersWithFigure => this._i.IsAlignStartAndEndPointMarkersWithFigure;

		///<summary>
		///
		///</summary>
		public void Set_IsAlignStartAndEndPointMarkersWithFigure(bool pbValue) 
		{
			this._i.IsAlignStartAndEndPointMarkersWithFigure = pbValue;
		}

		///<summary>
		///
		///</summary>
		public dynamic AdditionalMarkersPlacementMethod => this._i.AdditionalMarkersPlacementMethod;

		///<summary>
		///
		///</summary>
		public void Set_AdditionalMarkersPlacementMethod(Autodesk.AECC.Interop.Survey.AeccSurveyAdditionalMarkerPlacementMethod pPlacementMethod) 
		{
			this._i.AdditionalMarkersPlacementMethod = pPlacementMethod;
		}

		///<summary>
		///
		///</summary>
		public double AdditionalMarkersInterval => this._i.AdditionalMarkersInterval;

		///<summary>
		///
		///</summary>
		public void Set_AdditionalMarkersInterval(double pdInterval) 
		{
			this._i.AdditionalMarkersInterval = pdInterval;
		}

		///<summary>
		///
		///</summary>
		public dynamic AdditionalMarkersDivideFigureBy => this._i.AdditionalMarkersDivideFigureBy;

		///<summary>
		///
		///</summary>
		public void Set_AdditionalMarkersDivideFigureBy(dynamic pnValue) 
		{
			this._i.AdditionalMarkersDivideFigureBy = pnValue;
		}

		///<summary>
		///
		///</summary>
		public bool IsPlaceMarkerAtFigureStartPoints => this._i.IsPlaceMarkerAtFigureStartPoints;

		///<summary>
		///
		///</summary>
		public void Set_IsPlaceMarkerAtFigureStartPoints(bool pbValue) 
		{
			this._i.IsPlaceMarkerAtFigureStartPoints = pbValue;
		}

		///<summary>
		///
		///</summary>
		public bool IsPlaceMarkerAtFigureEndPoints => this._i.IsPlaceMarkerAtFigureEndPoints;

		///<summary>
		///
		///</summary>
		public void Set_IsPlaceMarkerAtFigureEndPoints(bool pbValue) 
		{
			this._i.IsPlaceMarkerAtFigureEndPoints = pbValue;
		}

		///<summary>
		///
		///</summary>
		public bool IsAlignAdditionalMarkersWithFigure => this._i.IsAlignAdditionalMarkersWithFigure;

		///<summary>
		///
		///</summary>
		public void Set_IsAlignAdditionalMarkersWithFigure(bool pbValue) 
		{
			this._i.IsAlignAdditionalMarkersWithFigure = pbValue;
		}

		///<summary>
		///
		///</summary>
		public dynamic FigureLinesDisplayStylePlan => this._i.FigureLinesDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic FigureLinesDisplayStyleModel => this._i.FigureLinesDisplayStyleModel;

		///<summary>
		///
		///</summary>
		public dynamic FigureLinesDisplayStyleProfile => this._i.FigureLinesDisplayStyleProfile;

		///<summary>
		///
		///</summary>
		public dynamic VertexMarkersDisplayStylePlan => this._i.VertexMarkersDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic VertexMarkersDisplayStyleModel => this._i.VertexMarkersDisplayStyleModel;

		///<summary>
		///
		///</summary>
		public dynamic VertexMarkersDisplayStyleProfile => this._i.VertexMarkersDisplayStyleProfile;

		///<summary>
		///
		///</summary>
		public dynamic AdditionalMarkersDisplayStylePlan => this._i.AdditionalMarkersDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic AdditionalMarkersDisplayStyleModel => this._i.AdditionalMarkersDisplayStyleModel;

		///<summary>
		///
		///</summary>
		public dynamic AdditionalMarkersDisplayStyleProfile => this._i.AdditionalMarkersDisplayStyleProfile;

		///<summary>
		///
		///</summary>
		public dynamic MidpointMarkersDisplayStylePlan => this._i.MidpointMarkersDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic MidpointMarkersDisplayStyleModel => this._i.MidpointMarkersDisplayStyleModel;

		///<summary>
		///
		///</summary>
		public dynamic MidpointMarkersDisplayStyleProfile => this._i.MidpointMarkersDisplayStyleProfile;

		///<summary>
		///
		///</summary>
		public dynamic EndpointMarkersDisplayStylePlan => this._i.EndpointMarkersDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic EndpointMarkersDisplayStyleModel => this._i.EndpointMarkersDisplayStyleModel;

		///<summary>
		///
		///</summary>
		public dynamic EndpointMarkersDisplayStyleProfile => this._i.EndpointMarkersDisplayStyleProfile;
	}
}
