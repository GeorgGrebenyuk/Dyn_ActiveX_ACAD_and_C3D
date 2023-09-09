namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPipe 
	{
		public AeccXPipeLib.IAeccPipe _i;
		internal AeccPipe(object AeccPipe_object) 
		{
			this._i = AeccPipe_object as AeccXPipeLib.IAeccPipe;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic StartPoint => this._i.StartPoint;

		///<summary>
		///
		///</summary>
		public dynamic EndPoint => this._i.EndPoint;

		///<summary>
		///
		///</summary>
		public void ConnectToStructure(AeccXPipeLib.AeccPipeConnectorPos ePos,dynamic piDestStructure) 
		{
			this._i.ConnectToStructure(ePos,piDestStructure);
		}

		///<summary>
		///
		///</summary>
		public dynamic ConnectToPipe(AeccXPipeLib.AeccPipeConnectorPos ePos,dynamic piDestPipe,AeccXPipeLib.AeccPipeConnectorPos eDestPos) 
		{
			return this._i.ConnectToPipe(ePos,piDestPipe,eDestPos);
		}

		///<summary>
		///
		///</summary>
		public void Disconnect(AeccXPipeLib.AeccPipeConnectorPos ePos) 
		{
			this._i.Disconnect(ePos);
		}

		///<summary>
		///
		///</summary>
		public void ResizeByInnerDiaOrWidth(string csPartFamilyGuid,double dInnerDiaOrWidth,bool bUseClosestSize) 
		{
			this._i.ResizeByInnerDiaOrWidth(csPartFamilyGuid,dInnerDiaOrWidth,bUseClosestSize);
		}

		///<summary>
		///
		///</summary>
		public dynamic SubEntityType => this._i.SubEntityType;

		///<summary>
		///
		///</summary>
		public dynamic FlowDirectionMethod => this._i.FlowDirectionMethod;

		///<summary>
		///
		///</summary>
		public void Set_FlowDirectionMethod(AeccXPipeLib.AeccPipeFlowDirectionMethod pFlowDirectionMethod) 
		{
			this._i.FlowDirectionMethod = pFlowDirectionMethod;
		}

		///<summary>
		///
		///</summary>
		public dynamic HoldOnResize => this._i.HoldOnResize;

		///<summary>
		///
		///</summary>
		public void Set_HoldOnResize(AeccXPipeLib.AeccPipeHoldOnResize pHoldOnResize) 
		{
			this._i.HoldOnResize = pHoldOnResize;
		}

		///<summary>
		///
		///</summary>
		public dynamic FlowDirection => this._i.FlowDirection;

		///<summary>
		///
		///</summary>
		public int SweptShape => this._i.SweptShape;

		///<summary>
		///
		///</summary>
		public double Length3D => this._i.Length3D;

		///<summary>
		///
		///</summary>
		public double Length2D => this._i.Length2D;

		///<summary>
		///
		///</summary>
		public double Radius => this._i.Radius;

		///<summary>
		///
		///</summary>
		public dynamic StartStructure => this._i.StartStructure;

		///<summary>
		///
		///</summary>
		public dynamic EndStructure => this._i.EndStructure;

		///<summary>
		///
		///</summary>
		public dynamic Style => this._i.Style;

		///<summary>
		///
		///</summary>
		public void Put_Style(dynamic ppiStyle) 
		{
			this._i.Style = ppiStyle;
		}

		///<summary>
		///
		///</summary>
		public dynamic Alignment => this._i.Alignment;

		///<summary>
		///
		///</summary>
		public void Put_Alignment(dynamic ppiAlignment) 
		{
			this._i.Alignment = ppiAlignment;
		}

		///<summary>
		///
		///</summary>
		public dynamic Surface => this._i.Surface;

		///<summary>
		///
		///</summary>
		public void Put_Surface(dynamic ppiSurface) 
		{
			this._i.Surface = ppiSurface;
		}

		///<summary>
		///
		///</summary>
		public double WallThickness => this._i.WallThickness;

		///<summary>
		///
		///</summary>
		public double InnerDiameterOrWidth => this._i.InnerDiameterOrWidth;

		///<summary>
		///
		///</summary>
		public double OuterDiameterOrWidth => this._i.OuterDiameterOrWidth;

		///<summary>
		///
		///</summary>
		public double InnerHeight => this._i.InnerHeight;

		///<summary>
		///
		///</summary>
		public double OuterHeight => this._i.OuterHeight;

		///<summary>
		///
		///</summary>
		public object PointAtParam(double dVal) 
		{
			return this._i.PointAtParam(dVal);
		}

		///<summary>
		///
		///</summary>
		public object ClosestPointTo(object SrcVal) 
		{
			return this._i.ClosestPointTo(SrcVal);
		}

		///<summary>
		///
		///</summary>
		public object Project2dPointVertically(object SrcVal) 
		{
			return this._i.Project2dPointVertically(SrcVal);
		}

		///<summary>
		///
		///</summary>
		public bool IsMaxCoverViolated(double dMaxCover,out object pPoints,out object pDifferences,out object pParams) 
		{
			return this._i.IsMaxCoverViolated(dMaxCover,out pPoints,out pDifferences,out pParams);
		}

		///<summary>
		///
		///</summary>
		public bool IsMinCoverViolated(double dMinCover,out object pPoints,out object pDifferences,out object pParams) 
		{
			return this._i.IsMinCoverViolated(dMinCover,out pPoints,out pDifferences,out pParams);
		}

		///<summary>
		///
		///</summary>
		public double Slope => this._i.Slope;

		///<summary>
		///
		///</summary>
		public double MinimumCover => this._i.MinimumCover;

		///<summary>
		///
		///</summary>
		public double MaximumCover => this._i.MaximumCover;

		///<summary>
		///
		///</summary>
		public dynamic Labels => this._i.Labels;

		///<summary>
		///
		///</summary>
		public double HGLUp => this._i.HGLUp;

		///<summary>
		///
		///</summary>
		public void Set_HGLUp(double pVal) 
		{
			this._i.HGLUp = pVal;
		}

		///<summary>
		///
		///</summary>
		public double HGLDown => this._i.HGLDown;

		///<summary>
		///
		///</summary>
		public void Set_HGLDown(double pVal) 
		{
			this._i.HGLDown = pVal;
		}

		///<summary>
		///
		///</summary>
		public double EGLUp => this._i.EGLUp;

		///<summary>
		///
		///</summary>
		public void Set_EGLUp(double pVal) 
		{
			this._i.EGLUp = pVal;
		}

		///<summary>
		///
		///</summary>
		public double EGLDown => this._i.EGLDown;

		///<summary>
		///
		///</summary>
		public void Set_EGLDown(double pVal) 
		{
			this._i.EGLDown = pVal;
		}

		///<summary>
		///
		///</summary>
		public object STMPipeMetadata => this._i.STMPipeMetadata;

		///<summary>
		///
		///</summary>
		public void Set_STMPipeMetadata(object pVal) 
		{
			this._i.STMPipeMetadata = pVal;
		}

		///<summary>
		///
		///</summary>
		public void SetStartAndEndPoints(object varStartPoint,object varEndPoint) 
		{
			this._i.SetStartAndEndPoints(varStartPoint,varEndPoint);
		}
	}
}
