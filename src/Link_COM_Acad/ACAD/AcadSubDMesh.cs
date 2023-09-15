namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadSubDMesh 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadSubDMesh _i;
		internal AcadSubDMesh(object AcadSubDMesh_object) 
		{
			this._i = AcadSubDMesh_object as Autodesk.AutoCAD.Interop.Common.AcadSubDMesh;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public int Smoothness => this._i.Smoothness;

		///<summary>
		///
		///</summary>
		public void Set_Smoothness(int level) 
		{
			this._i.Smoothness = level;
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
		public int VertexCount => this._i.VertexCount;

		///<summary>
		///
		///</summary>
		public int FaceCount => this._i.FaceCount;
	}
}
