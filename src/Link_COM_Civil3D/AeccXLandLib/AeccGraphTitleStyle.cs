namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccGraphTitleStyle 
	{
		public Autodesk.AECC.Interop.Land.IAeccGraphTitleStyle _i;
		internal AeccGraphTitleStyle(object AeccGraphTitleStyle_object) 
		{
			this._i = AeccGraphTitleStyle_object as Autodesk.AECC.Interop.Land.IAeccGraphTitleStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Text(string pVal) 
		{
			this._i.Text = pVal;
		}

		///<summary>
		///
		///</summary>
		public string Text => this._i.Text;

		///<summary>
		///
		///</summary>
		public void Set_TextStyle(string pVal) 
		{
			this._i.TextStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public string TextStyle => this._i.TextStyle;

		///<summary>
		///
		///</summary>
		public void Set_TextHeight(double pVal) 
		{
			this._i.TextHeight = pVal;
		}

		///<summary>
		///
		///</summary>
		public double TextHeight => this._i.TextHeight;

		///<summary>
		///
		///</summary>
		public void Set_Location(Autodesk.AECC.Interop.Land.AeccTitleLocationType pVal) 
		{
			this._i.Location = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Location => this._i.Location;

		///<summary>
		///
		///</summary>
		public void Set_Justification(Autodesk.AECC.Interop.Land.AeccTitlePositionType pVal) 
		{
			this._i.Justification = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Justification => this._i.Justification;

		///<summary>
		///
		///</summary>
		public void Set_Offset(object pVal) 
		{
			this._i.Offset = pVal;
		}

		///<summary>
		///
		///</summary>
		public object Offset => this._i.Offset;

		///<summary>
		///
		///</summary>
		public void Set_Border(bool pVal) 
		{
			this._i.Border = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool Border => this._i.Border;

		///<summary>
		///
		///</summary>
		public void Set_BorderGap(double pVal) 
		{
			this._i.BorderGap = pVal;
		}

		///<summary>
		///
		///</summary>
		public double BorderGap => this._i.BorderGap;

		///<summary>
		///
		///</summary>
		public dynamic DisplayStyle2d => this._i.DisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic DisplayStylePlan => this._i.DisplayStylePlan;
	}
}
