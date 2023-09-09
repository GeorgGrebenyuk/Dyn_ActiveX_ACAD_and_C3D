namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class XMLDOMEntityReference 
	{
		public Autodesk.AECC.Interop.Land.IXMLDOMEntityReference _i;
		internal XMLDOMEntityReference(object XMLDOMEntityReference_object) 
		{
			this._i = XMLDOMEntityReference_object as Autodesk.AECC.Interop.Land.IXMLDOMEntityReference;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
