namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumTextAttachment 
	{
		public AeccXLandLib.IAeccPropertyEnumTextAttachment _i;
		internal AeccPropertyEnumTextAttachment(object AeccPropertyEnumTextAttachment_object) 
		{
			this._i = AeccPropertyEnumTextAttachment_object as AeccXLandLib.IAeccPropertyEnumTextAttachment;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccTextAttachmentType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
