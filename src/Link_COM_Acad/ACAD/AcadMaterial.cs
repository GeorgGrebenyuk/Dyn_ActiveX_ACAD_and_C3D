namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadMaterial 
	{
		public AXDBLib.IAcadMaterial _i;
		internal AcadMaterial(object AcadMaterial_object) 
		{
			this._i = AcadMaterial_object as AXDBLib.IAcadMaterial;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string Description => this._i.Description;

		///<summary>
		///
		///</summary>
		public void Set_Description(string bstrDes) 
		{
			this._i.Description = bstrDes;
		}

		///<summary>
		///
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public void Set_Name(string bstrName) 
		{
			this._i.Name = bstrName;
		}
	}
}
