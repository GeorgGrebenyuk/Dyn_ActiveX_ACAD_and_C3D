namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsImportStormSewerData 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccSettingsImportStormSewerData _i;
		internal AeccSettingsImportStormSewerData(object AeccSettingsImportStormSewerData_object) 
		{
			this._i = AeccSettingsImportStormSewerData_object as Autodesk.AECC.Interop.Pipe.IAeccSettingsImportStormSewerData;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
