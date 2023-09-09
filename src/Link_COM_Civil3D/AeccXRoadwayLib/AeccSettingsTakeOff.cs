namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsTakeOff 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccSettingsTakeOff _i;
		internal AeccSettingsTakeOff(object AeccSettingsTakeOff_object) 
		{
			this._i = AeccSettingsTakeOff_object as Autodesk.AECC.Interop.Roadway.IAeccSettingsTakeOff;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic ReportType => this._i.ReportType;

		///<summary>
		///
		///</summary>
		public dynamic ReportExtents => this._i.ReportExtents;

		///<summary>
		///
		///</summary>
		public dynamic ReportSelectedOnly => this._i.ReportSelectedOnly;

		///<summary>
		///
		///</summary>
		public dynamic LimitToAlignmentStation => this._i.LimitToAlignmentStation;

		///<summary>
		///
		///</summary>
		public dynamic DefaultReportStyle => this._i.DefaultReportStyle;

		///<summary>
		///
		///</summary>
		public dynamic ReportTableFont => this._i.ReportTableFont;

		///<summary>
		///
		///</summary>
		public dynamic LengthType => this._i.LengthType;

		///<summary>
		///
		///</summary>
		public dynamic PipeLengthType => this._i.PipeLengthType;

		///<summary>
		///
		///</summary>
		public dynamic IncludeFormulas => this._i.IncludeFormulas;
	}
}
