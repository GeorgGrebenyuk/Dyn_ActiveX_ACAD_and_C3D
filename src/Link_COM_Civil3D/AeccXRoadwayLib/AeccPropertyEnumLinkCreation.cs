namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumLinkCreation 
	{
		public AeccXRoadwayLib.IAeccPropertyEnumLinkCreation _i;
		internal AeccPropertyEnumLinkCreation(object AeccPropertyEnumLinkCreation_object) 
		{
			this._i = AeccPropertyEnumLinkCreation_object as AeccXRoadwayLib.IAeccPropertyEnumLinkCreation;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXRoadwayLib.AeccLinkCreationType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
