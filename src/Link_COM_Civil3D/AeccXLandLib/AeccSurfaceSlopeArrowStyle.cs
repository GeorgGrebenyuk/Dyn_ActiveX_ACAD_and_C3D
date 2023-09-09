namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceSlopeArrowStyle 
	{
		public AeccXLandLib.IAeccSurfaceSlopeArrowStyle _i;
		internal AeccSurfaceSlopeArrowStyle(object AeccSurfaceSlopeArrowStyle_object) 
		{
			this._i = AeccSurfaceSlopeArrowStyle_object as AeccXLandLib.IAeccSurfaceSlopeArrowStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic GroupValuesBy => this._i.GroupValuesBy;

		///<summary>
		///
		///</summary>
		public void Set_GroupValuesBy(AeccXLandLib.AeccGroupValuesByType pVal) 
		{
			this._i.GroupValuesBy = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic NumberOfRanges => this._i.NumberOfRanges;

		///<summary>
		///
		///</summary>
		public void Set_NumberOfRanges(dynamic pVal) 
		{
			this._i.NumberOfRanges = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic RangePrecision => this._i.RangePrecision;

		///<summary>
		///
		///</summary>
		public void Set_RangePrecision(AeccXLandLib.AeccPrecisionRangeType pVal) 
		{
			this._i.RangePrecision = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic ArrowType => this._i.ArrowType;

		///<summary>
		///
		///</summary>
		public void Set_ArrowType(AeccXLandLib.AeccArrowType pVal) 
		{
			this._i.ArrowType = pVal;
		}

		///<summary>
		///
		///</summary>
		public double ArrowScale => this._i.ArrowScale;

		///<summary>
		///
		///</summary>
		public void Set_ArrowScale(double pVal) 
		{
			this._i.ArrowScale = pVal;
		}

		///<summary>
		///
		///</summary>
		public string Scheme => this._i.Scheme;

		///<summary>
		///
		///</summary>
		public void Set_Scheme(string pVal) 
		{
			this._i.Scheme = pVal;
		}

		///<summary>
		///
		///</summary>
		public string LegendStyle => this._i.LegendStyle;

		///<summary>
		///
		///</summary>
		public void Set_LegendStyle(string pVal) 
		{
			this._i.LegendStyle = pVal;
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
