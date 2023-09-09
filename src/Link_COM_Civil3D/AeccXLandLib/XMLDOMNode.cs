namespace DynAeccXLandLib 
{

	///<summary>
	///Core DOM node interface
	///</summary>
	public class XMLDOMNode 
	{
		public Autodesk.AECC.Interop.Land.IXMLDOMNode _i;
		internal XMLDOMNode(object XMLDOMNode_object) 
		{
			this._i = XMLDOMNode_object as Autodesk.AECC.Interop.Land.IXMLDOMNode;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///name of the node
		///</summary>
		public string nodeName => this._i.nodeName;

		///<summary>
		///value stored in the node
		///</summary>
		public object nodeValue => this._i.nodeValue;

		///<summary>
		///value stored in the node
		///</summary>
		public void Set_nodeValue(object Value) 
		{
			this._i.nodeValue = Value;
		}

		///<summary>
		///the node's type
		///</summary>
		public dynamic nodeType => this._i.nodeType;

		///<summary>
		///parent of the node
		///</summary>
		public dynamic parentNode => this._i.parentNode;

		///<summary>
		///the collection of the node's children
		///</summary>
		public dynamic childNodes => this._i.childNodes;

		///<summary>
		///first child of the node
		///</summary>
		public dynamic firstChild => this._i.firstChild;

		///<summary>
		///last child of the node
		///</summary>
		public dynamic lastChild => this._i.lastChild;

		///<summary>
		///left sibling of the node
		///</summary>
		public dynamic previousSibling => this._i.previousSibling;

		///<summary>
		///right sibling of the node
		///</summary>
		public dynamic nextSibling => this._i.nextSibling;

		///<summary>
		///the collection of the node's attributes
		///</summary>
		public dynamic attributes => this._i.attributes;

		///<summary>
		///insert a child node
		///</summary>
		public dynamic insertBefore(dynamic newChild,object refChild) 
		{
			return this._i.insertBefore(newChild,refChild);
		}

		///<summary>
		///replace a child node
		///</summary>
		public dynamic replaceChild(dynamic newChild,dynamic oldChild) 
		{
			return this._i.replaceChild(newChild,oldChild);
		}

		///<summary>
		///remove a child node
		///</summary>
		public dynamic removeChild(dynamic childNode) 
		{
			return this._i.removeChild(childNode);
		}

		///<summary>
		///append a child node
		///</summary>
		public dynamic appendChild(dynamic newChild) 
		{
			return this._i.appendChild(newChild);
		}

		///<summary>
		///
		///</summary>
		public bool hasChildNodes => this._i.hasChildNodes;

		///<summary>
		///document that contains the node
		///</summary>
		public dynamic ownerDocument => this._i.ownerDocument;

		///<summary>
		///
		///</summary>
		public dynamic cloneNode(bool deep) 
		{
			return this._i.cloneNode(deep);
		}

		///<summary>
		///the type of node in string form
		///</summary>
		public string nodeTypeString => this._i.nodeTypeString;

		///<summary>
		///text content of the node and subtree
		///</summary>
		public string Text => this._i.Text;

		///<summary>
		///text content of the node and subtree
		///</summary>
		public void Set_Text(string Text) 
		{
			this._i.Text = Text;
		}

		///<summary>
		///indicates whether node is a default value
		///</summary>
		public bool specified => this._i.specified;

		///<summary>
		///pointer to the definition of the node in the DTD or schema
		///</summary>
		public dynamic definition => this._i.definition;

		///<summary>
		///get the strongly typed value of the node
		///</summary>
		public object nodeTypedValue => this._i.nodeTypedValue;

		///<summary>
		///get the strongly typed value of the node
		///</summary>
		public void Set_nodeTypedValue(object typedValue) 
		{
			this._i.nodeTypedValue = typedValue;
		}

		///<summary>
		///the data type of the node
		///</summary>
		public object DataType => this._i.DataType;

		///<summary>
		///the data type of the node
		///</summary>
		public void Set_DataType(string dataTypeName) 
		{
			this._i.DataType = dataTypeName;
		}

		///<summary>
		///return the XML source for the node and each of its descendants
		///</summary>
		public string xml => this._i.xml;

		///<summary>
		///apply the stylesheet to the subtree
		///</summary>
		public string transformNode(dynamic stylesheet) 
		{
			return this._i.transformNode(stylesheet);
		}

		///<summary>
		///execute query on the subtree
		///</summary>
		public dynamic selectNodes(string queryString) 
		{
			return this._i.selectNodes(queryString);
		}

		///<summary>
		///execute query on the subtree
		///</summary>
		public dynamic selectSingleNode(string queryString) 
		{
			return this._i.selectSingleNode(queryString);
		}

		///<summary>
		///has sub-tree been completely parsed
		///</summary>
		public bool parsed => this._i.parsed;

		///<summary>
		///the URI for the namespace applying to the node
		///</summary>
		public string namespaceURI => this._i.namespaceURI;

		///<summary>
		///the prefix for the namespace applying to the node
		///</summary>
		public string prefix => this._i.prefix;

		///<summary>
		///nodename with the prefix stripped off)
		///</summary>
		public string baseName => this._i.baseName;

		///<summary>
		///apply the stylesheet to the subtree, returning the result through a document or a stream
		///</summary>
		public void transformNodeToObject(dynamic stylesheet,object outputObject) 
		{
			this._i.transformNodeToObject(stylesheet,outputObject);
		}
	}
}
