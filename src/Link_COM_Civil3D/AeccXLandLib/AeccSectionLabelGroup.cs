namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionLabelGroup 
	{
		public Autodesk.AECC.Interop.Land.IAeccSectionLabelGroup _i;
		internal AeccSectionLabelGroup(object AeccSectionLabelGroup_object) 
		{
			this._i = AeccSectionLabelGroup_object as Autodesk.AECC.Interop.Land.IAeccSectionLabelGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Type => this._i.Type;

		///<summary>
		///
		///</summary>
		public dynamic Section => this._i.Section;

		///<summary>
		///
		///</summary>
		public dynamic SectionView => this._i.SectionView;

		///<summary>
		///
		///</summary>
		public dynamic DimensionAnchorOption => this._i.DimensionAnchorOption;

		///<summary>
		///
		///</summary>
		public void Set_DimensionAnchorOption(Autodesk.AECC.Interop.Land.AeccLabelDimensionAnchorType pVal) 
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
