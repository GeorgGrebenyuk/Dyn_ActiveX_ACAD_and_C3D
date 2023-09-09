namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAddPointTable 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsAddPointTable _i;
		internal AeccSettingsAddPointTable(object AeccSettingsAddPointTable_object) 
		{
			this._i = AeccSettingsAddPointTable_object as Autodesk.AECC.Interop.Land.IAeccSettingsAddPointTable;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic TableCreationSettings => this._i.TableCreationSettings;
	}
}
