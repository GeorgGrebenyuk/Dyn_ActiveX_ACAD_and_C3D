namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAddMaterialVolumeTable 
	{
		public AeccXRoadwayLib.IAeccSettingsAddMaterialVolumeTable _i;
		internal AeccSettingsAddMaterialVolumeTable(object AeccSettingsAddMaterialVolumeTable_object) 
		{
			this._i = AeccSettingsAddMaterialVolumeTable_object as AeccXRoadwayLib.IAeccSettingsAddMaterialVolumeTable;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic TableCreation => this._i.TableCreation;
	}
}
