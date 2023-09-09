namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccWatershedDrains 
	{
		public Autodesk.AECC.Interop.Land.IAeccWatershedDrains _i;
		internal AeccWatershedDrains(object AeccWatershedDrains_object) 
		{
			this._i = AeccWatershedDrains_object as Autodesk.AECC.Interop.Land.IAeccWatershedDrains;
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
