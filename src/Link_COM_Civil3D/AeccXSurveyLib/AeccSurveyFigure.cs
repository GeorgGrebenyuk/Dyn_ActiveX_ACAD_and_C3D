namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyFigure 
	{
		public Autodesk.AECC.Interop.Survey.IAeccSurveyFigure _i;
		internal AeccSurveyFigure(object AeccSurveyFigure_object) 
		{
			this._i = AeccSurveyFigure_object as Autodesk.AECC.Interop.Survey.IAeccSurveyFigure;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public void Set_Name(string pbstrName) 
		{
			this._i.Name = pbstrName;
		}

		///<summary>
		///
		///</summary>
		public dynamic FigureNodes => this._i.FigureNodes;

		///<summary>
		///
		///</summary>
		public dynamic NetworkId => this._i.NetworkId;

		///<summary>
		///
		///</summary>
		public void Set_NetworkId(dynamic pnNetworkId) 
		{
			this._i.NetworkId = pnNetworkId;
		}

		///<summary>
		///
		///</summary>
		public dynamic Project => this._i.Project;

		///<summary>
		///
		///</summary>
		public double FirstPointX => this._i.FirstPointX;

		///<summary>
		///
		///</summary>
		public double FirstPointY => this._i.FirstPointY;

		///<summary>
		///
		///</summary>
		public double LastPointX => this._i.LastPointX;

		///<summary>
		///
		///</summary>
		public double LastPointY => this._i.LastPointY;

		///<summary>
		///
		///</summary>
		public double LastAzimuth => this._i.LastAzimuth;

		///<summary>
		///
		///</summary>
		public double LastDistance => this._i.LastDistance;

		///<summary>
		///
		///</summary>
		public int PointCount => this._i.PointCount;

		///<summary>
		///
		///</summary>
		public bool IsForward => this._i.IsForward;

		///<summary>
		///
		///</summary>
		public void Set_IsForward(bool pbForward) 
		{
			this._i.IsForward = pbForward;
		}

		///<summary>
		///
		///</summary>
		public bool IsClosed => this._i.IsClosed;

		///<summary>
		///
		///</summary>
		public void Set_IsClosed(bool pbClosed) 
		{
			this._i.IsClosed = pbClosed;
		}

		///<summary>
		///
		///</summary>
		public bool IsBreakline => this._i.IsBreakline;

		///<summary>
		///
		///</summary>
		public void Set_IsBreakline(bool pbIsBreakline) 
		{
			this._i.IsBreakline = pbIsBreakline;
		}

		///<summary>
		///
		///</summary>
		public bool IsLotLine => this._i.IsLotLine;

		///<summary>
		///
		///</summary>
		public void Set_IsLotLine(bool pbIsLotLine) 
		{
			this._i.IsLotLine = pbIsLotLine;
		}

		///<summary>
		///
		///</summary>
		public string Layer => this._i.Layer;

		///<summary>
		///
		///</summary>
		public void Set_Layer(string pbstrLayer) 
		{
			this._i.Layer = pbstrLayer;
		}

		///<summary>
		///
		///</summary>
		public string Style => this._i.Style;

		///<summary>
		///
		///</summary>
		public void Set_Style(string pbstrStyle) 
		{
			this._i.Style = pbstrStyle;
		}

		///<summary>
		///
		///</summary>
		public string Site => this._i.Site;

		///<summary>
		///
		///</summary>
		public void Set_Site(string pbstrSite) 
		{
			this._i.Site = pbstrSite;
		}

		///<summary>
		///
		///</summary>
		public object AccumulatePointNumbers => this._i.AccumulatePointNumbers;

		///<summary>
		///
		///</summary>
		public object GetExtents => this._i.GetExtents;

		///<summary>
		///
		///</summary>
		public void InitializeFromFigurePrefix() 
		{
			this._i.InitializeFromFigurePrefix();
		}

		///<summary>
		///
		///</summary>
		public void AddLineByPoint(double dEasting,double dNorthing,dynamic nPointNumber) 
		{
			this._i.AddLineByPoint(dEasting,dNorthing,nPointNumber);
		}

		///<summary>
		///
		///</summary>
		public void AddLineByAzimuthDistance(double dAngle,double dDistance) 
		{
			this._i.AddLineByAzimuthDistance(dAngle,dDistance);
		}

		///<summary>
		///
		///</summary>
		public void AddLineByDeltaAzimuthDistance(double dDeltaAngle,double dDistance) 
		{
			this._i.AddLineByDeltaAzimuthDistance(dDeltaAngle,dDistance);
		}

		///<summary>
		///
		///</summary>
		public void AddArc(double dRadius,double dBulge,double dCenterX,double dCenterY,double dEndX,double dEndY,dynamic nPointOnCurve,dynamic nPoint) 
		{
			this._i.AddArc(dRadius,dBulge,dCenterX,dCenterY,dEndX,dEndY,nPointOnCurve,nPoint);
		}

		///<summary>
		///
		///</summary>
		public bool IsBadFigure => this._i.IsBadFigure;

		///<summary>
		///
		///</summary>
		public void RecalculateFigure(dynamic piDatabase) 
		{
			this._i.RecalculateFigure(piDatabase);
		}

		///<summary>
		///
		///</summary>
		public dynamic GetObjectId(dynamic piDatabase) 
		{
			return this._i.GetObjectId(piDatabase);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddToDrawing(dynamic piDatabase) 
		{
			return this._i.AddToDrawing(piDatabase);
		}

		///<summary>
		///
		///</summary>
		public bool IsInDrawing(dynamic piDatabase) 
		{
			return this._i.IsInDrawing(piDatabase);
		}

		///<summary>
		///
		///</summary>
		public dynamic LandXMLXPropertiesRoot => this._i.LandXMLXPropertiesRoot;

		///<summary>
		///
		///</summary>
		public dynamic UserDefinedXProperties => this._i.UserDefinedXProperties;
	}
}
