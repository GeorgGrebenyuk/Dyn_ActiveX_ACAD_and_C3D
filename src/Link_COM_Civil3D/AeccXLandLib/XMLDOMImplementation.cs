namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class XMLDOMImplementation 
	{
		public Autodesk.AECC.Interop.Land.IXMLDOMImplementation _i;
		internal XMLDOMImplementation(object XMLDOMImplementation_object) 
		{
			this._i = XMLDOMImplementation_object as Autodesk.AECC.Interop.Land.IXMLDOMImplementation;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public bool hasFeature(string feature,string version) 
		{
			return this._i.hasFeature(feature,version);
		}
	}
}
