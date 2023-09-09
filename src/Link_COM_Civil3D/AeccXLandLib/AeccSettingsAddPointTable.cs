namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAddPointTable 
	{
		public AeccXLandLib.IAeccSettingsAddPointTable _i;
		internal AeccSettingsAddPointTable(object AeccSettingsAddPointTable_object) 
		{
			this._i = AeccSettingsAddPointTable_object as AeccXLandLib.IAeccSettingsAddPointTable;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic TableCreationSettings => this._i.TableCreationSettings;
	}
}
