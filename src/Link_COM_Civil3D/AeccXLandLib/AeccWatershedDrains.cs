namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccWatershedDrains 
	{
		public AeccXLandLib.IAeccWatershedDrains _i;
		internal AeccWatershedDrains(object AeccWatershedDrains_object) 
		{
			this._i = AeccWatershedDrains_object as AeccXLandLib.IAeccWatershedDrains;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Item(object varIndex) 
		{
			return this._i.Item(varIndex);
		}
	}
}
