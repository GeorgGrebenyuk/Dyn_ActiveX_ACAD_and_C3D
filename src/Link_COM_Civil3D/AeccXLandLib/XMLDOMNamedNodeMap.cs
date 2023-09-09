namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class XMLDOMNamedNodeMap 
	{
		public AeccXLandLib.IXMLDOMNamedNodeMap _i;
		internal XMLDOMNamedNodeMap(object XMLDOMNamedNodeMap_object) 
		{
			this._i = XMLDOMNamedNodeMap_object as AeccXLandLib.IXMLDOMNamedNodeMap;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///lookup item by name
		///</summary>
		public dynamic getNamedItem(string Name) 
		{
			return this._i.getNamedItem(Name);
		}

		///<summary>
		///set item by name
		///</summary>
		public dynamic setNamedItem(dynamic newItem) 
		{
			return this._i.setNamedItem(newItem);
		}

		///<summary>
		///remove item by name
		///</summary>
		public dynamic removeNamedItem(string Name) 
		{
			return this._i.removeNamedItem(Name);
		}

		///<summary>
		///collection of nodes
		///</summary>
		public dynamic Item(dynamic Index) 
		{
			return this._i.Item(Index);
		}

		///<summary>
		///number of nodes in the collection
		///</summary>
		public dynamic Length => this._i.Length;

		///<summary>
		///lookup the item by name and namespace
		///</summary>
		public dynamic getQualifiedItem(string baseName,string namespaceURI) 
		{
			return this._i.getQualifiedItem(baseName,namespaceURI);
		}

		///<summary>
		///remove the item by name and namespace
		///</summary>
		public dynamic removeQualifiedItem(string baseName,string namespaceURI) 
		{
			return this._i.removeQualifiedItem(baseName,namespaceURI);
		}

		///<summary>
		///get next node from iterator
		///</summary>
		public dynamic nextNode => this._i.nextNode;

		///<summary>
		///reset the position of iterator
		///</summary>
		public void reset() 
		{
			this._i.reset();
		}
	}
}
