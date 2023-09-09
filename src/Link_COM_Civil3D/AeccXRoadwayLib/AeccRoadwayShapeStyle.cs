namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccRoadwayShapeStyle 
	{
		public AeccXRoadwayLib.IAeccRoadwayShapeStyle _i;
		internal AeccRoadwayShapeStyle(object AeccRoadwayShapeStyle_object) 
		{
			this._i = AeccRoadwayShapeStyle_object as AeccXRoadwayLib.IAeccRoadwayShapeStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic BorderDisplayStyle2d => this._i.BorderDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic BorderDisplayStyle3d => this._i.BorderDisplayStyle3d;

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
		public dynamic BorderDisplayStylePlan => this._i.BorderDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic BorderDisplayStyleModel => this._i.BorderDisplayStyleModel;

		///<summary>
		///
		///</summary>
		public dynamic BorderDisplayStyleSection => this._i.BorderDisplayStyleSection;

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
		public dynamic AreaFillDisplayStyleSection => this._i.AreaFillDisplayStyleSection;

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
		public dynamic AreaFillHatchDisplayStyleSection => this._i.AreaFillHatchDisplayStyleSection;
	}
}
