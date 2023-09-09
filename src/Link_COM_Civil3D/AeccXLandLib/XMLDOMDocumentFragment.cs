namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class XMLDOMDocumentFragment 
	{
		public Autodesk.AECC.Interop.Land.IXMLDOMDocumentFragment _i;
		internal XMLDOMDocumentFragment(object XMLDOMDocumentFragment_object) 
		{
			this._i = XMLDOMDocumentFragment_object as Autodesk.AECC.Interop.Land.IXMLDOMDocumentFragment;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
