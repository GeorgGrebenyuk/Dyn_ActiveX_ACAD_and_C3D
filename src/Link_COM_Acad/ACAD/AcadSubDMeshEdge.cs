namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadSubDMeshEdge 
	{
		public AXDBLib.IAcadSubDMeshEdge _i;
		internal AcadSubDMeshEdge(object AcadSubDMeshEdge_object) 
		{
			this._i = AcadSubDMeshEdge_object as AXDBLib.IAcadSubDMeshEdge;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic CreaseType => this._i.CreaseType;

		///<summary>
		///
		///</summary>
		public void Set_CreaseType(AXDBLib.AcMeshCreaseType Type) 
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
