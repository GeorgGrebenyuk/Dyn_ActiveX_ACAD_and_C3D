namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccBandTitleStyle 
	{
		public Autodesk.AECC.Interop.Land.IAeccBandTitleStyle _i;
		internal AeccBandTitleStyle(object AeccBandTitleStyle_object) 
		{
			this._i = AeccBandTitleStyle_object as Autodesk.AECC.Interop.Land.IAeccBandTitleStyle;
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
		public void Set_TextBoxWidth(double pVal) 
		{
			this._i.TextBoxWidth = pVal;
		}

		///<summary>
		///
		///</summary>
		public double TextBoxWidth => this._i.TextBoxWidth;

		///<summary>
		///
		///</summary>
		public void Set_OffsetFromBand(double pVal) 
		{
			this._i.OffsetFromBand = pVal;
		}

		///<summary>
		///
		///</summary>
		public double OffsetFromBand => this._i.OffsetFromBand;

		///<summary>
		///
		///</summary>
		public int TextBoxPosition => this._i.TextBoxPosition;

		///<summary>
		///
		///</summary>
		public void Set_TextBoxPosition(int pVal) 
		{
			this._i.TextBoxPosition = pVal;
		}
	}
}
