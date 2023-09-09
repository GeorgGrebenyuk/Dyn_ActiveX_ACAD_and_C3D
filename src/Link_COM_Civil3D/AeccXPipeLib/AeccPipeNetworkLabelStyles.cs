namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPipeNetworkLabelStyles 
	{
		public AeccXPipeLib.IAeccPipeNetworkLabelStyles _i;
		internal AeccPipeNetworkLabelStyles(object AeccPipeNetworkLabelStyles_object) 
		{
			this._i = AeccPipeNetworkLabelStyles_object as AeccXPipeLib.IAeccPipeNetworkLabelStyles;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic PipeLabelStyles => this._i.PipeLabelStyles;

		///<summary>
		///
		///</summary>
		public dynamic StructureLabelStyles => this._i.StructureLabelStyles;
	}
}
