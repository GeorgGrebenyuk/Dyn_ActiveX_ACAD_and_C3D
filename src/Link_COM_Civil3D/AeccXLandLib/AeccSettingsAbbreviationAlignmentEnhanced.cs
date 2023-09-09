namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAbbreviationAlignmentEnhanced 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsAbbreviationAlignmentEnhanced _i;
		internal AeccSettingsAbbreviationAlignmentEnhanced(object AeccSettingsAbbreviationAlignmentEnhanced_object) 
		{
			this._i = AeccSettingsAbbreviationAlignmentEnhanced_object as Autodesk.AECC.Interop.Land.IAeccSettingsAbbreviationAlignmentEnhanced;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_AlignmentBeginningPoint(string pVal) 
		{
			this._i.AlignmentBeginningPoint = pVal;
		}

		///<summary>
		///
		///</summary>
		public string AlignmentBeginningPoint => this._i.AlignmentBeginningPoint;

		///<summary>
		///
		///</summary>
		public void Set_AlignmentEndPoint(string pVal) 
		{
			this._i.AlignmentEndPoint = pVal;
		}

		///<summary>
		///
		///</summary>
		public string AlignmentEndPoint => this._i.AlignmentEndPoint;

		///<summary>
		///
		///</summary>
		public void Set_LineBeginning(string pVal) 
		{
			this._i.LineBeginning = pVal;
		}

		///<summary>
		///
		///</summary>
		public string LineBeginning => this._i.LineBeginning;

		///<summary>
		///
		///</summary>
		public void Set_LineEnd(string pVal) 
		{
			this._i.LineEnd = pVal;
		}

		///<summary>
		///
		///</summary>
		public string LineEnd => this._i.LineEnd;

		///<summary>
		///
		///</summary>
		public void Set_CurveBeginning(string pVal) 
		{
			this._i.CurveBeginning = pVal;
		}

		///<summary>
		///
		///</summary>
		public string CurveBeginning => this._i.CurveBeginning;

		///<summary>
		///
		///</summary>
		public void Set_CurveEnd(string pVal) 
		{
			this._i.CurveEnd = pVal;
		}

		///<summary>
		///
		///</summary>
		public string CurveEnd => this._i.CurveEnd;

		///<summary>
		///
		///</summary>
		public void Set_SimpleSpiralLargeRadiusAtBeginning(string pVal) 
		{
			this._i.SimpleSpiralLargeRadiusAtBeginning = pVal;
		}

		///<summary>
		///
		///</summary>
		public string SimpleSpiralLargeRadiusAtBeginning => this._i.SimpleSpiralLargeRadiusAtBeginning;

		///<summary>
		///
		///</summary>
		public void Set_SimpleSpiralLargeRadiusAtEnd(string pVal) 
		{
			this._i.SimpleSpiralLargeRadiusAtEnd = pVal;
		}

		///<summary>
		///
		///</summary>
		public string SimpleSpiralLargeRadiusAtEnd => this._i.SimpleSpiralLargeRadiusAtEnd;

		///<summary>
		///
		///</summary>
		public void Set_SimpleSpiralSmallRadiusAtBeginning(string pVal) 
		{
			this._i.SimpleSpiralSmallRadiusAtBeginning = pVal;
		}

		///<summary>
		///
		///</summary>
		public string SimpleSpiralSmallRadiusAtBeginning => this._i.SimpleSpiralSmallRadiusAtBeginning;

		///<summary>
		///
		///</summary>
		public void Set_SimpleSpiralSmallRadiusAtEnd(string pVal) 
		{
			this._i.SimpleSpiralSmallRadiusAtEnd = pVal;
		}

		///<summary>
		///
		///</summary>
		public string SimpleSpiralSmallRadiusAtEnd => this._i.SimpleSpiralSmallRadiusAtEnd;

		///<summary>
		///
		///</summary>
		public void Set_CompoundSpiralLargeRadiusAtBeginning(string pVal) 
		{
			this._i.CompoundSpiralLargeRadiusAtBeginning = pVal;
		}

		///<summary>
		///
		///</summary>
		public string CompoundSpiralLargeRadiusAtBeginning => this._i.CompoundSpiralLargeRadiusAtBeginning;

		///<summary>
		///
		///</summary>
		public void Set_CompoundSpiralLargeRadiusAtEnd(string pVal) 
		{
			this._i.CompoundSpiralLargeRadiusAtEnd = pVal;
		}

		///<summary>
		///
		///</summary>
		public string CompoundSpiralLargeRadiusAtEnd => this._i.CompoundSpiralLargeRadiusAtEnd;

		///<summary>
		///
		///</summary>
		public void Set_CompoundSpiralSmallRadiusAtBeginning(string pVal) 
		{
			this._i.CompoundSpiralSmallRadiusAtBeginning = pVal;
		}

		///<summary>
		///
		///</summary>
		public string CompoundSpiralSmallRadiusAtBeginning => this._i.CompoundSpiralSmallRadiusAtBeginning;

		///<summary>
		///
		///</summary>
		public void Set_CompoundSpiralSmallRadiusAtEnd(string pVal) 
		{
			this._i.CompoundSpiralSmallRadiusAtEnd = pVal;
		}

		///<summary>
		///
		///</summary>
		public string CompoundSpiralSmallRadiusAtEnd => this._i.CompoundSpiralSmallRadiusAtEnd;
	}
}
