namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentLabelGroup 
	{
		public AeccXLandLib.IAeccAlignmentLabelGroup _i;
		internal AeccAlignmentLabelGroup(object AeccAlignmentLabelGroup_object) 
		{
			this._i = AeccAlignmentLabelGroup_object as AeccXLandLib.IAeccAlignmentLabelGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Type => this._i.Type;

		///<summary>
		///
		///</summary>
		public dynamic Alignment => this._i.Alignment;
	}
}
