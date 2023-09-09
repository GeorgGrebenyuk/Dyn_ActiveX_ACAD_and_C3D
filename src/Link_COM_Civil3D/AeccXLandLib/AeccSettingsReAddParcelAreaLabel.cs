namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsReAddParcelAreaLabel 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsReAddParcelAreaLabel _i;
		internal AeccSettingsReAddParcelAreaLabel(object AeccSettingsReAddParcelAreaLabel_object) 
		{
			this._i = AeccSettingsReAddParcelAreaLabel_object as Autodesk.AECC.Interop.Land.IAeccSettingsReAddParcelAreaLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
