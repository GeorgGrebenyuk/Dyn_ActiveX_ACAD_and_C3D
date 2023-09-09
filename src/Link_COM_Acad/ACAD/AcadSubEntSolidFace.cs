namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadSubEntSolidFace 
	{
		public AXDBLib.IAcadSubEntSolidFace _i;
		internal AcadSubEntSolidFace(object AcadSubEntSolidFace_object) 
		{
			this._i = AcadSubEntSolidFace_object as AXDBLib.IAcadSubEntSolidFace;
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
	}
}
