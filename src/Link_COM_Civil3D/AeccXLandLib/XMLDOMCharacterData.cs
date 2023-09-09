namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class XMLDOMCharacterData 
	{
		public Autodesk.AECC.Interop.Land.IXMLDOMCharacterData _i;
		internal XMLDOMCharacterData(object XMLDOMCharacterData_object) 
		{
			this._i = XMLDOMCharacterData_object as Autodesk.AECC.Interop.Land.IXMLDOMCharacterData;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///value of the node
		///</summary>
		public string data => this._i.data;

		///<summary>
		///value of the node
		///</summary>
		public void Set_data(string data) 
		{
			this._i.data = data;
		}

		///<summary>
		///number of characters in value
		///</summary>
		public dynamic Length => this._i.Length;

		///<summary>
		///retrieve substring of value
		///</summary>
		public string substringData(dynamic Offset,dynamic Count) 
		{
			return this._i.substringData(Offset,Count);
		}

		///<summary>
		///append string to value
		///</summary>
		public void appendData(string data) 
		{
			this._i.appendData(data);
		}

		///<summary>
		///insert string into value
		///</summary>
		public void insertData(dynamic Offset,string data) 
		{
			this._i.insertData(Offset,data);
		}

		///<summary>
		///delete string within the value
		///</summary>
		public void deleteData(dynamic Offset,dynamic Count) 
		{
			this._i.deleteData(Offset,Count);
		}

		///<summary>
		///replace string within the value
		///</summary>
		public void replaceData(dynamic Offset,dynamic Count,string data) 
		{
			this._i.replaceData(Offset,Count,data);
		}
	}
}
