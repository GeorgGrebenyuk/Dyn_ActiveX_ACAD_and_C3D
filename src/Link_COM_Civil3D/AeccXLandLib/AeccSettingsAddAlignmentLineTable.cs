namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAddAlignmentLineTable 
	{
		public AeccXLandLib.IAeccSettingsAddAlignmentLineTable _i;
		internal AeccSettingsAddAlignmentLineTable(object AeccSettingsAddAlignmentLineTable_object) 
		{
			this._i = AeccSettingsAddAlignmentLineTable_object as AeccXLandLib.IAeccSettingsAddAlignmentLineTable;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic TableCreationSettings => this._i.TableCreationSettings;
	}
}
