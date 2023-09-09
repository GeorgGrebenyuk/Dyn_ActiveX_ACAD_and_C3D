namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsReverseAlignmentDirection 
	{
		public AeccXLandLib.IAeccSettingsReverseAlignmentDirection _i;
		internal AeccSettingsReverseAlignmentDirection(object AeccSettingsReverseAlignmentDirection_object) 
		{
			this._i = AeccSettingsReverseAlignmentDirection_object as AeccXLandLib.IAeccSettingsReverseAlignmentDirection;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
