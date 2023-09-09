namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateProfileView 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsCreateProfileView _i;
		internal AeccSettingsCreateProfileView(object AeccSettingsCreateProfileView_object) 
		{
			this._i = AeccSettingsCreateProfileView_object as Autodesk.AECC.Interop.Land.IAeccSettingsCreateProfileView;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
