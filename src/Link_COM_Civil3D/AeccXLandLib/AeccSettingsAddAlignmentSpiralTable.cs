namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAddAlignmentSpiralTable 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsAddAlignmentSpiralTable _i;
		internal AeccSettingsAddAlignmentSpiralTable(object AeccSettingsAddAlignmentSpiralTable_object) 
		{
			this._i = AeccSettingsAddAlignmentSpiralTable_object as Autodesk.AECC.Interop.Land.IAeccSettingsAddAlignmentSpiralTable;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic TableCreationSettings => this._i.TableCreationSettings;
	}
}
