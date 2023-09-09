namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParcel 
	{
		public AeccXLandLib.IAeccParcel _i;
		internal AeccParcel(object AeccParcel_object) 
		{
			this._i = AeccParcel_object as AeccXLandLib.IAeccParcel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Statistics => this._i.Statistics;

		///<summary>
		///
		///</summary>
		public string StyleName => this._i.StyleName;

		///<summary>
		///
		///</summary>
		public dynamic Style => this._i.Style;

		///<summary>
		///
		///</summary>
		public void Set_Style(object pVal) 
		{
			this._i.Style = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic AreaLabelStyle => this._i.AreaLabelStyle;

		///<summary>
		///
		///</summary>
		public void Put_AreaLabelStyle(dynamic pVal) 
		{
			this._i.AreaLabelStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic ParcelLoops => this._i.ParcelLoops;

		///<summary>
		///
		///</summary>
		public dynamic Parent => this._i.Parent;

		///<summary>
		///
		///</summary>
		public void AddMultipleSegmentLabels(dynamic lineVal,dynamic curveVal,bool Clockwise) 
		{
			this._i.AddMultipleSegmentLabels(lineVal,curveVal,Clockwise);
		}

		///<summary>
		///
		///</summary>
		public void AddSingleSegmentLabel(dynamic Index,dynamic lineVal,dynamic curveVal) 
		{
			this._i.AddSingleSegmentLabel(Index,lineVal,curveVal);
		}

		///<summary>
		///
		///</summary>
		public dynamic Number => this._i.Number;

		///<summary>
		///
		///</summary>
		public void Set_Number(dynamic pVal) 
		{
			this._i.Number = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic AreaLabels => this._i.AreaLabels;

		///<summary>
		///
		///</summary>
		public object GetUserDefinedPropertyValue(object userDefinedProperty) 
		{
			return this._i.GetUserDefinedPropertyValue(userDefinedProperty);
		}

		///<summary>
		///
		///</summary>
		public void SetUserDefinedPropertyValue(object userDefinedProperty,object newValue) 
		{
			this._i.SetUserDefinedPropertyValue(userDefinedProperty,newValue);
		}
	}
}
