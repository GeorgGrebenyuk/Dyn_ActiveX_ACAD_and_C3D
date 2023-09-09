namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadPolyfaceMesh 
	{
		public AXDBLib.IAcadPolyfaceMesh _i;
		internal AcadPolyfaceMesh(object AcadPolyfaceMesh_object) 
		{
			this._i = AcadPolyfaceMesh_object as AXDBLib.IAcadPolyfaceMesh;
			if (this._i == null) throw new System.Exception("Invalid casting");
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
