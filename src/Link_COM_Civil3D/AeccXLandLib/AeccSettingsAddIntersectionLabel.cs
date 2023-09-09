namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAddIntersectionLabel 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsAddIntersectionLabel _i;
		internal AeccSettingsAddIntersectionLabel(object AeccSettingsAddIntersectionLabel_object) 
		{
			this._i = AeccSettingsAddIntersectionLabel_object as Autodesk.AECC.Interop.Land.IAeccSettingsAddIntersectionLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
