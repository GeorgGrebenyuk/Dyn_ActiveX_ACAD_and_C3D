using Autodesk.DesignScript.Geometry;
using System.Collections.Generic;
using System.Linq;

namespace DynAXDBLib 
{

    ///<summary>
    /// A free-form 3D mesh. A PolygonMesh object is an M x N mesh where M represents the number of vertices in a row of the mesh and N represents the number of vertices in a column of the mesh. A mesh can be open or closed in either or both the M and N directions. A mesh that is closed in a given direction is considered to be continuous from the last row or column on to the first row or column. 
    ///</summary>
    public class AcadPolygonMesh 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadPolygonMesh _i;
		internal AcadPolygonMesh(object AcadPolygonMesh_object) 
		{
			this._i = AcadPolygonMesh_object as Autodesk.AutoCAD.Interop.Common.AcadPolygonMesh;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Try cast from AcadEntity
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <exception cref="System.Exception"></exception>
        public AcadPolygonMesh(AcadEntity AcadEntity)
        {
            this._i = AcadEntity._i as Autodesk.AutoCAD.Interop.Common.AcadPolygonMesh;
            if (this._i == null) throw new System.Exception("Invalid casting");
        }

        /// <summary>
		/// Creates a free-form 3D mesh, given the number of points in the M and N directions and the coordinates of the points in the M and N directions
		/// </summary>
		/// <param name="AcadBlock"></param>
		/// <param name="M">Dimensions of the point array. The size of the mesh in both the M and N directions is limited to between 2 and 256</param>
		/// <param name="N">Dimensions of the point array. The size of the mesh in both the M and N directions is limited to between 2 and 256</param>
		/// <param name="PointsMatrix">M x N matrix of 3D WCS coordinates. Defining vertices begins with vertex (0,0). Supplying the coordinate locations for each vertex in row M must be done before specifying vertices in row M + 1</param>
        public AcadPolygonMesh(AcadBlock AcadBlock, int M, int N, List<Point> PointsMatrix)
        {
            this._i = AcadBlock._i.Add3DMesh(M, N, Technical.PointsByDynPoints(PointsMatrix, false));
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
        ///Specifies whether the PolygonMesh is closed in the M direction
        ///</summary>
        public bool MClose => this._i.MClose;

        ///<summary>
        ///Specifies whether the PolygonMesh is closed in the M direction
        ///</summary>
        public void Set_MClose(bool bClose) 
		{
			this._i.MClose = bClose;
		}

        ///<summary>
        ///Specifies whether the PolygonMesh is closed in the N direction
        ///</summary>
        public bool NClose => this._i.NClose;

        ///<summary>
        ///Specifies whether the PolygonMesh is closed in the N direction
        ///</summary>
        public void Set_NClose(bool bClose) 
		{
			this._i.NClose = bClose;
		}

        ///<summary>
        ///Specifies the smooth surface density of a PolygonMesh in the M direction
        ///</summary>
        public int MDensity => this._i.MDensity;

        ///<summary>
        ///Specifies the smooth surface density of a PolygonMesh in the M direction
        ///</summary>
        public void Set_MDensity(int density) 
		{
			this._i.MDensity = density;
		}

        ///<summary>
        ///Specifies the smooth surface density of a PolygonMesh in the N direction
        ///</summary>
        public int NDensity => this._i.NDensity;

        ///<summary>
        ///Specifies the smooth surface density of a PolygonMesh in the N direction
        ///</summary>
        public void Set_NDensity(int density) 
		{
			this._i.NDensity = density;
		}

        ///<summary>
        ///Gets the vertex count in the M direction for a PolygonMesh
        ///</summary>
        public int MVertexCount => this._i.MVertexCount;

        ///<summary>
        ///Gets the vertex count in the N direction for a PolygonMesh
        ///</summary>
        public int NVertexCount => this._i.NVertexCount;

        ///<summary>
        /// Specifies type of a PolygonMesh object
        ///</summary>
        public object Type => this._i.Type;

        ///<summary>
        /// Specifies type of a PolygonMesh object
        ///</summary>
        public void Set_Type(Autodesk.AutoCAD.Interop.Common.AcPolymeshType Type) 
		{
			this._i.Type = Type;
		}

        ///<summary>
        /// Appends a vertex to the end of a PolygonMesh object
        ///</summary>
        public void AppendVertex(Point vertex) 
		{
			this._i.AppendVertex(Technical.PointByDynPoint(vertex));
		}

        ///<summary>
        /// Get new AcadEntitis as result of that object exploding
        ///</summary>
        public List<AcadEntity> Explode => Technical.GetParts(this._i.Explode());

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
    }
}
