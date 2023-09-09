namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentIndexedPILabel 
	{
		public AeccXLandLib.IAeccAlignmentIndexedPILabel _i;
		internal AeccAlignmentIndexedPILabel(object AeccAlignmentIndexedPILabel_object) 
		{
			this._i = AeccAlignmentIndexedPILabel_object as AeccXLandLib.IAeccAlignmentIndexedPILabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Alignment => this._i.Alignment;
	}
}
