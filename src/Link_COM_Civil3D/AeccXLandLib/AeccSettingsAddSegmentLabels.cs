namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAddSegmentLabels 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsAddSegmentLabels _i;
		internal AeccSettingsAddSegmentLabels(object AeccSettingsAddSegmentLabels_object) 
		{
			this._i = AeccSettingsAddSegmentLabels_object as Autodesk.AECC.Interop.Land.IAeccSettingsAddSegmentLabels;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
