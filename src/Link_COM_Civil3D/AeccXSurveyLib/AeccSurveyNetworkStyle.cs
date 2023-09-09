namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyNetworkStyle 
	{
		public Autodesk.AECC.Interop.Survey.IAeccSurveyNetworkStyle _i;
		internal AeccSurveyNetworkStyle(object AeccSurveyNetworkStyle_object) 
		{
			this._i = AeccSurveyNetworkStyle_object as Autodesk.AECC.Interop.Survey.IAeccSurveyNetworkStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic KnownControlPointsDisplayStyle2d => this._i.KnownControlPointsDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic KnownControlPointsDisplayStyle3d => this._i.KnownControlPointsDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic UnknownControlPointsDisplayStyle2d => this._i.UnknownControlPointsDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic UnknownControlPointsDisplayStyle3d => this._i.UnknownControlPointsDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic SideshotPointsDisplayStyle2d => this._i.SideshotPointsDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic SideshotPointsDisplayStyle3d => this._i.SideshotPointsDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic NetworkLinesDisplayStyle2d => this._i.NetworkLinesDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic NetworkLinesDisplayStyle3d => this._i.NetworkLinesDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic DirectionLinesDisplayStyle2d => this._i.DirectionLinesDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic DirectionLinesDisplayStyle3d => this._i.DirectionLinesDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic SideshotLinesDisplayStyle2d => this._i.SideshotLinesDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic SideshotLinesDisplayStyle3d => this._i.SideshotLinesDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic ErrorEllipsesDisplayStyle2d => this._i.ErrorEllipsesDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic ErrorEllipsesDisplayStyle3d => this._i.ErrorEllipsesDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic NetworkDisplayMode => this._i.NetworkDisplayMode;

		///<summary>
		///
		///</summary>
		public void Set_NetworkDisplayMode(Autodesk.AECC.Interop.Survey.AeccSurveyNetworkElevationDisplayMode pDisplayMode) 
		{
			this._i.NetworkDisplayMode = pDisplayMode;
		}

		///<summary>
		///
		///</summary>
		public double FlattenNetworkElevation => this._i.FlattenNetworkElevation;

		///<summary>
		///
		///</summary>
		public void Set_FlattenNetworkElevation(double pdElevation) 
		{
			this._i.FlattenNetworkElevation = pdElevation;
		}

		///<summary>
		///
		///</summary>
		public double NetworkElevationScaleFactor => this._i.NetworkElevationScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_NetworkElevationScaleFactor(double pdScaleFactor) 
		{
			this._i.NetworkElevationScaleFactor = pdScaleFactor;
		}

		///<summary>
		///
		///</summary>
		public dynamic MarkerStyleForKnownControlPoints => this._i.MarkerStyleForKnownControlPoints;

		///<summary>
		///
		///</summary>
		public void Put_MarkerStyleForKnownControlPoints(dynamic ppiStyle) 
		{
			this._i.MarkerStyleForKnownControlPoints = ppiStyle;
		}

		///<summary>
		///
		///</summary>
		public dynamic MarkerStyleForUnKnownControlPoints => this._i.MarkerStyleForUnKnownControlPoints;

		///<summary>
		///
		///</summary>
		public void Put_MarkerStyleForUnKnownControlPoints(dynamic ppiStyle) 
		{
			this._i.MarkerStyleForUnKnownControlPoints = ppiStyle;
		}

		///<summary>
		///
		///</summary>
		public dynamic MarkerStyleForSideshotPoints => this._i.MarkerStyleForSideshotPoints;

		///<summary>
		///
		///</summary>
		public void Put_MarkerStyleForSideshotPoints(dynamic ppiStyle) 
		{
			this._i.MarkerStyleForSideshotPoints = ppiStyle;
		}

		///<summary>
		///
		///</summary>
		public double ErrorEllipseScaleFactor => this._i.ErrorEllipseScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_ErrorEllipseScaleFactor(double pdScaleFactor) 
		{
			this._i.ErrorEllipseScaleFactor = pdScaleFactor;
		}

		///<summary>
		///
		///</summary>
		public dynamic KnownControlPointsDisplayStylePlan => this._i.KnownControlPointsDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic KnownControlPointsDisplayStyleModel => this._i.KnownControlPointsDisplayStyleModel;

		///<summary>
		///
		///</summary>
		public dynamic UnknownControlPointsDisplayStylePlan => this._i.UnknownControlPointsDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic UnknownControlPointsDisplayStyleModel => this._i.UnknownControlPointsDisplayStyleModel;

		///<summary>
		///
		///</summary>
		public dynamic SideshotPointsDisplayStylePlan => this._i.SideshotPointsDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic SideshotPointsDisplayStyleModel => this._i.SideshotPointsDisplayStyleModel;

		///<summary>
		///
		///</summary>
		public dynamic NetworkLinesDisplayStylePlan => this._i.NetworkLinesDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic NetworkLinesDisplayStyleModel => this._i.NetworkLinesDisplayStyleModel;

		///<summary>
		///
		///</summary>
		public dynamic DirectionLinesDisplayStylePlan => this._i.DirectionLinesDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic DirectionLinesDisplayStyleModel => this._i.DirectionLinesDisplayStyleModel;

		///<summary>
		///
		///</summary>
		public dynamic SideshotLinesDisplayStylePlan => this._i.SideshotLinesDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic SideshotLinesDisplayStyleModel => this._i.SideshotLinesDisplayStyleModel;

		///<summary>
		///
		///</summary>
		public dynamic ErrorEllipsesDisplayStylePlan => this._i.ErrorEllipsesDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic ErrorEllipsesDisplayStyleModel => this._i.ErrorEllipsesDisplayStyleModel;
	}
}
