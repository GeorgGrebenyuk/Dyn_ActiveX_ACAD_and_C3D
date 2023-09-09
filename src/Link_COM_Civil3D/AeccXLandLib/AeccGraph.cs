namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccGraph 
	{
		public AeccXLandLib.IAeccGraph _i;
		internal AeccGraph(object AeccGraph_object) 
		{
			this._i = AeccGraph_object as AeccXLandLib.IAeccGraph;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string StyleName => this._i.StyleName;

		///<summary>
		///
		///</summary>
		public void Set_VerticalScale(double pVal) 
		{
			this._i.VerticalScale = pVal;
		}

		///<summary>
		///
		///</summary>
		public double VerticalScale => this._i.VerticalScale;

		///<summary>
		///
		///</summary>
		public dynamic Type => this._i.Type;

		///<summary>
		///
		///</summary>
		public void Layout() 
		{
			this._i.Layout();
		}

		///<summary>
		///
		///</summary>
		public bool IsValid => this._i.IsValid;
	}
}
