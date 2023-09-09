namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreatePointGroup 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsCreatePointGroup _i;
		internal AeccSettingsCreatePointGroup(object AeccSettingsCreatePointGroup_object) 
		{
			this._i = AeccSettingsCreatePointGroup_object as Autodesk.AECC.Interop.Land.IAeccSettingsCreatePointGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
