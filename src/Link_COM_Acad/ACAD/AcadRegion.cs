namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadRegion 
	{
		public AXDBLib.IAcadRegion _i;
		internal AcadRegion(object AcadRegion_object) 
		{
			this._i = AcadRegion_object as AXDBLib.IAcadRegion;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public double Area => this._i.Area;

		///<summary>
		///
		///</summary>
		public object Centroid => this._i.Centroid;

		///<summary>
		///
		///</summary>
		public object MomentOfInertia => this._i.MomentOfInertia;

		///<summary>
		///
		///</summary>
		public object Normal => this._i.Normal;

		///<summary>
		///
		///</summary>
		public double Perimeter => this._i.Perimeter;

		///<summary>
		///
		///</summary>
		public object PrincipalDirections => this._i.PrincipalDirections;

		///<summary>
		///
		///</summary>
		public object PrincipalMoments => this._i.PrincipalMoments;

		///<summary>
		///
		///</summary>
		public double ProductOfInertia => this._i.ProductOfInertia;

		///<summary>
		///
		///</summary>
		public object RadiiOfGyration => this._i.RadiiOfGyration;

		///<summary>
		///
		///</summary>
		public void Boolean(AXDBLib.AcBoolean Operation,dynamic Object) 
		{
			this._i.Boolean(Operation,Object);
		}

		///<summary>
		///
		///</summary>
		public object Explode => this._i.Explode;
	}
}
