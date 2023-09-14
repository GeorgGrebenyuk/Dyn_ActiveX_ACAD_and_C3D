using Autodesk.DesignScript.Geometry;
using System.Collections.Generic;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadRegion 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadRegion _i;
		internal AcadRegion(object AcadRegion_object) 
		{
			this._i = AcadRegion_object as Autodesk.AutoCAD.Interop.Common.AcadRegion;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Try cast from AcadEntity
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <exception cref="System.Exception"></exception>
        public AcadRegion(AcadEntity AcadEntity)
        {
            this._i = AcadEntity._i as Autodesk.AutoCAD.Interop.Common.AcadRegion;
            if (this._i == null) throw new System.Exception("Invalid casting");
        }

        ///<summary>
        ///
        ///</summary>
        public double Area => this._i.Area;

		///<summary>
		///
		///</summary>
		public Point Centroid => Technical.PointByDynPoint(this._i.Centroid);

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
		public void Boolean(Autodesk.AutoCAD.Interop.Common.AcBooleanType Operation,dynamic Object) 
		{
			this._i.Boolean(Operation, Object);
		}

        ///<summary>
        /// Get new AcadEntitis as result of that object exploding
        ///</summary>
        public List<AcadEntity> Explode => Technical.GetExploded(this._i.Explode());
    }
}
