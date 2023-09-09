namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadMaterials 
	{
		public AXDBLib.IAcadMaterials _i;
		internal AcadMaterials(object AcadMaterials_object) 
		{
			this._i = AcadMaterials_object as AXDBLib.IAcadMaterials;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Item(object Index) 
		{
			return this._i.Item(Index);
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Add(string Name) 
		{
			return this._i.Add(Name);
		}
	}
}
