namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAddParcelTable 
	{
		public AeccXLandLib.IAeccSettingsAddParcelTable _i;
		internal AeccSettingsAddParcelTable(object AeccSettingsAddParcelTable_object) 
		{
			this._i = AeccSettingsAddParcelTable_object as AeccXLandLib.IAeccSettingsAddParcelTable;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic TableCreationSettings => this._i.TableCreationSettings;
	}
}
