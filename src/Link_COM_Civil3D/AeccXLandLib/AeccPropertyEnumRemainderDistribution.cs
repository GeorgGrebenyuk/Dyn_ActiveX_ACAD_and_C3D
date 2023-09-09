namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumRemainderDistribution 
	{
		public AeccXLandLib.IAeccPropertyEnumRemainderDistribution _i;
		internal AeccPropertyEnumRemainderDistribution(object AeccPropertyEnumRemainderDistribution_object) 
		{
			this._i = AeccPropertyEnumRemainderDistribution_object as AeccXLandLib.IAeccPropertyEnumRemainderDistribution;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccRemainderDistributionType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
