namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateQuickProfile 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsCreateQuickProfile _i;
		internal AeccSettingsCreateQuickProfile(object AeccSettingsCreateQuickProfile_object) 
		{
			this._i = AeccSettingsCreateQuickProfile_object as Autodesk.AECC.Interop.Land.IAeccSettingsCreateQuickProfile;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic SelectAllSurface => this._i.SelectAllSurface;

		///<summary>
		///
		///</summary>
		public dynamic Draw3DEntity => this._i.Draw3DEntity;
	}
}
