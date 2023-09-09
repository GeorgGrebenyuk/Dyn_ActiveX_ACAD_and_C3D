namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccRoadwayState 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccRoadwayState _i;
		internal AeccRoadwayState(object AeccRoadwayState_object) 
		{
			this._i = AeccRoadwayState_object as Autodesk.AECC.Interop.Roadway.IAeccRoadwayState;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic ParamsPoint => this._i.ParamsPoint;

		///<summary>
		///
		///</summary>
		public dynamic ParamsOffsetTarget => this._i.ParamsOffsetTarget;

		///<summary>
		///
		///</summary>
		public dynamic ParamsElevationTarget => this._i.ParamsElevationTarget;

		///<summary>
		///
		///</summary>
		public dynamic Points => this._i.Points;

		///<summary>
		///
		///</summary>
		public dynamic Links => this._i.Links;

		///<summary>
		///
		///</summary>
		public dynamic Shapes => this._i.Shapes;

		///<summary>
		///
		///</summary>
		public dynamic Mode => this._i.Mode;

		///<summary>
		///
		///</summary>
		public void Set_LayoutModeDisplayType(Autodesk.AECC.Interop.Roadway.AeccRoadwayLayoutModeDisplay pVal) 
		{
			this._i.LayoutModeDisplayType = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic LayoutModeDisplayType => this._i.LayoutModeDisplayType;

		///<summary>
		///
		///</summary>
		public dynamic IntersectLink(dynamic pOrigin,bool bLookRight,double dblSlope,string bstrLinkCode) 
		{
			return this._i.IntersectLink(pOrigin,bLookRight,dblSlope,bstrLinkCode);
		}

		///<summary>
		///
		///</summary>
		public dynamic IntersectSurface(dynamic pIAeccSurface,dynamic pIAeccAlignment,dynamic pOrigin,bool bLookRight,double dblSlope,double dblMaxDistance) 
		{
			return this._i.IntersectSurface(pIAeccSurface,pIAeccAlignment,pOrigin,bLookRight,dblSlope,dblMaxDistance);
		}

		///<summary>
		///
		///</summary>
		public dynamic IntersectAlignment(dynamic pIAeccTargetAlignment,dynamic pIAeccAlignment,dynamic pOrigin,bool bLookRight,double dblMaxDistance) 
		{
			return this._i.IntersectAlignment(pIAeccTargetAlignment,pIAeccAlignment,pOrigin,bLookRight,dblMaxDistance);
		}

		///<summary>
		///
		///</summary>
		public void Error(dynamic nErrorNumber,Autodesk.AECC.Interop.Roadway.AeccRoadwayErrorLevel nErrorLevel,string bstrDescription,string bstrSource,bool bShowInEventViewer) 
		{
			this._i.Error(nErrorNumber,nErrorLevel,bstrDescription,bstrSource,bShowInEventViewer);
		}

		///<summary>
		///
		///</summary>
		public double CurrentStation => this._i.CurrentStation;

		///<summary>
		///
		///</summary>
		public double CurrentOffset => this._i.CurrentOffset;

		///<summary>
		///
		///</summary>
		public double CurrentElevation => this._i.CurrentElevation;

		///<summary>
		///
		///</summary>
		public double CurrentAssemblyOffset => this._i.CurrentAssemblyOffset;

		///<summary>
		///
		///</summary>
		public double CurrentAssemblyElevation => this._i.CurrentAssemblyElevation;

		///<summary>
		///
		///</summary>
		public double CurrentSubassemblyOffset => this._i.CurrentSubassemblyOffset;

		///<summary>
		///
		///</summary>
		public double CurrentSubassemblyElevation => this._i.CurrentSubassemblyElevation;

		///<summary>
		///
		///</summary>
		public dynamic CurrentBaseline => this._i.CurrentBaseline;

		///<summary>
		///
		///</summary>
		public dynamic CurrentAlignment => this._i.CurrentAlignment;

		///<summary>
		///
		///</summary>
		public dynamic CurrentProfile => this._i.CurrentProfile;

		///<summary>
		///
		///</summary>
		public dynamic CurrentSubassembly => this._i.CurrentSubassembly;

		///<summary>
		///
		///</summary>
		public string CurrentSubassemblyName => this._i.CurrentSubassemblyName;

		///<summary>
		///
		///</summary>
		public dynamic CurrentAssembly => this._i.CurrentAssembly;

		///<summary>
		///
		///</summary>
		public string CurrentAssemblyName => this._i.CurrentAssemblyName;

		///<summary>
		///
		///</summary>
		public dynamic CurrentCorridor => this._i.CurrentCorridor;

		///<summary>
		///
		///</summary>
		public string CurrentCorridorName => this._i.CurrentCorridorName;

		///<summary>
		///
		///</summary>
		public void SoeToXyz(dynamic pIAlignment,double dblStation,double dblOffset,double dblElevation,out double pdblX,out double pdblY,out double pdblZ) 
		{
			this._i.SoeToXyz(pIAlignment,dblStation,dblOffset,dblElevation,out pdblX,out pdblY,out pdblZ);
		}

		///<summary>
		///
		///</summary>
		public void XyzToSoe(dynamic pIAlignment,double dblX,double dblY,double dblZ,out double pdblStation,out double pdblOffset,out double pdblElevation) 
		{
			this._i.XyzToSoe(pIAlignment,dblX,dblY,dblZ,out pdblStation,out pdblOffset,out pdblElevation);
		}

		///<summary>
		///
		///</summary>
		public bool IsAboveSurface(dynamic pISurface,dynamic pIAlignment,dynamic pPoint,double dblMinimumAmountAbove) 
		{
			return this._i.IsAboveSurface(pISurface,pIAlignment,pPoint,dblMinimumAmountAbove);
		}

		///<summary>
		///
		///</summary>
		public dynamic SampleSection(dynamic pISurface,dynamic pIAlignment,dynamic pPoint1,dynamic pPoint2) 
		{
			return this._i.SampleSection(pISurface,pIAlignment,pPoint1,pPoint2);
		}

		///<summary>
		///
		///</summary>
		public bool CurrentAlignmentIsOffsetAlignment => this._i.CurrentAlignmentIsOffsetAlignment;

		///<summary>
		///
		///</summary>
		public bool CurrentAssemblyOffsetIsFixed => this._i.CurrentAssemblyOffsetIsFixed;

		///<summary>
		///
		///</summary>
		public double CurrentAssemblyFixedOffset => this._i.CurrentAssemblyFixedOffset;

		///<summary>
		///
		///</summary>
		public double CurrentAssemblyFixedElevation => this._i.CurrentAssemblyFixedElevation;

		///<summary>
		///
		///</summary>
		public string ResourceString(dynamic long) 
		{
			return this._i.ResourceString(long);
		}

		///<summary>
		///
		///</summary>
		public string ResourceStringEx(string bstrId) 
		{
			return this._i.ResourceStringEx(bstrId);
		}

		///<summary>
		///
		///</summary>
		public dynamic ParamsBoolGlobal => this._i.ParamsBoolGlobal;

		///<summary>
		///
		///</summary>
		public dynamic ParamsLongGlobal => this._i.ParamsLongGlobal;

		///<summary>
		///
		///</summary>
		public dynamic ParamsDoubleGlobal => this._i.ParamsDoubleGlobal;

		///<summary>
		///
		///</summary>
		public dynamic ParamsStringGlobal => this._i.ParamsStringGlobal;

		///<summary>
		///
		///</summary>
		public dynamic ParamsSurfaceGlobal => this._i.ParamsSurfaceGlobal;

		///<summary>
		///
		///</summary>
		public dynamic ParamsAlignmentGlobal => this._i.ParamsAlignmentGlobal;

		///<summary>
		///
		///</summary>
		public dynamic ParamsProfileGlobal => this._i.ParamsProfileGlobal;

		///<summary>
		///
		///</summary>
		public dynamic ParamsPointGlobal => this._i.ParamsPointGlobal;

		///<summary>
		///
		///</summary>
		public dynamic ParamsOffsetTargetGlobal => this._i.ParamsOffsetTargetGlobal;

		///<summary>
		///
		///</summary>
		public dynamic ParamsElevationTargetGlobal => this._i.ParamsElevationTargetGlobal;
	}
}
