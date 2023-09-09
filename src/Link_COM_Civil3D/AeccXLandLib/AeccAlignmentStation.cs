namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentStation 
	{
		public AeccXLandLib.IAeccAlignmentStation _i;
		internal AeccAlignmentStation(object AeccAlignmentStation_object) 
		{
			this._i = AeccAlignmentStation_object as AeccXLandLib.IAeccAlignmentStation;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Type => this._i.Type;

		///<summary>
		///
		///</summary>
		public double Easting => this._i.Easting;

		///<summary>
		///
		///</summary>
		public double Northing => this._i.Northing;

		///<summary>
		///
		///</summary>
		public dynamic GeometryPointType => this._i.GeometryPointType;

		///<summary>
		///
		///</summary>
		public double Station => this._i.Station;
	}
}
