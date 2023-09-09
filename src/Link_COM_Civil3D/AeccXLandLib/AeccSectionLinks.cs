namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionLinks 
	{
		public Autodesk.AECC.Interop.Land.IAeccSectionLinks _i;
		internal AeccSectionLinks(object AeccSectionLinks_object) 
		{
			this._i = AeccSectionLinks_object as Autodesk.AECC.Interop.Land.IAeccSectionLinks;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Item(object Index) 
		{
			return this._i.Item(Index);
		}
	}
}
