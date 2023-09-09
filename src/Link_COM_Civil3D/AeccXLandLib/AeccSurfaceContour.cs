namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceContour 
	{
		public AeccXLandLib.IAeccSurfaceContour _i;
		internal AeccSurfaceContour(object AeccSurfaceContour_object) 
		{
			this._i = AeccSurfaceContour_object as AeccXLandLib.IAeccSurfaceContour;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string Description => this._i.Description;

		///<summary>
		///
		///</summary>
		public object ContourEntities => this._i.ContourEntities;

		///<summary>
		///
		///</summary>
		public double WeedingDistance => this._i.WeedingDistance;

		///<summary>
		///
		///</summary>
		public double WeedingAngle => this._i.WeedingAngle;

		///<summary>
		///
		///</summary>
		public double Distance => this._i.Distance;

		///<summary>
		///
		///</summary>
		public double MidOrdinateDistance => this._i.MidOrdinateDistance;
	}
}
