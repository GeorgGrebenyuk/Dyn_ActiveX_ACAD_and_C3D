namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsPipeNetworkProfileLabelPlacement 
	{
		public AeccXPipeLib.IAeccSettingsPipeNetworkProfileLabelPlacement _i;
		internal AeccSettingsPipeNetworkProfileLabelPlacement(object AeccSettingsPipeNetworkProfileLabelPlacement_object) 
		{
			this._i = AeccSettingsPipeNetworkProfileLabelPlacement_object as AeccXPipeLib.IAeccSettingsPipeNetworkProfileLabelPlacement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic DimensionAnchorOptionPipes => this._i.DimensionAnchorOptionPipes;

		///<summary>
		///
		///</summary>
		public dynamic DimensionAnchorElevationPipes => this._i.DimensionAnchorElevationPipes;

		///<summary>
		///
		///</summary>
		public dynamic DimensionAnchorPlotHeightPipes => this._i.DimensionAnchorPlotHeightPipes;

		///<summary>
		///
		///</summary>
		public dynamic DimensionAnchorOptionStructures => this._i.DimensionAnchorOptionStructures;

		///<summary>
		///
		///</summary>
		public dynamic DimensionAnchorElevationStructures => this._i.DimensionAnchorElevationStructures;

		///<summary>
		///
		///</summary>
		public dynamic DimensionAnchorPlotHeightStructures => this._i.DimensionAnchorPlotHeightStructures;

		///<summary>
		///
		///</summary>
		public dynamic StructureLabelPlacement => this._i.StructureLabelPlacement;
	}
}
