namespace DynAXDBLib 
{

    ///<summary>
    /// AutoCAD true color object. The AcCmColor object represents colors. You can use the AcCmColor object to set colors and perform other color-related operations on objects. The object includes properties for colors, color names, color book names, and the color index
    ///</summary>
    public class AcadAcCmColor 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadAcCmColor _i;
		internal AcadAcCmColor(object AcadAcCmColor_object) 
		{
			this._i = AcadAcCmColor_object as Autodesk.AutoCAD.Interop.Common.AcadAcCmColor;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

        ///<summary>
        ///Specifies the color value of the true color
        ///</summary>
        public void Set_EntityColor(int eColor) 
		{
			this._i.EntityColor = eColor;
		}

        ///<summary>
        ///Specifies the color value of the true color
        ///</summary>
        public int EntityColor => this._i.EntityColor;

        ///<summary>
        ///Specifies the name (if any) of the color
        ///</summary>
        public string ColorName => this._i.ColorName;

        ///<summary>
        ///Specifies the book name (if any) of the color
        ///</summary>
        public string BookName => this._i.BookName;

        /// <summary>
		/// Specifies the color name and book name of the color
		/// </summary>
		/// <param name="ColorName">The name of the color.</param>
		/// <param name="BookName">The color book name of the color</param>
        public void SetNames(string ColorName,string BookName) 
		{
			this._i.SetNames(ColorName,BookName);
		}

        ///<summary>
        ///Deletes a specified object or a set of saved layer settings
        ///</summary>
        public void Delete() 
		{
			this._i.Delete();
		}

        ///<summary>
        ///Specifies the red component of the True Color
        ///</summary>
        public int Red => this._i.Red;

        ///<summary>
        ///Specifies the blue component of the True Color
        ///</summary>
        public int Blue => this._i.Blue;

        ///<summary>
        ///Specifies the green component of the True Color
        ///</summary>
        public int Green => this._i.Green;

        ///<summary>
        ///Specifies the RGB values of the True Color
        ///</summary>
        public void SetRGB(int Red, int Green, int Blue) 
		{
			this._i.SetRGB(Red,Green,Blue);
		}

        ///<summary>
        ///Specifies the color method
        ///</summary>
        public void Set_ColorMethod(Autodesk.AutoCAD.Interop.Common.AcColorMethod Flags) 
		{
			this._i.ColorMethod = Flags;
		}

        ///<summary>
        ///Specifies the color method
        ///</summary>
        public object ColorMethod => this._i.ColorMethod;

        ///<summary>
        ///Specifies the color index
        ///</summary>
        public object ColorIndex => this._i.ColorIndex;

        ///<summary>
        ///Specifies the color index
        ///</summary>
        public void Set_ColorIndex(Autodesk.AutoCAD.Interop.Common.AcColor color) 
		{
			this._i.ColorIndex = color;
		}

        /// <summary>
        /// Specifies the color name from an existing color book
        /// </summary>
        /// <param name="BookName">The file name of the color book</param>
        /// <param name="ColorName">The name of the color</param>
        public void SetColorBookColor(string BookName,string ColorName) 
		{
			this._i.SetColorBookColor(BookName,ColorName);
		}
	}
}
