namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParcelSegmentCurve 
	{
		public AeccXLandLib.IAeccParcelSegmentCurve _i;
		internal AeccParcelSegmentCurve(object AeccParcelSegmentCurve_object) 
		{
			this._i = AeccParcelSegmentCurve_object as AeccXLandLib.IAeccParcelSegmentCurve;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public double Bulge => this._i.Bulge;

		///<summary>
		///
		///</summary>
		public double Radius => this._i.Radius;

		///<summary>
		///
		///</summary>
		public double Tangent => this._i.Tangent;

		///<summary>
		///
		///</summary>
		public double Delta => this._i.Delta;
	}
}
