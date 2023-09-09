namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAddParcelCurveTable 
	{
		public AeccXLandLib.IAeccSettingsAddParcelCurveTable _i;
		internal AeccSettingsAddParcelCurveTable(object AeccSettingsAddParcelCurveTable_object) 
		{
			this._i = AeccSettingsAddParcelCurveTable_object as AeccXLandLib.IAeccSettingsAddParcelCurveTable;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic TableCreationSettings => this._i.TableCreationSettings;
	}
}
