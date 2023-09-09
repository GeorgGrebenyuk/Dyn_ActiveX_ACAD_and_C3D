namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumPipeNetworkDimensionAnchorOption 
	{
		public AeccXPipeLib.IAeccPropertyEnumPipeNetworkDimensionAnchorOption _i;
		internal AeccPropertyEnumPipeNetworkDimensionAnchorOption(object AeccPropertyEnumPipeNetworkDimensionAnchorOption_object) 
		{
			this._i = AeccPropertyEnumPipeNetworkDimensionAnchorOption_object as AeccXPipeLib.IAeccPropertyEnumPipeNetworkDimensionAnchorOption;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXPipeLib.AeccPipeNetworkDimensionAnchorOptionType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
