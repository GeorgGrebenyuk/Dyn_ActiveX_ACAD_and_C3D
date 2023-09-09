namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadSubDMeshFace 
	{
		public AXDBLib.IAcadSubDMeshFace _i;
		internal AcadSubDMeshFace(object AcadSubDMeshFace_object) 
		{
			this._i = AcadSubDMeshFace_object as AXDBLib.IAcadSubDMeshFace;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string Material => this._i.Material;

		///<summary>
		///
		///</summary>
		public void Set_Material(string Material) 
		{
			this._i.Material = Material;
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
