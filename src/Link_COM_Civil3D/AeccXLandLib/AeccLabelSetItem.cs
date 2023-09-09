namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelSetItem 
	{
		public AeccXLandLib.IAeccLabelSetItem _i;
		internal AeccLabelSetItem(object AeccLabelSetItem_object) 
		{
			this._i = AeccLabelSetItem_object as AeccXLandLib.IAeccLabelSetItem;
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
		public double StartStation => this._i.StartStation;

		///<summary>
		///
		///</summary>
		public void Set_StartStation(double pVal) 
		{
			this._i.StartStation = pVal;
		}

		///<summary>
		///
		///</summary>
		public double EndStation => this._i.EndStation;

		///<summary>
		///
		///</summary>
		public void Set_EndStation(double pVal) 
		{
			this._i.EndStation = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool StartStationEnabled => this._i.StartStationEnabled;

		///<summary>
		///
		///</summary>
		public void Set_StartStationEnabled(bool pVal) 
		{
			this._i.StartStationEnabled = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool EndStationEnabled => this._i.EndStationEnabled;

		///<summary>
		///
		///</summary>
		public void Set_EndStationEnabled(bool pVal) 
		{
			this._i.EndStationEnabled = pVal;
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
		public int Id => this._i.Id;
	}
}
