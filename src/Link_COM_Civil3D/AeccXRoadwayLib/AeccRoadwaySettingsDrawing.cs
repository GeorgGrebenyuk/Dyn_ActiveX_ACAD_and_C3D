namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccRoadwaySettingsDrawing 
	{
		public AeccXRoadwayLib.IAeccRoadwaySettingsDrawing _i;
		internal AeccRoadwaySettingsDrawing(object AeccRoadwaySettingsDrawing_object) 
		{
			this._i = AeccRoadwaySettingsDrawing_object as AeccXRoadwayLib.IAeccRoadwaySettingsDrawing;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
