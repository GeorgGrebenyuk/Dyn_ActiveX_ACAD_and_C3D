namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumTextAttachment 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumTextAttachment _i;
		internal AeccPropertyEnumTextAttachment(object AeccPropertyEnumTextAttachment_object) 
		{
			this._i = AeccPropertyEnumTextAttachment_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumTextAttachment;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccTextAttachmentType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
