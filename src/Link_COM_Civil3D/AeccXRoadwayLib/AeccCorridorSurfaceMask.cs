namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccCorridorSurfaceMask 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccCorridorSurfaceMask _i;
		internal AeccCorridorSurfaceMask(object AeccCorridorSurfaceMask_object) 
		{
			this._i = AeccCorridorSurfaceMask_object as Autodesk.AECC.Interop.Roadway.IAeccCorridorSurfaceMask;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
