namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAddAlignmentSegmentTable 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsAddAlignmentSegmentTable _i;
		internal AeccSettingsAddAlignmentSegmentTable(object AeccSettingsAddAlignmentSegmentTable_object) 
		{
			this._i = AeccSettingsAddAlignmentSegmentTable_object as Autodesk.AECC.Interop.Land.IAeccSettingsAddAlignmentSegmentTable;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic TableCreationSettings => this._i.TableCreationSettings;
	}
}
