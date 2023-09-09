namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccBandStyle 
	{
		public Autodesk.AECC.Interop.Land.IAeccBandStyle _i;
		internal AeccBandStyle(object AeccBandStyle_object) 
		{
			this._i = AeccBandStyle_object as Autodesk.AECC.Interop.Land.IAeccBandStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Type => this._i.Type;

		///<summary>
		///
		///</summary>
		public void Set_Height(double pVal) 
		{
			this._i.Height = pVal;
		}

		///<summary>
		///
		///</summary>
		public double Height => this._i.Height;

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
		public dynamic TitleStyle => this._i.TitleStyle;

		///<summary>
		///
		///</summary>
		public dynamic BorderDisplayStyle2d => this._i.BorderDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic TitleBoxDisplayStyle2d => this._i.TitleBoxDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic TitleBoxTextDisplayStyle2d => this._i.TitleBoxTextDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic BorderDisplayStylePlan => this._i.BorderDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic TitleBoxDisplayStylePlan => this._i.TitleBoxDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic TitleBoxTextDisplayStylePlan => this._i.TitleBoxTextDisplayStylePlan;
	}
}
