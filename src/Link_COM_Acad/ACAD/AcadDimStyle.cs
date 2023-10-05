namespace DynAXDBLib 
{

    ///<summary>
    /// A group of dimension settings that determines the appearance of a dimension. The active dimension style determines the appearance of new dimensions that are created in the drawing. To change the style of an existing dimension, use the StyleName property found on the dimension
    ///</summary>
    public class AcadDimStyle 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadDimStyle _i;
		internal AcadDimStyle(object AcadDimStyle_object) 
		{
			this._i = AcadDimStyle_object as Autodesk.AutoCAD.Interop.Common.AcadDimStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Create new DimStyle by name
        /// </summary>
        /// <param name="acadDimStyles"></param>
        /// <param name="Name"></param>
        public AcadDimStyle(AcadDimStyles acadDimStyles, string Name)
		{
			try
			{
				this._i = acadDimStyles._i.Add(Name);
			}
			catch { }
		}

        ///<summary>
        ///
        ///</summary>
        public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public void Set_Name(string bstrName) 
		{
			this._i.Name = bstrName;
		}

		///<summary>
		///
		///</summary>
		public void CopyFrom(dynamic StyleSource) 
		{
			this._i.CopyFrom(StyleSource);
		}
	}
}
