namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentSCSGroup 
	{
		public AeccXLandLib.IAeccAlignmentSCSGroup _i;
		internal AeccAlignmentSCSGroup(object AeccAlignmentSCSGroup_object) 
		{
			this._i = AeccAlignmentSCSGroup_object as AeccXLandLib.IAeccAlignmentSCSGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic SpiralIn => this._i.SpiralIn;

		///<summary>
		///
		///</summary>
		public dynamic Arc => this._i.Arc;

		///<summary>
		///
		///</summary>
		public dynamic SpiralOut => this._i.SpiralOut;
	}
}
