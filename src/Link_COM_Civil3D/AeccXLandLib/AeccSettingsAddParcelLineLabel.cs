namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAddParcelLineLabel 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsAddParcelLineLabel _i;
		internal AeccSettingsAddParcelLineLabel(object AeccSettingsAddParcelLineLabel_object) 
		{
			this._i = AeccSettingsAddParcelLineLabel_object as Autodesk.AECC.Interop.Land.IAeccSettingsAddParcelLineLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
