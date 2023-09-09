namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentStyle 
	{
		public Autodesk.AECC.Interop.Land.IAeccAlignmentStyle _i;
		internal AeccAlignmentStyle(object AeccAlignmentStyle_object) 
		{
			this._i = AeccAlignmentStyle_object as Autodesk.AECC.Interop.Land.IAeccAlignmentStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_EnableRadiusSnap(bool pVal) 
		{
			this._i.EnableRadiusSnap = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool EnableRadiusSnap => this._i.EnableRadiusSnap;

		///<summary>
		///
		///</summary>
		public void Set_RadiusSnapValue(double pVal) 
		{
			this._i.RadiusSnapValue = pVal;
		}

		///<summary>
		///
		///</summary>
		public double RadiusSnapValue => this._i.RadiusSnapValue;

		///<summary>
		///
		///</summary>
		public dynamic LineDisplayStyle2d => this._i.LineDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic LineDisplayStyle3d => this._i.LineDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic CurveDisplayStyle2d => this._i.CurveDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic CurveDisplayStyle3d => this._i.CurveDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic SpiralDisplayStyle2d => this._i.SpiralDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic SpiralDisplayStyle3d => this._i.SpiralDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic ArrowDisplayStyle2d => this._i.ArrowDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic ArrowDisplayStyle3d => this._i.ArrowDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic LineExtensionsDisplayStyle2d => this._i.LineExtensionsDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic LineExtensionsDisplayStyle3d => this._i.LineExtensionsDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic CurveExtensionsDisplayStyle2d => this._i.CurveExtensionsDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic CurveExtensionsDisplayStyle3d => this._i.CurveExtensionsDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic IntersectionPointMarkerStyle => this._i.IntersectionPointMarkerStyle;

		///<summary>
		///
		///</summary>
		public void Set_IntersectionPointMarkerStyle(object pVal) 
		{
			this._i.IntersectionPointMarkerStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic ThroughPointMarkerStyle => this._i.ThroughPointMarkerStyle;

		///<summary>
		///
		///</summary>
		public void Set_ThroughPointMarkerStyle(object pVal) 
		{
			this._i.ThroughPointMarkerStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic StationReferencePointMarkerStyle => this._i.StationReferencePointMarkerStyle;

		///<summary>
		///
		///</summary>
		public void Set_StationReferencePointMarkerStyle(object pVal) 
		{
			this._i.StationReferencePointMarkerStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic BeginPointMarkerStyle => this._i.BeginPointMarkerStyle;

		///<summary>
		///
		///</summary>
		public void Set_BeginPointMarkerStyle(object pVal) 
		{
			this._i.BeginPointMarkerStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic EndPointMarkerStyle => this._i.EndPointMarkerStyle;

		///<summary>
		///
		///</summary>
		public void Set_EndPointMarkerStyle(object pVal) 
		{
			this._i.EndPointMarkerStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic LineSpiralIntersectPointMarkerStyle => this._i.LineSpiralIntersectPointMarkerStyle;

		///<summary>
		///
		///</summary>
		public void Set_LineSpiralIntersectPointMarkerStyle(object pVal) 
		{
			this._i.LineSpiralIntersectPointMarkerStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic SpiralCurveIntersectPointMarkerStyle => this._i.SpiralCurveIntersectPointMarkerStyle;

		///<summary>
		///
		///</summary>
		public void Set_SpiralCurveIntersectPointMarkerStyle(object pVal) 
		{
			this._i.SpiralCurveIntersectPointMarkerStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic SpiralSpiralIntersectPointMarkerStyle => this._i.SpiralSpiralIntersectPointMarkerStyle;

		///<summary>
		///
		///</summary>
		public void Set_SpiralSpiralIntersectPointMarkerStyle(object pVal) 
		{
			this._i.SpiralSpiralIntersectPointMarkerStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic ReverseSpiralIntersectPointMarkerStyle => this._i.ReverseSpiralIntersectPointMarkerStyle;

		///<summary>
		///
		///</summary>
		public void Set_ReverseSpiralIntersectPointMarkerStyle(object pVal) 
		{
			this._i.ReverseSpiralIntersectPointMarkerStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic CurveSpiralIntersectPointMarkerStyle => this._i.CurveSpiralIntersectPointMarkerStyle;

		///<summary>
		///
		///</summary>
		public void Set_CurveSpiralIntersectPointMarkerStyle(object pVal) 
		{
			this._i.CurveSpiralIntersectPointMarkerStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic SpiralLineIntersectPointMarkerStyle => this._i.SpiralLineIntersectPointMarkerStyle;

		///<summary>
		///
		///</summary>
		public void Set_SpiralLineIntersectPointMarkerStyle(object pVal) 
		{
			this._i.SpiralLineIntersectPointMarkerStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic LineCurveIntersectPointMarkerStyle => this._i.LineCurveIntersectPointMarkerStyle;

		///<summary>
		///
		///</summary>
		public void Set_LineCurveIntersectPointMarkerStyle(object pVal) 
		{
			this._i.LineCurveIntersectPointMarkerStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic CompoundCurveIntersectPointMarkerStyle => this._i.CompoundCurveIntersectPointMarkerStyle;

		///<summary>
		///
		///</summary>
		public void Set_CompoundCurveIntersectPointMarkerStyle(object pVal) 
		{
			this._i.CompoundCurveIntersectPointMarkerStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic ReverseCurveIntersectPointMarkerStyle => this._i.ReverseCurveIntersectPointMarkerStyle;

		///<summary>
		///
		///</summary>
		public void Set_ReverseCurveIntersectPointMarkerStyle(object pVal) 
		{
			this._i.ReverseCurveIntersectPointMarkerStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic CurveLineIntersectPointMarkerStyle => this._i.CurveLineIntersectPointMarkerStyle;

		///<summary>
		///
		///</summary>
		public void Set_CurveLineIntersectPointMarkerStyle(object pVal) 
		{
			this._i.CurveLineIntersectPointMarkerStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic MidPointMarkerStyle => this._i.MidPointMarkerStyle;

		///<summary>
		///
		///</summary>
		public void Set_MidPointMarkerStyle(object pVal) 
		{
			this._i.MidPointMarkerStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic LineDisplayStylePlan => this._i.LineDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic LineDisplayStyleModel => this._i.LineDisplayStyleModel;

		///<summary>
		///
		///</summary>
		public dynamic CurveDisplayStylePlan => this._i.CurveDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic CurveDisplayStyleModel => this._i.CurveDisplayStyleModel;

		///<summary>
		///
		///</summary>
		public dynamic SpiralDisplayStylePlan => this._i.SpiralDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic SpiralDisplayStyleModel => this._i.SpiralDisplayStyleModel;

		///<summary>
		///
		///</summary>
		public dynamic ArrowDisplayStylePlan => this._i.ArrowDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic ArrowDisplayStyleModel => this._i.ArrowDisplayStyleModel;

		///<summary>
		///
		///</summary>
		public dynamic LineExtensionsDisplayStylePlan => this._i.LineExtensionsDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic LineExtensionsDisplayStyleModel => this._i.LineExtensionsDisplayStyleModel;

		///<summary>
		///
		///</summary>
		public dynamic CurveExtensionsDisplayStylePlan => this._i.CurveExtensionsDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic CurveExtensionsDisplayStyleModel => this._i.CurveExtensionsDisplayStyleModel;
	}
}
