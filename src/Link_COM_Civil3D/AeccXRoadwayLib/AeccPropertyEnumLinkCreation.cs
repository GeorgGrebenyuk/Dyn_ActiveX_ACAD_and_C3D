namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumLinkCreation 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccPropertyEnumLinkCreation _i;
		internal AeccPropertyEnumLinkCreation(object AeccPropertyEnumLinkCreation_object) 
		{
			this._i = AeccPropertyEnumLinkCreation_object as Autodesk.AECC.Interop.Roadway.IAeccPropertyEnumLinkCreation;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Roadway.AeccLinkCreationType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
