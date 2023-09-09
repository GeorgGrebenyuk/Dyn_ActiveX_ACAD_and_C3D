namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumProfileViewDispNetworkParts 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumProfileViewDispNetworkParts _i;
		internal AeccPropertyEnumProfileViewDispNetworkParts(object AeccPropertyEnumProfileViewDispNetworkParts_object) 
		{
			this._i = AeccPropertyEnumProfileViewDispNetworkParts_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumProfileViewDispNetworkParts;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccProfileViewDisplayNetworkParts pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
