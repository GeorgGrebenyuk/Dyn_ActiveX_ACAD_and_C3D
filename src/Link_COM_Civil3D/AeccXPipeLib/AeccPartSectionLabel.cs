namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPartSectionLabel 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccPartSectionLabel _i;
		internal AeccPartSectionLabel(object AeccPartSectionLabel_object) 
		{
			this._i = AeccPartSectionLabel_object as Autodesk.AECC.Interop.Pipe.IAeccPartSectionLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic SectionView => this._i.SectionView;

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
		public dynamic SectionPipeNetwork => this._i.SectionPipeNetwork;

		///<summary>
		///
		///</summary>
		public dynamic DimensionAnchorOption => this._i.DimensionAnchorOption;

		///<summary>
		///
		///</summary>
		public void Set_DimensionAnchorOption(Autodesk.AECC.Interop.Pipe.AeccLabelDimensionAnchorType pVal) 
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
