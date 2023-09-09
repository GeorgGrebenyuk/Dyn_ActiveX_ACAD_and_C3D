namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadSectionManager 
	{
		public AXDBLib.IAcadSectionManager _i;
		internal AcadSectionManager(object AcadSectionManager_object) 
		{
			this._i = AcadSectionManager_object as AXDBLib.IAcadSectionManager;
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
		public dynamic GetLiveSection => this._i.GetLiveSection;

		///<summary>
		///
		///</summary>
		public string GetUniqueSectionName(string pBaseName) 
		{
			return this._i.GetUniqueSectionName(pBaseName);
		}
	}
}
