using Autodesk.DesignScript.Geometry;
using System.Reflection;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadSolid 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadSolid _i;
		internal AcadSolid(object AcadSolid_object) 
		{
			this._i = AcadSolid_object as Autodesk.AutoCAD.Interop.Common.AcadSolid;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Try cast from AcadEntity
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <exception cref="System.Exception"></exception>
        public AcadSolid(AcadEntity AcadEntity)
        {
            this._i = AcadEntity._i as Autodesk.AutoCAD.Interop.Common.AcadSolid;
            if (this._i == null) throw new System.Exception("Invalid casting");
        }

        ///<summary>
        ///Create new solid
        ///</summary>
        public AcadSolid(AcadBlock AcadBlock, Point Point1, Point Point2, Point Point3, Point Point4)
        {
            this._i = AcadBlock._i.AddSolid(
                Technical.PointByDynPoint(Point1),
                Technical.PointByDynPoint(Point2),
                Technical.PointByDynPoint(Point3),
                Technical.PointByDynPoint(Point4));
        }


        ///<summary>
        ///
        ///</summary>
        public object Coordinates => this._i.Coordinates;

		///<summary>
		///
		///</summary>
		public void Set_Coordinates(object corners) 
		{
			this._i.Coordinates = corners;
		}

		///<summary>
		///
		///</summary>
		public object Normal => this._i.Normal;

		///<summary>
		///
		///</summary>
		public void Set_Normal(object Normal) 
		{
			this._i.Normal = Normal;
		}

		///<summary>
		///
		///</summary>
		public double Thickness => this._i.Thickness;

		///<summary>
		///
		///</summary>
		public void Set_Thickness(double Thickness) 
		{
			this._i.Thickness = Thickness;
		}

		///<summary>
		///
		///</summary>
		public object Coordinate(int Index) 
		{
			return this._i.Coordinate[Index];
		}

		///<summary>
		///
		///</summary>
		public void Set_Coordinate(int Index,object pVal) 
		{
            this._i.Coordinate[Index] = pVal;
		}
	}
}
