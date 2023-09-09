namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class XMLDOMCDATASection 
	{
		public Autodesk.AECC.Interop.Land.IXMLDOMCDATASection _i;
		internal XMLDOMCDATASection(object XMLDOMCDATASection_object) 
		{
			this._i = XMLDOMCDATASection_object as Autodesk.AECC.Interop.Land.IXMLDOMCDATASection;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
