namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccGradingStyle 
	{
		public AeccXLandLib.IAeccGradingStyle _i;
		internal AeccGradingStyle(object AeccGradingStyle_object) 
		{
			this._i = AeccGradingStyle_object as AeccXLandLib.IAeccGradingStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic TargetLineDisplayStyle2d => this._i.TargetLineDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic TargetLineDisplayStyle3d => this._i.TargetLineDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic ProjectionLineDisplayStyle2d => this._i.ProjectionLineDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic ProjectionLineDisplayStyle3d => this._i.ProjectionLineDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic TargetLineDisplayStylePlan => this._i.TargetLineDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic TargetLineDisplayStyleModel => this._i.TargetLineDisplayStyleModel;

		///<summary>
		///
		///</summary>
		public dynamic ProjectionLineDisplayStylePlan => this._i.ProjectionLineDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic ProjectionLineDisplayStyleModel => this._i.ProjectionLineDisplayStyleModel;
	}
}
