namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccCorridorSurfaceMask 
	{
		public AeccXRoadwayLib.IAeccCorridorSurfaceMask _i;
		internal AeccCorridorSurfaceMask(object AeccCorridorSurfaceMask_object) 
		{
			this._i = AeccCorridorSurfaceMask_object as AeccXRoadwayLib.IAeccCorridorSurfaceMask;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
