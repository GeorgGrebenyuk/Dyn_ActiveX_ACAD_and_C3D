namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfacePointStyle 
	{
		public AeccXLandLib.IAeccSurfacePointStyle _i;
		internal AeccSurfacePointStyle(object AeccSurfacePointStyle_object) 
		{
			this._i = AeccSurfacePointStyle_object as AeccXLandLib.IAeccSurfacePointStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic ScalingMethodType => this._i.ScalingMethodType;

		///<summary>
		///
		///</summary>
		public void Set_ScalingMethodType(AeccXLandLib.AeccScalingMethodType pVal) 
		{
			this._i.ScalingMethodType = pVal;
		}

		///<summary>
		///
		///</summary>
		public double Units => this._i.Units;

		///<summary>
		///
		///</summary>
		public void Set_Units(double pVal) 
		{
			this._i.Units = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic DataPointsDisplayType => this._i.DataPointsDisplayType;

		///<summary>
		///
		///</summary>
		public void Set_DataPointsDisplayType(dynamic pVal) 
		{
			this._i.DataPointsDisplayType = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic DerivedPointsDisplayType => this._i.DerivedPointsDisplayType;

		///<summary>
		///
		///</summary>
		public void Set_DerivedPointsDisplayType(dynamic pVal) 
		{
			this._i.DerivedPointsDisplayType = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic NonDestructivePointsDisplayType => this._i.NonDestructivePointsDisplayType;

		///<summary>
		///
		///</summary>
		public void Set_NonDestructivePointsDisplayType(dynamic pVal) 
		{
			this._i.NonDestructivePointsDisplayType = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic DisplayStyle2d => this._i.DisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic DisplayStyle3d => this._i.DisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic DisplayStylePlan => this._i.DisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic DisplayStyleModel => this._i.DisplayStyleModel;
	}
}
