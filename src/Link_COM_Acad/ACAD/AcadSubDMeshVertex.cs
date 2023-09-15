namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadSubDMeshVertex 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadSubDMeshVertex _i;
		internal AcadSubDMeshVertex(object AcadSubDMeshVertex_object) 
		{
			this._i = AcadSubDMeshVertex_object as Autodesk.AutoCAD.Interop.Common.AcadSubDMeshVertex;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public object Coordinates => this._i.Coordinates;

		///<summary>
		///
		///</summary>
		public void Set_Coordinates(object coord) 
		{
			this._i.Coordinates = coord;
		}

		///<summary>
		///
		///</summary>
		public dynamic CreaseType => this._i.CreaseType;

		///<summary>
		///
		///</summary>
		public void Set_CreaseType(Autodesk.AutoCAD.Interop.Common.AcMeshCreaseType Type) 
		{
			this._i.CreaseType = Type;
		}

		///<summary>
		///
		///</summary>
		public double CreaseLevel => this._i.CreaseLevel;

		///<summary>
		///
		///</summary>
		public void Set_CreaseLevel(double level) 
		{
			this._i.CreaseLevel = level;
		}
	}
}
