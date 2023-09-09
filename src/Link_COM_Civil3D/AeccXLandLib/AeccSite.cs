namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSite 
	{
		public Autodesk.AECC.Interop.Land.IAeccSite _i;
		internal AeccSite(object AeccSite_object) 
		{
			this._i = AeccSite_object as Autodesk.AECC.Interop.Land.IAeccSite;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Parcels => this._i.Parcels;

		///<summary>
		///
		///</summary>
		public dynamic ParcelSegments => this._i.ParcelSegments;

		///<summary>
		///
		///</summary>
		public dynamic Alignments => this._i.Alignments;

		///<summary>
		///
		///</summary>
		public dynamic FeatureLines => this._i.FeatureLines;

		///<summary>
		///
		///</summary>
		public dynamic DisplayMode => this._i.DisplayMode;

		///<summary>
		///
		///</summary>
		public void Set_DisplayMode(Autodesk.AECC.Interop.Land.AeccSiteDisplay3dType pVal) 
		{
			this._i.DisplayMode = pVal;
		}

		///<summary>
		///
		///</summary>
		public double FlattenToElevationBy => this._i.FlattenToElevationBy;

		///<summary>
		///
		///</summary>
		public void Set_FlattenToElevationBy(double pVal) 
		{
			this._i.FlattenToElevationBy = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic NextAutoCounterParcel => this._i.NextAutoCounterParcel;

		///<summary>
		///
		///</summary>
		public void Set_NextAutoCounterParcel(dynamic pVal) 
		{
			this._i.NextAutoCounterParcel = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic NextManualCounterParcel => this._i.NextManualCounterParcel;

		///<summary>
		///
		///</summary>
		public void Set_NextManualCounterParcel(dynamic pVal) 
		{
			this._i.NextManualCounterParcel = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic NextAutoCounterParcelLine => this._i.NextAutoCounterParcelLine;

		///<summary>
		///
		///</summary>
		public void Set_NextAutoCounterParcelLine(dynamic pVal) 
		{
			this._i.NextAutoCounterParcelLine = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic NextManualCounterParcelLine => this._i.NextManualCounterParcelLine;

		///<summary>
		///
		///</summary>
		public void Set_NextManualCounterParcelLine(dynamic pVal) 
		{
			this._i.NextManualCounterParcelLine = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic NextAutoCounterParcelCurve => this._i.NextAutoCounterParcelCurve;

		///<summary>
		///
		///</summary>
		public void Set_NextAutoCounterParcelCurve(dynamic pVal) 
		{
			this._i.NextAutoCounterParcelCurve = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic NextManualCounterParcelCurve => this._i.NextManualCounterParcelCurve;

		///<summary>
		///
		///</summary>
		public void Set_NextManualCounterParcelCurve(dynamic pVal) 
		{
			this._i.NextManualCounterParcelCurve = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic NextAutoCounterAlignmentLine => this._i.NextAutoCounterAlignmentLine;

		///<summary>
		///
		///</summary>
		public void Set_NextAutoCounterAlignmentLine(dynamic pVal) 
		{
			this._i.NextAutoCounterAlignmentLine = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic NextManualCounterAlignmentLine => this._i.NextManualCounterAlignmentLine;

		///<summary>
		///
		///</summary>
		public void Set_NextManualCounterAlignmentLine(dynamic pVal) 
		{
			this._i.NextManualCounterAlignmentLine = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic NextAutoCounterAlignmentCurve => this._i.NextAutoCounterAlignmentCurve;

		///<summary>
		///
		///</summary>
		public void Set_NextAutoCounterAlignmentCurve(dynamic pVal) 
		{
			this._i.NextAutoCounterAlignmentCurve = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic NextManualCounterAlignmentCurve => this._i.NextManualCounterAlignmentCurve;

		///<summary>
		///
		///</summary>
		public void Set_NextManualCounterAlignmentCurve(dynamic pVal) 
		{
			this._i.NextManualCounterAlignmentCurve = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic NextAutoCounterAlignmentSpiral => this._i.NextAutoCounterAlignmentSpiral;

		///<summary>
		///
		///</summary>
		public void Set_NextAutoCounterAlignmentSpiral(dynamic pVal) 
		{
			this._i.NextAutoCounterAlignmentSpiral = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic NextManualCounterAlignmentSpiral => this._i.NextManualCounterAlignmentSpiral;

		///<summary>
		///
		///</summary>
		public void Set_NextManualCounterAlignmentSpiral(dynamic pVal) 
		{
			this._i.NextManualCounterAlignmentSpiral = pVal;
		}
	}
}
