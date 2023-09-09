namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAddParcelSegmentTable 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsAddParcelSegmentTable _i;
		internal AeccSettingsAddParcelSegmentTable(object AeccSettingsAddParcelSegmentTable_object) 
		{
			this._i = AeccSettingsAddParcelSegmentTable_object as Autodesk.AECC.Interop.Land.IAeccSettingsAddParcelSegmentTable;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic TableCreationSettings => this._i.TableCreationSettings;
	}
}
