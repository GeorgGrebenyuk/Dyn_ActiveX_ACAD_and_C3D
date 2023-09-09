namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAxisTitleStyle 
	{
		public Autodesk.AECC.Interop.Land.IAeccAxisTitleStyle _i;
		internal AeccAxisTitleStyle(object AeccAxisTitleStyle_object) 
		{
			this._i = AeccAxisTitleStyle_object as Autodesk.AECC.Interop.Land.IAeccAxisTitleStyle;
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
		public void Set_Position(Autodesk.AECC.Interop.Land.AeccTitlePositionType pVal) 
		{
			this._i.Position = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Position => this._i.Position;

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
		public dynamic DisplayStyle2d => this._i.DisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic DisplayStylePlan => this._i.DisplayStylePlan;
	}
}
