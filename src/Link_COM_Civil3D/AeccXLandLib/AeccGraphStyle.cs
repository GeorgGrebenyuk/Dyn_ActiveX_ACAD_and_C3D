namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccGraphStyle 
	{
		public Autodesk.AECC.Interop.Land.IAeccGraphStyle _i;
		internal AeccGraphStyle(object AeccGraphStyle_object) 
		{
			this._i = AeccGraphStyle_object as Autodesk.AECC.Interop.Land.IAeccGraphStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic OriginPosition => this._i.OriginPosition;

		///<summary>
		///
		///</summary>
		public void Set_Direction(Autodesk.AECC.Interop.Land.AeccGraphDirectionType pVal) 
		{
			this._i.Direction = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Direction => this._i.Direction;

		///<summary>
		///
		///</summary>
		public void Set_VerticalExaggeration(double pVal) 
		{
			this._i.VerticalExaggeration = pVal;
		}

		///<summary>
		///
		///</summary>
		public double VerticalExaggeration => this._i.VerticalExaggeration;

		///<summary>
		///
		///</summary>
		public dynamic TitleStyle => this._i.TitleStyle;

		///<summary>
		///
		///</summary>
		public dynamic GridStyle => this._i.GridStyle;
	}
}
