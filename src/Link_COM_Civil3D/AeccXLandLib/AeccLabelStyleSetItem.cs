namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelStyleSetItem 
	{
		public AeccXLandLib.IAeccLabelStyleSetItem _i;
		internal AeccLabelStyleSetItem(object AeccLabelStyleSetItem_object) 
		{
			this._i = AeccLabelStyleSetItem_object as AeccXLandLib.IAeccLabelStyleSetItem;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Type => this._i.Type;

		///<summary>
		///
		///</summary>
		public dynamic Style => this._i.Style;

		///<summary>
		///
		///</summary>
		public void Put_Style(dynamic LabelStyle) 
		{
			this._i.Style = LabelStyle;
		}

		///<summary>
		///
		///</summary>
		public dynamic DimensionAnchorOption => this._i.DimensionAnchorOption;

		///<summary>
		///
		///</summary>
		public void Set_DimensionAnchorOption(AeccXLandLib.AeccLabelDimensionAnchorType pVal) 
		{
			this._i.DimensionAnchorOption = pVal;
		}

		///<summary>
		///
		///</summary>
		public double DimensionAnchorValue => this._i.DimensionAnchorValue;

		///<summary>
		///
		///</summary>
		public void Set_DimensionAnchorValue(double pVal) 
		{
			this._i.DimensionAnchorValue = pVal;
		}

		///<summary>
		///
		///</summary>
		public object Id => this._i.Id;
	}
}
