namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class XMLDOMElement 
	{
		public Autodesk.AECC.Interop.Land.IXMLDOMElement _i;
		internal XMLDOMElement(object XMLDOMElement_object) 
		{
			this._i = XMLDOMElement_object as Autodesk.AECC.Interop.Land.IXMLDOMElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///get the tagName of the element
		///</summary>
		public string tagName => this._i.tagName;

		///<summary>
		///look up the string value of an attribute by name
		///</summary>
		public object getAttribute(string Name) 
		{
			return this._i.getAttribute(Name);
		}

		///<summary>
		///set the string value of an attribute by name
		///</summary>
		public void setAttribute(string Name,object Value) 
		{
			this._i.setAttribute(Name,Value);
		}

		///<summary>
		///remove an attribute by name
		///</summary>
		public void removeAttribute(string Name) 
		{
			this._i.removeAttribute(Name);
		}

		///<summary>
		///look up the attribute node by name
		///</summary>
		public dynamic getAttributeNode(string Name) 
		{
			return this._i.getAttributeNode(Name);
		}

		///<summary>
		///set the specified attribute on the element
		///</summary>
		public dynamic setAttributeNode(dynamic DOMAttribute) 
		{
			return this._i.setAttributeNode(DOMAttribute);
		}

		///<summary>
		///remove the specified attribute
		///</summary>
		public dynamic removeAttributeNode(dynamic DOMAttribute) 
		{
			return this._i.removeAttributeNode(DOMAttribute);
		}

		///<summary>
		///build a list of elements by name
		///</summary>
		public dynamic getElementsByTagName(string tagName) 
		{
			return this._i.getElementsByTagName(tagName);
		}

		///<summary>
		///collapse all adjacent text nodes in sub-tree
		///</summary>
		public void normalize() 
		{
			this._i.normalize();
		}
	}
}
