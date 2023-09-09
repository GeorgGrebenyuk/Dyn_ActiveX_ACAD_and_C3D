namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadViewports 
	{
		public AXDBLib.IAcadViewports _i;
		internal AcadViewports(object AcadViewports_object) 
		{
			this._i = AcadViewports_object as AXDBLib.IAcadViewports;
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

		///<summary>
		///
		///</summary>
		public void DeleteConfiguration(string Name) 
		{
			this._i.DeleteConfiguration(Name);
		}
	}
}
