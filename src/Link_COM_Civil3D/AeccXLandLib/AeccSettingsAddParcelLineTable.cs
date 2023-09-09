namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAddParcelLineTable 
	{
		public AeccXLandLib.IAeccSettingsAddParcelLineTable _i;
		internal AeccSettingsAddParcelLineTable(object AeccSettingsAddParcelLineTable_object) 
		{
			this._i = AeccSettingsAddParcelLineTable_object as AeccXLandLib.IAeccSettingsAddParcelLineTable;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic TableCreationSettings => this._i.TableCreationSettings;
	}
}
