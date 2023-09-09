namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateSectionView 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsCreateSectionView _i;
		internal AeccSettingsCreateSectionView(object AeccSettingsCreateSectionView_object) 
		{
			this._i = AeccSettingsCreateSectionView_object as Autodesk.AECC.Interop.Land.IAeccSettingsCreateSectionView;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
