namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class XMLDOMCDATASection 
	{
		public AeccXLandLib.IXMLDOMCDATASection _i;
		internal XMLDOMCDATASection(object XMLDOMCDATASection_object) 
		{
			this._i = XMLDOMCDATASection_object as AeccXLandLib.IXMLDOMCDATASection;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
