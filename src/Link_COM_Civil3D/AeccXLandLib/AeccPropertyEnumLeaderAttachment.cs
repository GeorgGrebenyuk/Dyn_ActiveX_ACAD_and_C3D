namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumLeaderAttachment 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumLeaderAttachment _i;
		internal AeccPropertyEnumLeaderAttachment(object AeccPropertyEnumLeaderAttachment_object) 
		{
			this._i = AeccPropertyEnumLeaderAttachment_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumLeaderAttachment;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccLeaderAttachmentType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
