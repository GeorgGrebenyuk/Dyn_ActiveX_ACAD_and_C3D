namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileLabelGroup 
	{
		public AeccXLandLib.IAeccProfileLabelGroup _i;
		internal AeccProfileLabelGroup(object AeccProfileLabelGroup_object) 
		{
			this._i = AeccProfileLabelGroup_object as AeccXLandLib.IAeccProfileLabelGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Type => this._i.Type;

		///<summary>
		///
		///</summary>
		public dynamic Profile => this._i.Profile;

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
