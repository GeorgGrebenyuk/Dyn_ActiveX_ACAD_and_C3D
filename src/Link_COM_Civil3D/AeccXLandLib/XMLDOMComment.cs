namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class XMLDOMComment 
	{
		public Autodesk.AECC.Interop.Land.IXMLDOMComment _i;
		internal XMLDOMComment(object XMLDOMComment_object) 
		{
			this._i = XMLDOMComment_object as Autodesk.AECC.Interop.Land.IXMLDOMComment;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
