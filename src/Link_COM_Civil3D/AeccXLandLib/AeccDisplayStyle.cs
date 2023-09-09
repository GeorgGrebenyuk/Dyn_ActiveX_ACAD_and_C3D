namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccDisplayStyle 
	{
		public Autodesk.AECC.Interop.Land.IAeccDisplayStyle _i;
		internal AeccDisplayStyle(object AeccDisplayStyle_object) 
		{
			this._i = AeccDisplayStyle_object as Autodesk.AECC.Interop.Land.IAeccDisplayStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public bool Visible => this._i.Visible;

		///<summary>
		///
		///</summary>
		public void Set_Visible(bool pVal) 
		{
			this._i.Visible = pVal;
		}

		///<summary>
		///
		///</summary>
		public string Layer => this._i.Layer;

		///<summary>
		///
		///</summary>
		public void Set_Layer(string pVal) 
		{
			this._i.Layer = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Color => this._i.Color;

		///<summary>
		///
		///</summary>
		public void Set_Color(dynamic pVal) 
		{
			this._i.Color = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic TrueColor => this._i.TrueColor;

		///<summary>
		///
		///</summary>
		public void Put_TrueColor(dynamic pVal) 
		{
			this._i.TrueColor = pVal;
		}

		///<summary>
		///
		///</summary>
		public string Linetype => this._i.Linetype;

		///<summary>
		///
		///</summary>
		public void Set_Linetype(string pVal) 
		{
			this._i.Linetype = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Lineweight => this._i.Lineweight;

		///<summary>
		///
		///</summary>
		public void Set_Lineweight(dynamic pVal) 
		{
			this._i.Lineweight = pVal;
		}

		///<summary>
		///
		///</summary>
		public double LinetypeScale => this._i.LinetypeScale;

		///<summary>
		///
		///</summary>
		public void Set_LinetypeScale(double pVal) 
		{
			this._i.LinetypeScale = pVal;
		}

		///<summary>
		///
		///</summary>
		public string PlotStyle => this._i.PlotStyle;

		///<summary>
		///
		///</summary>
		public void Set_PlotStyle(string pVal) 
		{
			this._i.PlotStyle = pVal;
		}
	}
}
