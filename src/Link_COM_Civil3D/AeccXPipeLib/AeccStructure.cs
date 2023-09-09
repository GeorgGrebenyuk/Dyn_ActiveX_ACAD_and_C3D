namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccStructure 
	{
		public AeccXPipeLib.IAeccStructure _i;
		internal AeccStructure(object AeccStructure_object) 
		{
			this._i = AeccStructure_object as AeccXPipeLib.IAeccStructure;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void ConnectToPipe(dynamic piPipe,AeccXPipeLib.AeccPipeConnectorPos eDestPos) 
		{
			this._i.ConnectToPipe(piPipe,eDestPos);
		}

		///<summary>
		///
		///</summary>
		public void Disconnect(dynamic piPipe) 
		{
			this._i.Disconnect(piPipe);
		}

		///<summary>
		///
		///</summary>
		public void ResizeJunctionStructureByRimAndSumpElevations(string csPartFamilyGuid,double dRimElev,double dSumpElev) 
		{
			this._i.ResizeJunctionStructureByRimAndSumpElevations(csPartFamilyGuid,dRimElev,dSumpElev);
		}

		///<summary>
		///
		///</summary>
		public void ResizeByPipeDepths() 
		{
			this._i.ResizeByPipeDepths();
		}

		///<summary>
		///
		///</summary>
		public double Rotation => this._i.Rotation;

		///<summary>
		///
		///</summary>
		public void Set_Rotation(double pdRotation) 
		{
			this._i.Rotation = pdRotation;
		}

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
		public dynamic BoundingShape => this._i.BoundingShape;

		///<summary>
		///
		///</summary>
		public dynamic ConnectedPipesCount => this._i.ConnectedPipesCount;

		///<summary>
		///
		///</summary>
		public dynamic ConnectedPipe(dynamic nIndex) 
		{
			return this._i.ConnectedPipe(nIndex);
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
		public double PipeWallThickness(int pIndex) 
		{
			return this._i.PipeWallThickness(pIndex);
		}

		///<summary>
		///
		///</summary>
		public double PipeInnerDiaOrWidth(int pIndex) 
		{
			return this._i.PipeInnerDiaOrWidth(pIndex);
		}

		///<summary>
		///
		///</summary>
		public double PipeCenterDepth(int pIndex) 
		{
			return this._i.PipeCenterDepth(pIndex);
		}

		///<summary>
		///
		///</summary>
		public bool IsConnectedPipeFlowingOut(int pIndex) 
		{
			return this._i.IsConnectedPipeFlowingOut(pIndex);
		}

		///<summary>
		///
		///</summary>
		public bool IsConnectedPipeFlowingIn(int pIndex) 
		{
			return this._i.IsConnectedPipeFlowingIn(pIndex);
		}

		///<summary>
		///
		///</summary>
		public string ConnectedPipeNames => this._i.ConnectedPipeNames;

		///<summary>
		///
		///</summary>
		public double PipeInvertDepth(int pIndex) 
		{
			return this._i.PipeInvertDepth(pIndex);
		}

		///<summary>
		///
		///</summary>
		public double PipeOuterBottomDepth(int pIndex) 
		{
			return this._i.PipeOuterBottomDepth(pIndex);
		}

		///<summary>
		///
		///</summary>
		public double PipeOuterTopDepth(int pIndex) 
		{
			return this._i.PipeOuterTopDepth(pIndex);
		}

		///<summary>
		///
		///</summary>
		public double PipeLowestBottomDepth => this._i.PipeLowestBottomDepth;

		///<summary>
		///
		///</summary>
		public double PipeUpperTopDepth => this._i.PipeUpperTopDepth;

		///<summary>
		///
		///</summary>
		public double StructureDiameterOrWidth => this._i.StructureDiameterOrWidth;

		///<summary>
		///
		///</summary>
		public double StructureInnerDiameterOrWidth => this._i.StructureInnerDiameterOrWidth;

		///<summary>
		///
		///</summary>
		public double StructureLength => this._i.StructureLength;

		///<summary>
		///
		///</summary>
		public double StructureInnerLength => this._i.StructureInnerLength;

		///<summary>
		///
		///</summary>
		public double StructureHeight => this._i.StructureHeight;

		///<summary>
		///
		///</summary>
		public double SumpElevation => this._i.SumpElevation;

		///<summary>
		///
		///</summary>
		public void Set_SumpElevation(double dInnerLength) 
		{
			this._i.SumpElevation = dInnerLength;
		}

		///<summary>
		///
		///</summary>
		public bool IsPointInsideStructureRegion(dynamic ppiPoint3d) 
		{
			return this._i.IsPointInsideStructureRegion(ppiPoint3d);
		}

		///<summary>
		///
		///</summary>
		public double GetNextPipeElevation => this._i.GetNextPipeElevation;

		///<summary>
		///
		///</summary>
		public double SurfaceAdjustmentValue => this._i.SurfaceAdjustmentValue;

		///<summary>
		///
		///</summary>
		public void Set_SurfaceAdjustmentValue(double dValue) 
		{
			this._i.SurfaceAdjustmentValue = dValue;
		}

		///<summary>
		///
		///</summary>
		public bool AutomaticRimSurfaceAdjustment => this._i.AutomaticRimSurfaceAdjustment;

		///<summary>
		///
		///</summary>
		public void Set_AutomaticRimSurfaceAdjustment(bool bValue) 
		{
			this._i.AutomaticRimSurfaceAdjustment = bValue;
		}

		///<summary>
		///
		///</summary>
		public double SumpDepth => this._i.SumpDepth;

		///<summary>
		///
		///</summary>
		public void Set_SumpDepth(double dValue) 
		{
			this._i.SumpDepth = dValue;
		}

		///<summary>
		///
		///</summary>
		public double RimElevation => this._i.RimElevation;

		///<summary>
		///
		///</summary>
		public void Set_RimElevation(double dValue) 
		{
			this._i.RimElevation = dValue;
		}

		///<summary>
		///
		///</summary>
		public dynamic ControlSumpBy => this._i.ControlSumpBy;

		///<summary>
		///
		///</summary>
		public void Set_ControlSumpBy(AeccXPipeLib.AeccStructureControlSumpBy eValue) 
		{
			this._i.ControlSumpBy = eValue;
		}

		///<summary>
		///
		///</summary>
		public dynamic Labels => this._i.Labels;

		///<summary>
		///
		///</summary>
		public void SetLocation(object varLocation) 
		{
			this._i.SetLocation(varLocation);
		}

		///<summary>
		///
		///</summary>
		public void Set_InnerDiameter(double rhs) 
		{
			this._i.InnerDiameter = rhs;
		}

		///<summary>
		///
		///</summary>
		public void Set_InnerLength(double rhs) 
		{
			this._i.InnerLength = rhs;
		}

		///<summary>
		///
		///</summary>
		public void Set_InnerWidth(double rhs) 
		{
			this._i.InnerWidth = rhs;
		}
	}
}
