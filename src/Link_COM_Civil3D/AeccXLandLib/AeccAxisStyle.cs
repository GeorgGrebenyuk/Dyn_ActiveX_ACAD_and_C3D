namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAxisStyle 
	{
		public AeccXLandLib.IAeccAxisStyle _i;
		internal AeccAxisStyle(object AeccAxisStyle_object) 
		{
			this._i = AeccAxisStyle_object as AeccXLandLib.IAeccAxisStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

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
		public dynamic MinorTickStyle => this._i.MinorTickStyle;

		///<summary>
		///
		///</summary>
		public dynamic MajorTickStyle => this._i.MajorTickStyle;

		///<summary>
		///
		///</summary>
		public dynamic DisplaySyle2d => this._i.DisplaySyle2d;
	}
}
