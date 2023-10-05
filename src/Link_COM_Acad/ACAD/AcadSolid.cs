using Autodesk.DesignScript.Geometry;
using System.Collections.Generic;
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
        /// Get all cordinates in that object as array of Points
        ///</summary>
        public List<Point> Coordinates => Technical.PointsByArrayOfDoubleArray(this._i.Coordinates, false);

        ///<summary>
        /// Set coordinates to that objects from Dynamo's points array
        ///</summary>
        public void Set_Coordinates(List<Point> Coordinates)
        {
            this._i.Coordinates = Technical.PointsByDynPoints(Coordinates, false);
        }

        ///<summary>
        /// Get the Normal vector from that object
        ///</summary>
        public Vector Normal => Technical.VectorByDoubleArray(this._i.Normal);

        ///<summary>
        /// Set Normal to that object by Dynamo vector
        ///</summary>
        public void Set_Normal(Vector Normal)
        {
            this._i.Normal = Technical.VectorByDynVector(Normal);
        }

        ///<summary>
        ///Specifies the distance a 2D AutoCAD object is extruded above or below its elevation
        ///</summary>
        public double Thickness => this._i.Thickness;

        ///<summary>
        ///Specifies the distance a 2D AutoCAD object is extruded above or below its elevation
        ///</summary>
        public void Set_Thickness(double Thickness)
        {
            this._i.Thickness = Thickness;
        }
        ///<summary>
        /// Set point by it's index to that object
        ///</summary>
        public void Set_Coordinate(int Index, Point pVal)
        {
            this._i.Coordinate[Index] = Technical.PointByDynPoint(pVal);
        }
    }
}
