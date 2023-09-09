namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumLeaderAttachment 
	{
		public AeccXLandLib.IAeccPropertyEnumLeaderAttachment _i;
		internal AeccPropertyEnumLeaderAttachment(object AeccPropertyEnumLeaderAttachment_object) 
		{
			this._i = AeccPropertyEnumLeaderAttachment_object as AeccXLandLib.IAeccPropertyEnumLeaderAttachment;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccLeaderAttachmentType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
