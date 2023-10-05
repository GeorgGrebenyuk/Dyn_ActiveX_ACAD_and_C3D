using Autodesk.DesignScript.Geometry;
using System.Collections.Generic;
using System.Linq;

namespace DynAXDBLib 
{

    ///<summary>
    /// A three-dimensional polyface mesh
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

        /// <summary>
        /// Creates a polyface mesh from a list of vertices
        /// </summary>
        /// <param name="AcadBlock"></param>
        /// <param name="VertexList">An array of 3D WCS coordinates used to create the polyface mesh vertices. At least four points (twelve elements) are required for constructing a polyface mesh object. The array size must be a multiple of three</param>
        /// <param name="FaceList">An array of integers representing the vertex numbers for each face. Faces are defined in groups of four vertex index values, so the size of this array must be a multiple of four</param>
        private AcadPolyfaceMesh (AcadBlock AcadBlock, List<Point> VertexList, List<int[]> FaceList)
        {
            this._i =  AcadBlock._i.AddPolyfaceMesh(VertexList.Select(p=>Technical.PointByDynPoint(p)), 
                FaceList.Select(a=>a.ToArray()).ToArray());
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
        /// Set point by it's index to that object
        ///</summary>
        public void Set_Coordinate(int Index, Point pVal)
        {
            this._i.Coordinate[Index] = Technical.PointByDynPoint(pVal);
        }

        ///<summary>
        ///Gets the number of vertices for the PolyfaceMesh
        ///</summary>
        public int NumberOfVertices => this._i.NumberOfVertices;

        ///<summary>
        ///Gets the number of faces for the PolyfaceMesh
        ///</summary>
        public int NumberOfFaces => this._i.NumberOfFaces;

		///<summary>
		///
		///</summary>
		private void Set_Faces(object rhs) 
		{
			this._i.Faces = rhs;
		}
	}
}
