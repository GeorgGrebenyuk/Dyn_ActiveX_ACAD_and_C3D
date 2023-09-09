namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateAlignmentEntities 
	{
		public AeccXLandLib.IAeccSettingsCreateAlignmentEntities _i;
		internal AeccSettingsCreateAlignmentEntities(object AeccSettingsCreateAlignmentEntities_object) 
		{
			this._i = AeccSettingsCreateAlignmentEntities_object as AeccXLandLib.IAeccSettingsCreateAlignmentEntities;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic ConvertFromPolylineSettings => this._i.ConvertFromPolylineSettings;
	}
}
