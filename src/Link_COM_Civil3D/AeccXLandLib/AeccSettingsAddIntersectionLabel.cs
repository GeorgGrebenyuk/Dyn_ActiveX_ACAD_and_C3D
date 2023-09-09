namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAddIntersectionLabel 
	{
		public AeccXLandLib.IAeccSettingsAddIntersectionLabel _i;
		internal AeccSettingsAddIntersectionLabel(object AeccSettingsAddIntersectionLabel_object) 
		{
			this._i = AeccSettingsAddIntersectionLabel_object as AeccXLandLib.IAeccSettingsAddIntersectionLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
