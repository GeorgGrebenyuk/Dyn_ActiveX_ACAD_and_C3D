namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPartProfileLabel 
	{
		public AeccXPipeLib.IAeccPartProfileLabel _i;
		internal AeccPartProfileLabel(object AeccPartProfileLabel_object) 
		{
			this._i = AeccPartProfileLabel_object as AeccXPipeLib.IAeccPartProfileLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic ProfileView => this._i.ProfileView;

		///<summary>
		///
		///</summary>
		public dynamic ReferenceAlignment => this._i.ReferenceAlignment;

		///<summary>
		///
		///</summary>
		public void Set_ReferenceAlignment(object ppVal) 
		{
			this._i.ReferenceAlignment = ppVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic ProfileNetworkPart => this._i.ProfileNetworkPart;

		///<summary>
		///
		///</summary>
		public dynamic DimensionAnchorOption => this._i.DimensionAnchorOption;

		///<summary>
		///
		///</summary>
		public void Set_DimensionAnchorOption(AeccXPipeLib.AeccLabelDimensionAnchorType pVal) 
		{
			this._i.DimensionAnchorOption = pVal;
		}

		///<summary>
		///
		///</summary>
		public double DimensionAnchorValue => this._i.DimensionAnchorValue;

		///<summary>
		///
		///</summary>
		public void Set_DimensionAnchorValue(double pVal) 
		{
			this._i.DimensionAnchorValue = pVal;
		}
	}
}
