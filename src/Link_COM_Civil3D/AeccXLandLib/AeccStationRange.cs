namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccStationRange 
	{
		public AeccXLandLib.IAeccStationRange _i;
		internal AeccStationRange(object AeccStationRange_object) 
		{
			this._i = AeccStationRange_object as AeccXLandLib.IAeccStationRange;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public bool StartRangeAtAlignmentStart => this._i.StartRangeAtAlignmentStart;

		///<summary>
		///
		///</summary>
		public void Set_StartRangeAtAlignmentStart(bool pVal) 
		{
			this._i.StartRangeAtAlignmentStart = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool EndRangeAtAlignmentEnd => this._i.EndRangeAtAlignmentEnd;

		///<summary>
		///
		///</summary>
		public void Set_EndRangeAtAlignmentEnd(bool pVal) 
		{
			this._i.EndRangeAtAlignmentEnd = pVal;
		}

		///<summary>
		///
		///</summary>
		public double StartRange => this._i.StartRange;

		///<summary>
		///
		///</summary>
		public void Set_StartRange(double pVal) 
		{
			this._i.StartRange = pVal;
		}

		///<summary>
		///
		///</summary>
		public double EndRange => this._i.EndRange;

		///<summary>
		///
		///</summary>
		public void Set_EndRange(double pVal) 
		{
			this._i.EndRange = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UseSampleIncrements => this._i.UseSampleIncrements;

		///<summary>
		///
		///</summary>
		public void Set_UseSampleIncrements(bool pVal) 
		{
			this._i.UseSampleIncrements = pVal;
		}

		///<summary>
		///
		///</summary>
		public double IncrementTangent => this._i.IncrementTangent;

		///<summary>
		///
		///</summary>
		public void Set_IncrementTangent(double pVal) 
		{
			this._i.IncrementTangent = pVal;
		}

		///<summary>
		///
		///</summary>
		public double IncrementCurve => this._i.IncrementCurve;

		///<summary>
		///
		///</summary>
		public void Set_IncrementCurve(double pVal) 
		{
			this._i.IncrementCurve = pVal;
		}

		///<summary>
		///
		///</summary>
		public double IncrementSpiral => this._i.IncrementSpiral;

		///<summary>
		///
		///</summary>
		public void Set_IncrementSpiral(double pVal) 
		{
			this._i.IncrementSpiral = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic LeftSnapAlignment => this._i.LeftSnapAlignment;

		///<summary>
		///
		///</summary>
		public void Put_LeftSnapAlignment(dynamic ppVal) 
		{
			this._i.LeftSnapAlignment = ppVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic RightSnapAlignment => this._i.RightSnapAlignment;

		///<summary>
		///
		///</summary>
		public void Put_RightSnapAlignment(dynamic ppVal) 
		{
			this._i.RightSnapAlignment = ppVal;
		}

		///<summary>
		///
		///</summary>
		public double SwathWidthLeft => this._i.SwathWidthLeft;

		///<summary>
		///
		///</summary>
		public void Set_SwathWidthLeft(double pVal) 
		{
			this._i.SwathWidthLeft = pVal;
		}

		///<summary>
		///
		///</summary>
		public double SwathWidthRight => this._i.SwathWidthRight;

		///<summary>
		///
		///</summary>
		public void Set_SwathWidthRight(double pVal) 
		{
			this._i.SwathWidthRight = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool SampleAtRangeStart => this._i.SampleAtRangeStart;

		///<summary>
		///
		///</summary>
		public void Set_SampleAtRangeStart(bool pVal) 
		{
			this._i.SampleAtRangeStart = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool SampleAtRangeEnd => this._i.SampleAtRangeEnd;

		///<summary>
		///
		///</summary>
		public void Set_SampleAtRangeEnd(bool pVal) 
		{
			this._i.SampleAtRangeEnd = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool SampleAtSuperelevationCriticalStations => this._i.SampleAtSuperelevationCriticalStations;

		///<summary>
		///
		///</summary>
		public void Set_SampleAtSuperelevationCriticalStations(bool pVal) 
		{
			this._i.SampleAtSuperelevationCriticalStations = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool SampleAtHorizontalGeometryPoints => this._i.SampleAtHorizontalGeometryPoints;

		///<summary>
		///
		///</summary>
		public void Set_SampleAtHorizontalGeometryPoints(bool pVal) 
		{
			this._i.SampleAtHorizontalGeometryPoints = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool SampleAtHighLowPoints => this._i.SampleAtHighLowPoints;

		///<summary>
		///
		///</summary>
		public void Set_SampleAtHighLowPoints(bool pVal) 
		{
			this._i.SampleAtHighLowPoints = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic SampleLineDefaultDirection => this._i.SampleLineDefaultDirection;

		///<summary>
		///
		///</summary>
		public void Set_SampleLineDefaultDirection(AeccXLandLib.AeccDirectionFromType pVal) 
		{
			this._i.SampleLineDefaultDirection = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic SampleLineStyle => this._i.SampleLineStyle;

		///<summary>
		///
		///</summary>
		public void Put_SampleLineStyle(dynamic ppVal) 
		{
			this._i.SampleLineStyle = ppVal;
		}
	}
}
