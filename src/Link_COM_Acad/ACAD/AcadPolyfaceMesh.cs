using Autodesk.DesignScript.Geometry;
using System.Collections.Generic;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadPolyfaceMesh 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadPolyfaceMesh _i;
		internal AcadPolyfaceMesh(object AcadPolyfaceMesh_object) 
		{
			this._i = AcadPolyfaceMesh_object as Autodesk.AutoCAD.Interop.Common.AcadPolyfaceMesh;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Try cast from AcadEntity
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <exception cref="System.Exception"></exception>
        public AcadPolyfaceMesh(AcadEntity AcadEntity)
        {
            this._i = AcadEntity._i as Autodesk.AutoCAD.Interop.Common.AcadPolyfaceMesh;
            if (this._i == null) throw new System.Exception("Invalid casting");
        }
        ///<summary>
        ///
        ///</summary>
        private AcadPolyfaceMesh (AcadBlock AcadBlock, object VertexList, object FaceList)
        {
            this._i =  AcadBlock._i.AddPolyfaceMesh(VertexList, FaceList);
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
        /// Get point by it's index from that object
        ///</summary>
        public Point Coordinate(int Index)
        {
            return Technical.PointByDynPoint(this._i.Coordinate[Index]);
        }

        ///<summary>
        ///
        ///</summary>
        public void Set_Coordinate(int Index,object pVal) 
		{
            this._i.Coordinate[Index] = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic NumberOfVertices => this._i.NumberOfVertices;

		///<summary>
		///
		///</summary>
		public dynamic NumberOfFaces => this._i.NumberOfFaces;

		///<summary>
		///
		///</summary>
		public void Set_Faces(object rhs) 
		{
			this._i.Faces = rhs;
		}
	}
}
