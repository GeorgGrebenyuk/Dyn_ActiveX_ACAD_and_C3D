namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAddAlignmentCurveTable 
	{
		public AeccXLandLib.IAeccSettingsAddAlignmentCurveTable _i;
		internal AeccSettingsAddAlignmentCurveTable(object AeccSettingsAddAlignmentCurveTable_object) 
		{
			this._i = AeccSettingsAddAlignmentCurveTable_object as AeccXLandLib.IAeccSettingsAddAlignmentCurveTable;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic TableCreationSettings => this._i.TableCreationSettings;
	}
}
