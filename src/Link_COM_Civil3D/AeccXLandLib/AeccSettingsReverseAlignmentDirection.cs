namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsReverseAlignmentDirection 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsReverseAlignmentDirection _i;
		internal AeccSettingsReverseAlignmentDirection(object AeccSettingsReverseAlignmentDirection_object) 
		{
			this._i = AeccSettingsReverseAlignmentDirection_object as Autodesk.AECC.Interop.Land.IAeccSettingsReverseAlignmentDirection;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
