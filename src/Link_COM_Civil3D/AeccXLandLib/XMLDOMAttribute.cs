namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class XMLDOMAttribute 
	{
		public Autodesk.AECC.Interop.Land.IXMLDOMAttribute _i;
		internal XMLDOMAttribute(object XMLDOMAttribute_object) 
		{
			this._i = XMLDOMAttribute_object as Autodesk.AECC.Interop.Land.IXMLDOMAttribute;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///get name of the attribute
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///string value of the attribute
		///</summary>
		public object Value => this._i.Value;

		///<summary>
		///string value of the attribute
		///</summary>
		public void Set_Value(object attributeValue) 
		{
			this._i.Value = attributeValue;
		}
	}
}
