namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSampledSectionLinks 
	{
		public AeccXLandLib.IAeccSampledSectionLinks _i;
		internal AeccSampledSectionLinks(object AeccSampledSectionLinks_object) 
		{
			this._i = AeccSampledSectionLinks_object as AeccXLandLib.IAeccSampledSectionLinks;
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

		///<summary>
		///
		///</summary>
		public void Remove(object Index) 
		{
			this._i.Remove(Index);
		}
	}
}
