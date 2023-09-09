namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class XMLDOMDocumentType 
	{
		public AeccXLandLib.IXMLDOMDocumentType _i;
		internal XMLDOMDocumentType(object XMLDOMDocumentType_object) 
		{
			this._i = XMLDOMDocumentType_object as AeccXLandLib.IXMLDOMDocumentType;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///root of the tree)
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///a list of entities in the document
		///</summary>
		public dynamic Entities => this._i.Entities;

		///<summary>
		///a list of notations in the document
		///</summary>
		public dynamic notations => this._i.notations;
	}
}
