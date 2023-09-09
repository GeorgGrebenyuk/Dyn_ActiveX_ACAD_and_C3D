namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAddParcelTable 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsAddParcelTable _i;
		internal AeccSettingsAddParcelTable(object AeccSettingsAddParcelTable_object) 
		{
			this._i = AeccSettingsAddParcelTable_object as Autodesk.AECC.Interop.Land.IAeccSettingsAddParcelTable;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic TableCreationSettings => this._i.TableCreationSettings;
	}
}
