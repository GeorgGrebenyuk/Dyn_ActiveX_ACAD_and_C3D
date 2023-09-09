namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileOverrides 
	{
		public AeccXLandLib.IAeccProfileOverrides _i;
		internal AeccProfileOverrides(object AeccProfileOverrides_object) 
		{
			this._i = AeccProfileOverrides_object as AeccXLandLib.IAeccProfileOverrides;
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
