namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAddNoteLabel 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsAddNoteLabel _i;
		internal AeccSettingsAddNoteLabel(object AeccSettingsAddNoteLabel_object) 
		{
			this._i = AeccSettingsAddNoteLabel_object as Autodesk.AECC.Interop.Land.IAeccSettingsAddNoteLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
