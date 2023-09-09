namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccWatershedDrain 
	{
		public AeccXLandLib.IAeccWatershedDrain _i;
		internal AeccWatershedDrain(object AeccWatershedDrain_object) 
		{
			this._i = AeccWatershedDrain_object as AeccXLandLib.IAeccWatershedDrain;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public object Location => this._i.Location;

		///<summary>
		///
		///</summary>
		public string Targets => this._i.Targets;
	}
}
