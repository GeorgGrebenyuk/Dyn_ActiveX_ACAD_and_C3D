namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadRegisteredApplications 
	{
		public AXDBLib.IAcadRegisteredApplications _i;
		internal AcadRegisteredApplications(object AcadRegisteredApplications_object) 
		{
			this._i = AcadRegisteredApplications_object as AXDBLib.IAcadRegisteredApplications;
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
