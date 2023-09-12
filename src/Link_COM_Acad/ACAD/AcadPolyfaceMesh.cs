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
        ///
        ///</summary>
        public void Set_Coordinates(object Vertices) 
		{
			this._i.Coordinates = Vertices;
		}

		///<summary>
		///
		///</summary>
		public object Coordinates => this._i.Coordinates;

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
