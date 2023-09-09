namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccRoadwaySettingsDrawing 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccRoadwaySettingsDrawing _i;
		internal AeccRoadwaySettingsDrawing(object AeccRoadwaySettingsDrawing_object) 
		{
			this._i = AeccRoadwaySettingsDrawing_object as Autodesk.AECC.Interop.Roadway.IAeccRoadwaySettingsDrawing;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
