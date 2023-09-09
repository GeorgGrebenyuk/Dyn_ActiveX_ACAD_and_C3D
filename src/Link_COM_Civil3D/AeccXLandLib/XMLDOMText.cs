namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class XMLDOMText 
	{
		public Autodesk.AECC.Interop.Land.IXMLDOMText _i;
		internal XMLDOMText(object XMLDOMText_object) 
		{
			this._i = XMLDOMText_object as Autodesk.AECC.Interop.Land.IXMLDOMText;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///split the text node into two text nodes at the position specified
		///</summary>
		public dynamic splitText(dynamic Offset) 
		{
			return this._i.splitText(Offset);
		}
	}
}
