namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateSite 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsCreateSite _i;
		internal AeccSettingsCreateSite(object AeccSettingsCreateSite_object) 
		{
			this._i = AeccSettingsCreateSite_object as Autodesk.AECC.Interop.Land.IAeccSettingsCreateSite;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic ParcelsSettings => this._i.ParcelsSettings;

		///<summary>
		///
		///</summary>
		public dynamic AlignmentSettings => this._i.AlignmentSettings;
	}
}
