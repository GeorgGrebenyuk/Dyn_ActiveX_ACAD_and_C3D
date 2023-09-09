namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateAlignmentEntities 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsCreateAlignmentEntities _i;
		internal AeccSettingsCreateAlignmentEntities(object AeccSettingsCreateAlignmentEntities_object) 
		{
			this._i = AeccSettingsCreateAlignmentEntities_object as Autodesk.AECC.Interop.Land.IAeccSettingsCreateAlignmentEntities;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic ConvertFromPolylineSettings => this._i.ConvertFromPolylineSettings;
	}
}
