namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class XMLDOMDocument 
	{
		public AeccXLandLib.IXMLDOMDocument _i;
		internal XMLDOMDocument(object XMLDOMDocument_object) 
		{
			this._i = XMLDOMDocument_object as AeccXLandLib.IXMLDOMDocument;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///node corresponding to the DOCTYPE
		///</summary>
		public dynamic doctype => this._i.doctype;

		///<summary>
		///info on this DOM implementation
		///</summary>
		public dynamic implementation => this._i.implementation;

		///<summary>
		///the root of the tree
		///</summary>
		public dynamic documentElement => this._i.documentElement;

		///<summary>
		///the root of the tree
		///</summary>
		public void Put_documentElement(dynamic DOMElement) 
		{
			this._i.documentElement = DOMElement;
		}

		///<summary>
		///create an Element node
		///</summary>
		public dynamic createElement(string tagName) 
		{
			return this._i.createElement(tagName);
		}

		///<summary>
		///create a DocumentFragment node
		///</summary>
		public dynamic createDocumentFragment => this._i.createDocumentFragment;

		///<summary>
		///create a text node
		///</summary>
		public dynamic createTextNode(string data) 
		{
			return this._i.createTextNode(data);
		}

		///<summary>
		///create a comment node
		///</summary>
		public dynamic createComment(string data) 
		{
			return this._i.createComment(data);
		}

		///<summary>
		///create a CDATA section node
		///</summary>
		public dynamic createCDATASection(string data) 
		{
			return this._i.createCDATASection(data);
		}

		///<summary>
		///create a processing instruction node
		///</summary>
		public dynamic createProcessingInstruction(string target,string data) 
		{
			return this._i.createProcessingInstruction(target,data);
		}

		///<summary>
		///create an attribute node
		///</summary>
		public dynamic createAttribute(string Name) 
		{
			return this._i.createAttribute(Name);
		}

		///<summary>
		///create an entity reference node
		///</summary>
		public dynamic createEntityReference(string Name) 
		{
			return this._i.createEntityReference(Name);
		}

		///<summary>
		///build a list of elements by name
		///</summary>
		public dynamic getElementsByTagName(string tagName) 
		{
			return this._i.getElementsByTagName(tagName);
		}

		///<summary>
		///create a node of the specified node type and name
		///</summary>
		public dynamic createNode(object Type,string Name,string namespaceURI) 
		{
			return this._i.createNode(Type,Name,namespaceURI);
		}

		///<summary>
		///retrieve node from it's ID
		///</summary>
		public dynamic nodeFromID(string idString) 
		{
			return this._i.nodeFromID(idString);
		}

		///<summary>
		///load document from the specified XML source
		///</summary>
		public bool load(object xmlSource) 
		{
			return this._i.load(xmlSource);
		}

		///<summary>
		///get the state of the XML document
		///</summary>
		public dynamic readyState => this._i.readyState;

		///<summary>
		///get the last parser error
		///</summary>
		public dynamic parseError => this._i.parseError;

		///<summary>
		///get the URL for the loaded XML document
		///</summary>
		public string url => this._i.url;

		///<summary>
		///flag for asynchronous download
		///</summary>
		public bool async => this._i.async;

		///<summary>
		///flag for asynchronous download
		///</summary>
		public void Set_async(bool isAsync) 
		{
			this._i.async = isAsync;
		}

		///<summary>
		///abort an asynchronous download
		///</summary>
		public void abort() 
		{
			this._i.abort();
		}

		///<summary>
		///load the document from a string
		///</summary>
		public bool loadXML(string bstrXML) 
		{
			return this._i.loadXML(bstrXML);
		}

		///<summary>
		///save the document to a specified destination
		///</summary>
		public void save(object destination) 
		{
			this._i.save(destination);
		}

		///<summary>
		///indicates whether the parser performs validation
		///</summary>
		public bool validateOnParse => this._i.validateOnParse;

		///<summary>
		///indicates whether the parser performs validation
		///</summary>
		public void Set_validateOnParse(bool isValidating) 
		{
			this._i.validateOnParse = isValidating;
		}

		///<summary>
		///indicates whether the parser resolves references to external DTD/Entities/Schema
		///</summary>
		public bool resolveExternals => this._i.resolveExternals;

		///<summary>
		///indicates whether the parser resolves references to external DTD/Entities/Schema
		///</summary>
		public void Set_resolveExternals(bool isResolving) 
		{
			this._i.resolveExternals = isResolving;
		}

		///<summary>
		///indicates whether the parser preserves whitespace
		///</summary>
		public bool preserveWhiteSpace => this._i.preserveWhiteSpace;

		///<summary>
		///indicates whether the parser preserves whitespace
		///</summary>
		public void Set_preserveWhiteSpace(bool isPreserving) 
		{
			this._i.preserveWhiteSpace = isPreserving;
		}

		///<summary>
		///register a readystatechange event handler
		///</summary>
		public void Set_onreadystatechange(object rhs) 
		{
			this._i.onreadystatechange = rhs;
		}

		///<summary>
		///register an ondataavailable event handler
		///</summary>
		public void Set_ondataavailable(object rhs) 
		{
			this._i.ondataavailable = rhs;
		}

		///<summary>
		///register an ontransformnode event handler
		///</summary>
		public void Set_ontransformnode(object rhs) 
		{
			this._i.ontransformnode = rhs;
		}
	}
}
