namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsPointUpdate 
	{
		public AeccXLandLib.IAeccSettingsPointUpdate _i;
		internal AeccSettingsPointUpdate(object AeccSettingsPointUpdate_object) 
		{
			this._i = AeccSettingsPointUpdate_object as AeccXLandLib.IAeccSettingsPointUpdate;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AllowCheckedInModification => this._i.AllowCheckedInModification;
	}
}
