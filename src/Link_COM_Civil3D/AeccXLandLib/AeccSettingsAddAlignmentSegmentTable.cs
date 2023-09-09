namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAddAlignmentSegmentTable 
	{
		public AeccXLandLib.IAeccSettingsAddAlignmentSegmentTable _i;
		internal AeccSettingsAddAlignmentSegmentTable(object AeccSettingsAddAlignmentSegmentTable_object) 
		{
			this._i = AeccSettingsAddAlignmentSegmentTable_object as AeccXLandLib.IAeccSettingsAddAlignmentSegmentTable;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic TableCreationSettings => this._i.TableCreationSettings;
	}
}
