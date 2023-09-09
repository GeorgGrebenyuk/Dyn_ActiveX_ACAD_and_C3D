namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccCorridorSurfaceBoundary 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccCorridorSurfaceBoundary _i;
		internal AeccCorridorSurfaceBoundary(object AeccCorridorSurfaceBoundary_object) 
		{
			this._i = AeccCorridorSurfaceBoundary_object as Autodesk.AECC.Interop.Roadway.IAeccCorridorSurfaceBoundary;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Type => this._i.Type;
	}
}
