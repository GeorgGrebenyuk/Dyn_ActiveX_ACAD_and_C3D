namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadAcCmColor 
	{
		public AXDBLib.IAcadAcCmColor _i;
		internal AcadAcCmColor(object AcadAcCmColor_object) 
		{
			this._i = AcadAcCmColor_object as AXDBLib.IAcadAcCmColor;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_EntityColor(int eColor) 
		{
			this._i.EntityColor = eColor;
		}

		///<summary>
		///
		///</summary>
		public int EntityColor => this._i.EntityColor;

		///<summary>
		///
		///</summary>
		public string ColorName => this._i.ColorName;

		///<summary>
		///
		///</summary>
		public string BookName => this._i.BookName;

		///<summary>
		///
		///</summary>
		public void SetNames(string ColorName,string BookName) 
		{
			this._i.SetNames(ColorName,BookName);
		}

		///<summary>
		///
		///</summary>
		public void Delete() 
		{
			this._i.Delete();
		}

		///<summary>
		///
		///</summary>
		public int Red => this._i.Red;

		///<summary>
		///
		///</summary>
		public int Blue => this._i.Blue;

		///<summary>
		///
		///</summary>
		public int Green => this._i.Green;

		///<summary>
		///
		///</summary>
		public void SetRGB(int Red, int Green, int Blue) 
		{
			this._i.SetRGB(Red,Green,Blue);
		}

		///<summary>
		///
		///</summary>
		public void Set_ColorMethod(AXDBLib.AcColorMethod Flags) 
		{
			this._i.ColorMethod = Flags;
		}

		///<summary>
		///
		///</summary>
		public dynamic ColorMethod => this._i.ColorMethod;

		///<summary>
		///
		///</summary>
		public dynamic ColorIndex => this._i.ColorIndex;

		///<summary>
		///
		///</summary>
		public void Set_ColorIndex(AXDBLib.AcColor color) 
		{
			this._i.ColorIndex = color;
		}

		///<summary>
		///
		///</summary>
		public void SetColorBookColor(string BookName,string ColorName) 
		{
			this._i.SetColorBookColor(BookName,ColorName);
		}
	}
}
