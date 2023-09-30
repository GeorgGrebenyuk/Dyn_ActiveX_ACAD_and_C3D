using Autodesk.DesignScript.Geometry;
using System.Collections.Generic;
using System.Linq;

namespace DynAXDBLib 
{

	///<summary>
	///
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
        ///<summary>
        ///
        ///</summary>
        public AcadPolygonMesh(AcadBlock AcadBlock, int M, int N, List<Point> PointsMatrix)
        {
            this._i = AcadBlock._i.Add3DMesh(M, N, PointsMatrix.Select(p=>Technical.PointByDynPoint(p)).ToArray());
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
        ///
        ///</summary>
        public bool MClose => this._i.MClose;

		///<summary>
		///
		///</summary>
		public void Set_MClose(bool bClose) 
		{
			this._i.MClose = bClose;
		}

		///<summary>
		///
		///</summary>
		public bool NClose => this._i.NClose;

		///<summary>
		///
		///</summary>
		public void Set_NClose(bool bClose) 
		{
			this._i.NClose = bClose;
		}

		///<summary>
		///
		///</summary>
		public int MDensity => this._i.MDensity;

		///<summary>
		///
		///</summary>
		public void Set_MDensity(int density) 
		{
			this._i.MDensity = density;
		}

		///<summary>
		///
		///</summary>
		public int NDensity => this._i.NDensity;

		///<summary>
		///
		///</summary>
		public void Set_NDensity(int density) 
		{
			this._i.NDensity = density;
		}

		///<summary>
		///
		///</summary>
		public int MVertexCount => this._i.MVertexCount;

		///<summary>
		///
		///</summary>
		public int NVertexCount => this._i.NVertexCount;

		///<summary>
		///
		///</summary>
		public object Type => this._i.Type;

		///<summary>
		///
		///</summary>
		public void Set_Type(Autodesk.AutoCAD.Interop.Common.AcPolymeshType Type) 
		{
			this._i.Type = Type;
		}

		///<summary>
		///
		///</summary>
		public void AppendVertex(Point vertex) 
		{
			this._i.AppendVertex(Technical.PointByDynPoint(vertex));
		}

        ///<summary>
        /// Get new AcadEntitis as result of that object exploding
        ///</summary>
        public List<AcadEntity> Explode => Technical.GetExploded(this._i.Explode());

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
