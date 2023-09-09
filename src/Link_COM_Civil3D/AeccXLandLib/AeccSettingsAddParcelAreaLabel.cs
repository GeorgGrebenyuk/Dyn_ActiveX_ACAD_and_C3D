namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAddParcelAreaLabel 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsAddParcelAreaLabel _i;
		internal AeccSettingsAddParcelAreaLabel(object AeccSettingsAddParcelAreaLabel_object) 
		{
			this._i = AeccSettingsAddParcelAreaLabel_object as Autodesk.AECC.Interop.Land.IAeccSettingsAddParcelAreaLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
