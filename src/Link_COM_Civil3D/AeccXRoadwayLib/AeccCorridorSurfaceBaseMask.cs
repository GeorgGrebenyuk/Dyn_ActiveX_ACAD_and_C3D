namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccCorridorSurfaceBaseMask 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccCorridorSurfaceBaseMask _i;
		internal AeccCorridorSurfaceBaseMask(object AeccCorridorSurfaceBaseMask_object) 
		{
			this._i = AeccCorridorSurfaceBaseMask_object as Autodesk.AECC.Interop.Roadway.IAeccCorridorSurfaceBaseMask;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Corridor => this._i.Corridor;

		///<summary>
		///
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public string Description => this._i.Description;

		///<summary>
		///
		///</summary>
		public void GetPolygonPoints() 
		{
			this._i.GetPolygonPoints();
		}

		///<summary>
		///
		///</summary>
		public dynamic FeatureLineComponents => this._i.FeatureLineComponents;
	}
}
