namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadExternalReference 
	{
		public AXDBLib.IAcadExternalReference _i;
		internal AcadExternalReference(object AcadExternalReference_object) 
		{
			this._i = AcadExternalReference_object as AXDBLib.IAcadExternalReference;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string Path => this._i.Path;

		///<summary>
		///
		///</summary>
		public void Set_Path(string bstrName) 
		{
			this._i.Path = bstrName;
		}

		///<summary>
		///
		///</summary>
		public bool LayerPropertyOverrides => this._i.LayerPropertyOverrides;
	}
}
