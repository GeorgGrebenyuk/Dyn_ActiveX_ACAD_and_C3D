namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreatePointGroup 
	{
		public AeccXLandLib.IAeccSettingsCreatePointGroup _i;
		internal AeccSettingsCreatePointGroup(object AeccSettingsCreatePointGroup_object) 
		{
			this._i = AeccSettingsCreatePointGroup_object as AeccXLandLib.IAeccSettingsCreatePointGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
