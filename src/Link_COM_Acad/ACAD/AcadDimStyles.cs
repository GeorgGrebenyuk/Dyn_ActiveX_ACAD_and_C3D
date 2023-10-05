namespace DynAXDBLib 
{

    ///<summary>
    /// The collection of all dimension styles in the drawing. There is no limit to the number of dimension styles that you can create in your drawing. However, there can be only one instance of the DimStyles collection. The DimStyles collection is predefined for each drawing. You can make multiple references to it by using the DimStyles property. Once done with an object, the reference is automatically released
    ///</summary>
    public class AcadDimStyles 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadDimStyles _i;
		internal AcadDimStyles(object AcadDimStyles_object) 
		{
			this._i = AcadDimStyles_object as Autodesk.AutoCAD.Interop.Common.AcadDimStyles;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public int Count => this._i.Count;

	}
}
