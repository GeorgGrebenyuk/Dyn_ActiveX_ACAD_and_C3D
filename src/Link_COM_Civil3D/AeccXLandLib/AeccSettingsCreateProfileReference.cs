namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateProfileReference 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsCreateProfileReference _i;
		internal AeccSettingsCreateProfileReference(object AeccSettingsCreateProfileReference_object) 
		{
			this._i = AeccSettingsCreateProfileReference_object as Autodesk.AECC.Interop.Land.IAeccSettingsCreateProfileReference;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
