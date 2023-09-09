namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAddParcelSegmentTable 
	{
		public AeccXLandLib.IAeccSettingsAddParcelSegmentTable _i;
		internal AeccSettingsAddParcelSegmentTable(object AeccSettingsAddParcelSegmentTable_object) 
		{
			this._i = AeccSettingsAddParcelSegmentTable_object as AeccXLandLib.IAeccSettingsAddParcelSegmentTable;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic TableCreationSettings => this._i.TableCreationSettings;
	}
}
