namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAutoFeatureLabelGroup 
	{
		public Autodesk.AECC.Interop.Land.IAeccAutoFeatureLabelGroup _i;
		internal AeccAutoFeatureLabelGroup(object AeccAutoFeatureLabelGroup_object) 
		{
			this._i = AeccAutoFeatureLabelGroup_object as Autodesk.AECC.Interop.Land.IAeccAutoFeatureLabelGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic LabelStyle => this._i.LabelStyle;

		///<summary>
		///
		///</summary>
		public void Set_LabelStyle(object pVal) 
		{
			this._i.LabelStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UseFeatureStart => this._i.UseFeatureStart;

		///<summary>
		///
		///</summary>
		public void Set_UseFeatureStart(bool pVal) 
		{
			this._i.UseFeatureStart = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UseFeatureEnd => this._i.UseFeatureEnd;

		///<summary>
		///
		///</summary>
		public void Set_UseFeatureEnd(bool pVal) 
		{
			this._i.UseFeatureEnd = pVal;
		}

		///<summary>
		///
		///</summary>
		public double RangeStart => this._i.RangeStart;

		///<summary>
		///
		///</summary>
		public void Set_RangeStart(double pVal) 
		{
			this._i.RangeStart = pVal;
		}

		///<summary>
		///
		///</summary>
		public double RangeEnd => this._i.RangeEnd;

		///<summary>
		///
		///</summary>
		public void Set_RangeEnd(double pVal) 
		{
			this._i.RangeEnd = pVal;
		}
	}
}
