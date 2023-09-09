namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAbbreviationAlignment 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsAbbreviationAlignment _i;
		internal AeccSettingsAbbreviationAlignment(object AeccSettingsAbbreviationAlignment_object) 
		{
			this._i = AeccSettingsAbbreviationAlignment_object as Autodesk.AECC.Interop.Land.IAeccSettingsAbbreviationAlignment;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_SpiralCurveIntersect(string pVal) 
		{
			this._i.SpiralCurveIntersect = pVal;
		}

		///<summary>
		///
		///</summary>
		public string SpiralCurveIntersect => this._i.SpiralCurveIntersect;

		///<summary>
		///
		///</summary>
		public void Set_CurveSpiralIntersect(string pVal) 
		{
			this._i.CurveSpiralIntersect = pVal;
		}

		///<summary>
		///
		///</summary>
		public string CurveSpiralIntersect => this._i.CurveSpiralIntersect;

		///<summary>
		///
		///</summary>
		public void Set_SpiralTangentIntersect(string pVal) 
		{
			this._i.SpiralTangentIntersect = pVal;
		}

		///<summary>
		///
		///</summary>
		public string SpiralTangentIntersect => this._i.SpiralTangentIntersect;

		///<summary>
		///
		///</summary>
		public void Set_TangentSpiralIntersect(string pVal) 
		{
			this._i.TangentSpiralIntersect = pVal;
		}

		///<summary>
		///
		///</summary>
		public string TangentSpiralIntersect => this._i.TangentSpiralIntersect;

		///<summary>
		///
		///</summary>
		public void Set_ReverseCurveCurveIntersect(string pVal) 
		{
			this._i.ReverseCurveCurveIntersect = pVal;
		}

		///<summary>
		///
		///</summary>
		public string ReverseCurveCurveIntersect => this._i.ReverseCurveCurveIntersect;

		///<summary>
		///
		///</summary>
		public void Set_CompoundCurveCurveIntersect(string pVal) 
		{
			this._i.CompoundCurveCurveIntersect = pVal;
		}

		///<summary>
		///
		///</summary>
		public string CompoundCurveCurveIntersect => this._i.CompoundCurveCurveIntersect;

		///<summary>
		///
		///</summary>
		public void Set_CurveTangentIntersect(string pVal) 
		{
			this._i.CurveTangentIntersect = pVal;
		}

		///<summary>
		///
		///</summary>
		public string CurveTangentIntersect => this._i.CurveTangentIntersect;

		///<summary>
		///
		///</summary>
		public void Set_TangentCurveIntersect(string pVal) 
		{
			this._i.TangentCurveIntersect = pVal;
		}

		///<summary>
		///
		///</summary>
		public string TangentCurveIntersect => this._i.TangentCurveIntersect;

		///<summary>
		///
		///</summary>
		public void Set_TangentTangentIntersect(string pVal) 
		{
			this._i.TangentTangentIntersect = pVal;
		}

		///<summary>
		///
		///</summary>
		public string TangentTangentIntersect => this._i.TangentTangentIntersect;

		///<summary>
		///
		///</summary>
		public void Set_ReverseSpiralIntersect(string pVal) 
		{
			this._i.ReverseSpiralIntersect = pVal;
		}

		///<summary>
		///
		///</summary>
		public string ReverseSpiralIntersect => this._i.ReverseSpiralIntersect;

		///<summary>
		///
		///</summary>
		public void Set_SpiralSpiralIntersect(string pVal) 
		{
			this._i.SpiralSpiralIntersect = pVal;
		}

		///<summary>
		///
		///</summary>
		public string SpiralSpiralIntersect => this._i.SpiralSpiralIntersect;

		///<summary>
		///
		///</summary>
		public void Set_StationEquationIncreasing(string pVal) 
		{
			this._i.StationEquationIncreasing = pVal;
		}

		///<summary>
		///
		///</summary>
		public string StationEquationIncreasing => this._i.StationEquationIncreasing;

		///<summary>
		///
		///</summary>
		public void Set_StationEquationDecreasing(string pVal) 
		{
			this._i.StationEquationDecreasing = pVal;
		}

		///<summary>
		///
		///</summary>
		public string StationEquationDecreasing => this._i.StationEquationDecreasing;

		///<summary>
		///
		///</summary>
		public void Set_AlignmentBeginning(string pVal) 
		{
			this._i.AlignmentBeginning = pVal;
		}

		///<summary>
		///
		///</summary>
		public string AlignmentBeginning => this._i.AlignmentBeginning;

		///<summary>
		///
		///</summary>
		public void Set_AlignmentEnd(string pVal) 
		{
			this._i.AlignmentEnd = pVal;
		}

		///<summary>
		///
		///</summary>
		public string AlignmentEnd => this._i.AlignmentEnd;
	}
}
