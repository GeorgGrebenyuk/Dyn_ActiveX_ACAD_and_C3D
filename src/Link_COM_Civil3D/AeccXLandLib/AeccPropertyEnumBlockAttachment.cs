namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumBlockAttachment 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumBlockAttachment _i;
		internal AeccPropertyEnumBlockAttachment(object AeccPropertyEnumBlockAttachment_object) 
		{
			this._i = AeccPropertyEnumBlockAttachment_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumBlockAttachment;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccBlockAttachmentType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
