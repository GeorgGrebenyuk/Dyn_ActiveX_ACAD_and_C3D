namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileViewDepthLabel 
	{
		public AeccXLandLib.IAeccProfileViewDepthLabel _i;
		internal AeccProfileViewDepthLabel(object AeccProfileViewDepthLabel_object) 
		{
			this._i = AeccProfileViewDepthLabel_object as AeccXLandLib.IAeccProfileViewDepthLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic ProfileView => this._i.ProfileView;

		///<summary>
		///
		///</summary>
		public dynamic DimensionAnchorOption => this._i.DimensionAnchorOption;

		///<summary>
		///
		///</summary>
		public void Set_DimensionAnchorOption(AeccXLandLib.AeccLabelDimensionAnchorType pVal) 
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
