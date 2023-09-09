namespace DynAeccXLandLib 
{

	///<summary>
	///structure for reporting parser errors
	///</summary>
	public class XMLDOMParseError 
	{
		public Autodesk.AECC.Interop.Land.IXMLDOMParseError _i;
		internal XMLDOMParseError(object XMLDOMParseError_object) 
		{
			this._i = XMLDOMParseError_object as Autodesk.AECC.Interop.Land.IXMLDOMParseError;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///the error code
		///</summary>
		public dynamic errorCode => this._i.errorCode;

		///<summary>
		///the URL of the XML document containing the error
		///</summary>
		public string url => this._i.url;

		///<summary>
		///the cause of the error
		///</summary>
		public string reason => this._i.reason;

		///<summary>
		///the data where the error occurred
		///</summary>
		public string srcText => this._i.srcText;

		///<summary>
		///the line number in the XML document where the error occurred
		///</summary>
		public dynamic line => this._i.line;

		///<summary>
		///the character position in the line containing the error
		///</summary>
		public dynamic linepos => this._i.linepos;

		///<summary>
		///the absolute file position in the XML document containing the error
		///</summary>
		public dynamic filepos => this._i.filepos;
	}
}
