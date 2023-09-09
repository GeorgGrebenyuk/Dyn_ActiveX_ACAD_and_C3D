namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class XMLDOMProcessingInstruction 
	{
		public Autodesk.AECC.Interop.Land.IXMLDOMProcessingInstruction _i;
		internal XMLDOMProcessingInstruction(object XMLDOMProcessingInstruction_object) 
		{
			this._i = XMLDOMProcessingInstruction_object as Autodesk.AECC.Interop.Land.IXMLDOMProcessingInstruction;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///the target
		///</summary>
		public string target => this._i.target;

		///<summary>
		///the data
		///</summary>
		public string data => this._i.data;

		///<summary>
		///the data
		///</summary>
		public void Set_data(string Value) 
		{
			this._i.data = Value;
		}
	}
}
