namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateGradingGroup 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsCreateGradingGroup _i;
		internal AeccSettingsCreateGradingGroup(object AeccSettingsCreateGradingGroup_object) 
		{
			this._i = AeccSettingsCreateGradingGroup_object as Autodesk.AECC.Interop.Land.IAeccSettingsCreateGradingGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic CreationOptions => this._i.CreationOptions;
	}
}
