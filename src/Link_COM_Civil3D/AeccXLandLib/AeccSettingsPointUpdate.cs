namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsPointUpdate 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsPointUpdate _i;
		internal AeccSettingsPointUpdate(object AeccSettingsPointUpdate_object) 
		{
			this._i = AeccSettingsPointUpdate_object as Autodesk.AECC.Interop.Land.IAeccSettingsPointUpdate;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AllowCheckedInModification => this._i.AllowCheckedInModification;
	}
}
