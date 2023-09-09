namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadMLine 
	{
		public AXDBLib.IAcadMLine _i;
		internal AcadMLine(object AcadMLine_object) 
		{
			this._i = AcadMLine_object as AXDBLib.IAcadMLine;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string StyleName => this._i.StyleName;

		///<summary>
		///
		///</summary>
		public object Coordinates => this._i.Coordinates;

		///<summary>
		///
		///</summary>
		public void Set_Coordinates(object Vertices) 
		{
			this._i.Coordinates = Vertices;
		}

		///<summary>
		///
		///</summary>
		public dynamic Justification => this._i.Justification;

		///<summary>
		///
		///</summary>
		public void Set_Justification(AXDBLib.AcMLineJustification Justification) 
		{
			this._i.Justification = Justification;
		}

		///<summary>
		///
		///</summary>
		public double MLineScale => this._i.MLineScale;

		///<summary>
		///
		///</summary>
		public void Set_MLineScale(double scale) 
		{
			this._i.MLineScale = scale;
		}
	}
}
