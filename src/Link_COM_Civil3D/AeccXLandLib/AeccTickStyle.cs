namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccTickStyle 
	{
		public Autodesk.AECC.Interop.Land.IAeccTickStyle _i;
		internal AeccTickStyle(object AeccTickStyle_object) 
		{
			this._i = AeccTickStyle_object as Autodesk.AECC.Interop.Land.IAeccTickStyle;
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
		public void Set_Size(double pVal) 
		{
			this._i.Size = pVal;
		}

		///<summary>
		///
		///</summary>
		public double Size => this._i.Size;

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
		public void Set_Interval(double pVal) 
		{
			this._i.Interval = pVal;
		}

		///<summary>
		///
		///</summary>
		public double Interval => this._i.Interval;

		///<summary>
		///
		///</summary>
		public dynamic DisplayStyle2d => this._i.DisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic AnnotationDisplayStyle2d => this._i.AnnotationDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic DisplayStylePlan => this._i.DisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic AnnotationDisplayStylePlan => this._i.AnnotationDisplayStylePlan;
	}
}
