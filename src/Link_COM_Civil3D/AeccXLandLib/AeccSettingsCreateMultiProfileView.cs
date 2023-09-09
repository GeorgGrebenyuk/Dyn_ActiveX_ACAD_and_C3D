namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateMultiProfileView 
	{
		public AeccXLandLib.IAeccSettingsCreateMultiProfileView _i;
		internal AeccSettingsCreateMultiProfileView(object AeccSettingsCreateMultiProfileView_object) 
		{
			this._i = AeccSettingsCreateMultiProfileView_object as AeccXLandLib.IAeccSettingsCreateMultiProfileView;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic CreationSettings => this._i.CreationSettings;
	}
}
