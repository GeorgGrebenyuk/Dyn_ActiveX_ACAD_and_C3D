namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumPipeNetworkDimensionAnchorOption 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccPropertyEnumPipeNetworkDimensionAnchorOption _i;
		internal AeccPropertyEnumPipeNetworkDimensionAnchorOption(object AeccPropertyEnumPipeNetworkDimensionAnchorOption_object) 
		{
			this._i = AeccPropertyEnumPipeNetworkDimensionAnchorOption_object as Autodesk.AECC.Interop.Pipe.IAeccPropertyEnumPipeNetworkDimensionAnchorOption;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Pipe.AeccPipeNetworkDimensionAnchorOptionType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
