namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCorridorExtractSurfaces 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccSettingsCorridorExtractSurfaces _i;
		internal AeccSettingsCorridorExtractSurfaces(object AeccSettingsCorridorExtractSurfaces_object) 
		{
			this._i = AeccSettingsCorridorExtractSurfaces_object as Autodesk.AECC.Interop.Roadway.IAeccSettingsCorridorExtractSurfaces;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
