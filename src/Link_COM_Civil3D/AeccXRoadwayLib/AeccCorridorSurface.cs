namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccCorridorSurface 
	{
		public AeccXRoadwayLib.IAeccCorridorSurface _i;
		internal AeccCorridorSurface(object AeccCorridorSurface_object) 
		{
			this._i = AeccCorridorSurface_object as AeccXRoadwayLib.IAeccCorridorSurface;
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
		public bool IsBuild => this._i.IsBuild;

		///<summary>
		///
		///</summary>
		public bool IsDraw => this._i.IsDraw;

		///<summary>
		///
		///</summary>
		public dynamic SurfaceStyle => this._i.SurfaceStyle;

		///<summary>
		///
		///</summary>
		public dynamic SectionStyle => this._i.SectionStyle;

		///<summary>
		///
		///</summary>
		public dynamic Boundaries => this._i.Boundaries;

		///<summary>
		///
		///</summary>
		public dynamic Masks => this._i.Masks;

		///<summary>
		///
		///</summary>
		public string PointCodes => this._i.PointCodes;

		///<summary>
		///
		///</summary>
		public string LinkCodes => this._i.LinkCodes;

		///<summary>
		///
		///</summary>
		public string FeatureLineCodes => this._i.FeatureLineCodes;

		///<summary>
		///
		///</summary>
		public bool LinkCodeIsBreak(string Name) 
		{
			return this._i.LinkCodeIsBreak(Name);
		}

		///<summary>
		///
		///</summary>
		public double FindElevationAtXY(double dX,double dY) 
		{
			return this._i.FindElevationAtXY(dX,dY);
		}

		///<summary>
		///
		///</summary>
		public object GetSampleElevations(double dStartX,double dStartY,double dEndX,double dEndY) 
		{
			return this._i.GetSampleElevations(dStartX,dStartY,dEndX,dEndY);
		}
	}
}
