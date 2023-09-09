namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAddSegmentLabel 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsAddSegmentLabel _i;
		internal AeccSettingsAddSegmentLabel(object AeccSettingsAddSegmentLabel_object) 
		{
			this._i = AeccSettingsAddSegmentLabel_object as Autodesk.AECC.Interop.Land.IAeccSettingsAddSegmentLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
