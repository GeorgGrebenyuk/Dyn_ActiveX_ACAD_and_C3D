namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class XMLDOMEntityReference 
	{
		public AeccXLandLib.IXMLDOMEntityReference _i;
		internal XMLDOMEntityReference(object XMLDOMEntityReference_object) 
		{
			this._i = XMLDOMEntityReference_object as AeccXLandLib.IXMLDOMEntityReference;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
