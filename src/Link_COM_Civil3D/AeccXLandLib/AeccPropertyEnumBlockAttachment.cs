namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumBlockAttachment 
	{
		public AeccXLandLib.IAeccPropertyEnumBlockAttachment _i;
		internal AeccPropertyEnumBlockAttachment(object AeccPropertyEnumBlockAttachment_object) 
		{
			this._i = AeccPropertyEnumBlockAttachment_object as AeccXLandLib.IAeccPropertyEnumBlockAttachment;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccBlockAttachmentType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
