namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionOverrides 
	{
		public Autodesk.AECC.Interop.Land.IAeccSectionOverrides _i;
		internal AeccSectionOverrides(object AeccSectionOverrides_object) 
		{
			this._i = AeccSectionOverrides_object as Autodesk.AECC.Interop.Land.IAeccSectionOverrides;
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
