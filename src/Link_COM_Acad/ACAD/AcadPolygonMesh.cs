namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadPolygonMesh 
	{
		public Autodesk.AutoCAD.Interop.Common.IAcadPolygonMesh _i;
		internal AcadPolygonMesh(object AcadPolygonMesh_object) 
		{
			this._i = AcadPolygonMesh_object as Autodesk.AutoCAD.Interop.Common.IAcadPolygonMesh;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public object Coordinates => this._i.Coordinates;

		///<summary>
		///
		///</summary>
		public void Set_Coordinates(object Coordinates) 
		{
			this._i.Coordinates = Coordinates;
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
		public dynamic MDensity => this._i.MDensity;

		///<summary>
		///
		///</summary>
		public void Set_MDensity(dynamic density) 
		{
			this._i.MDensity = density;
		}

		///<summary>
		///
		///</summary>
		public dynamic NDensity => this._i.NDensity;

		///<summary>
		///
		///</summary>
		public void Set_NDensity(dynamic density) 
		{
			this._i.NDensity = density;
		}

		///<summary>
		///
		///</summary>
		public dynamic MVertexCount => this._i.MVertexCount;

		///<summary>
		///
		///</summary>
		public dynamic NVertexCount => this._i.NVertexCount;

		///<summary>
		///
		///</summary>
		public dynamic Type => this._i.Type;

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
		public void AppendVertex(object vertex) 
		{
			this._i.AppendVertex(vertex);
		}

		///<summary>
		///
		///</summary>
		public object Explode => this._i.Explode();

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
