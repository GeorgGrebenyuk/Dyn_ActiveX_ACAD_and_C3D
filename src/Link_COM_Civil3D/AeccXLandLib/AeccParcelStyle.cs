namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParcelStyle 
	{
		public AeccXLandLib.IAeccParcelStyle _i;
		internal AeccParcelStyle(object AeccParcelStyle_object) 
		{
			this._i = AeccParcelStyle_object as AeccXLandLib.IAeccParcelStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_ObservePatternFillDistance(bool pVal) 
		{
			this._i.ObservePatternFillDistance = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool ObservePatternFillDistance => this._i.ObservePatternFillDistance;

		///<summary>
		///
		///</summary>
		public void Set_PatternFillDistance(double pVal) 
		{
			this._i.PatternFillDistance = pVal;
		}

		///<summary>
		///
		///</summary>
		public double PatternFillDistance => this._i.PatternFillDistance;

		///<summary>
		///
		///</summary>
		public void Set_NameTemplate(string pVal) 
		{
			this._i.NameTemplate = pVal;
		}

		///<summary>
		///
		///</summary>
		public string NameTemplate => this._i.NameTemplate;

		///<summary>
		///
		///</summary>
		public dynamic SegmentsDisplayStyle2d => this._i.SegmentsDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic SegmentsDisplayStyle3d => this._i.SegmentsDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic AreaFillDisplayStyle2d => this._i.AreaFillDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic AreaFillDisplayStyle3d => this._i.AreaFillDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic AreaFillHatchDisplayStyle2d => this._i.AreaFillHatchDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic AreaFillHatchDisplayStyle3d => this._i.AreaFillHatchDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic SegmentsDisplayStylePlan => this._i.SegmentsDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic SegmentsDisplayStyleModel => this._i.SegmentsDisplayStyleModel;

		///<summary>
		///
		///</summary>
		public dynamic AreaFillDisplayStylePlan => this._i.AreaFillDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic AreaFillDisplayStyleModel => this._i.AreaFillDisplayStyleModel;

		///<summary>
		///
		///</summary>
		public dynamic AreaFillHatchDisplayStylePlan => this._i.AreaFillHatchDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic AreaFillHatchDisplayStyleModel => this._i.AreaFillHatchDisplayStyleModel;

		///<summary>
		///
		///</summary>
		public dynamic AreaFillHatchDisplayStyleProfile => this._i.AreaFillHatchDisplayStyleProfile;

		///<summary>
		///
		///</summary>
		public dynamic AreaFillHatchDisplayStyleSection => this._i.AreaFillHatchDisplayStyleSection;
	}
}
