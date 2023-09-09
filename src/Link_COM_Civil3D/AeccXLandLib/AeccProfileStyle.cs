namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileStyle 
	{
		public Autodesk.AECC.Interop.Land.IAeccProfileStyle _i;
		internal AeccProfileStyle(object AeccProfileStyle_object) 
		{
			this._i = AeccProfileStyle_object as Autodesk.AECC.Interop.Land.IAeccProfileStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public double ChainTessellationDistance3D => this._i.ChainTessellationDistance3D;

		///<summary>
		///
		///</summary>
		public void Set_ChainTessellationDistance3D(double pVal) 
		{
			this._i.ChainTessellationDistance3D = pVal;
		}

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
		public dynamic ArrowDisplayStyle2d => this._i.ArrowDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic ArrowDisplayStyle3d => this._i.ArrowDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic LineExtensionDisplayStyle2d => this._i.LineExtensionDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic LineExtensionDisplayStyle3d => this._i.LineExtensionDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic SymmetricalParabolaDisplayStyle2d => this._i.SymmetricalParabolaDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic SymmetricalParabolaDisplayStyle3d => this._i.SymmetricalParabolaDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic AsymmetricalParabolaDisplayStyle2d => this._i.AsymmetricalParabolaDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic AsymmetricalParabolaDisplayStyle3d => this._i.AsymmetricalParabolaDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic ParabolicCurveExtensionDisplayStyle2d => this._i.ParabolicCurveExtensionDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic ParabolicCurveExtensionDisplayStyle3d => this._i.ParabolicCurveExtensionDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic ThroughPointMarkerStyle => this._i.ThroughPointMarkerStyle;

		///<summary>
		///
		///</summary>
		public dynamic VIntersectionPointMarkerStyle => this._i.VIntersectionPointMarkerStyle;

		///<summary>
		///
		///</summary>
		public dynamic BeginPointMarkerStyle => this._i.BeginPointMarkerStyle;

		///<summary>
		///
		///</summary>
		public dynamic EndPointMarkerStyle => this._i.EndPointMarkerStyle;

		///<summary>
		///
		///</summary>
		public dynamic VTangentCurveIntersectPointMarkerStyle => this._i.VTangentCurveIntersectPointMarkerStyle;

		///<summary>
		///
		///</summary>
		public dynamic VCompoundCurveIntersectPointMarkerStyle => this._i.VCompoundCurveIntersectPointMarkerStyle;

		///<summary>
		///
		///</summary>
		public dynamic VReverseCurveIntersectPointMarkerStyle => this._i.VReverseCurveIntersectPointMarkerStyle;

		///<summary>
		///
		///</summary>
		public dynamic VCurveTangentIntersectPointMarkerStyle => this._i.VCurveTangentIntersectPointMarkerStyle;

		///<summary>
		///
		///</summary>
		public dynamic HighPointMarkerStyle => this._i.HighPointMarkerStyle;

		///<summary>
		///
		///</summary>
		public dynamic LowPointMarkerStyle => this._i.LowPointMarkerStyle;

		///<summary>
		///
		///</summary>
		public dynamic LineDisplayStyleProfile => this._i.LineDisplayStyleProfile;

		///<summary>
		///
		///</summary>
		public dynamic CurveDisplayStyleProfile => this._i.CurveDisplayStyleProfile;

		///<summary>
		///
		///</summary>
		public dynamic ArrowDisplayStyleProfile => this._i.ArrowDisplayStyleProfile;

		///<summary>
		///
		///</summary>
		public dynamic LineExtensionDisplayStyleProfile => this._i.LineExtensionDisplayStyleProfile;

		///<summary>
		///
		///</summary>
		public dynamic SymmetricalParabolaDisplayStyleProfile => this._i.SymmetricalParabolaDisplayStyleProfile;

		///<summary>
		///
		///</summary>
		public dynamic AsymmetricalParabolaDisplayStyleProfile => this._i.AsymmetricalParabolaDisplayStyleProfile;

		///<summary>
		///
		///</summary>
		public dynamic ParabolicCurveExtensionDisplayStyleProfile => this._i.ParabolicCurveExtensionDisplayStyleProfile;
	}
}
