namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAddMaterialVolumeTable 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccSettingsAddMaterialVolumeTable _i;
		internal AeccSettingsAddMaterialVolumeTable(object AeccSettingsAddMaterialVolumeTable_object) 
		{
			this._i = AeccSettingsAddMaterialVolumeTable_object as Autodesk.AECC.Interop.Roadway.IAeccSettingsAddMaterialVolumeTable;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic TableCreation => this._i.TableCreation;
	}
}
