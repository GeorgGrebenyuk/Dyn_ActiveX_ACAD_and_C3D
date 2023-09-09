namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class XMLDOMNodeList 
	{
		public AeccXLandLib.IXMLDOMNodeList _i;
		internal XMLDOMNodeList(object XMLDOMNodeList_object) 
		{
			this._i = XMLDOMNodeList_object as AeccXLandLib.IXMLDOMNodeList;
			if (this._i == null) throw new System.Exception("Invalid casting");
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
