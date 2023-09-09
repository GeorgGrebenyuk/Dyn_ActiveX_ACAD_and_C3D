namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentPILabel 
	{
		public AeccXLandLib.IAeccAlignmentPILabel _i;
		internal AeccAlignmentPILabel(object AeccAlignmentPILabel_object) 
		{
			this._i = AeccAlignmentPILabel_object as AeccXLandLib.IAeccAlignmentPILabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Alignment => this._i.Alignment;
	}
}
