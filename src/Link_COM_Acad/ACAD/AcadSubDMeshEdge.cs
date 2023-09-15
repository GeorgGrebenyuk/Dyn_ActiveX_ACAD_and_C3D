namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadSubDMeshEdge 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadSubDMeshEdge _i;
		internal AcadSubDMeshEdge(object AcadSubDMeshEdge_object) 
		{
			this._i = AcadSubDMeshEdge_object as Autodesk.AutoCAD.Interop.Common.AcadSubDMeshEdge;
			if (this._i == null) throw new System.Exception("Invalid casting");
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
