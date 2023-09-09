namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentSCGroup 
	{
		public AeccXLandLib.IAeccAlignmentSCGroup _i;
		internal AeccAlignmentSCGroup(object AeccAlignmentSCGroup_object) 
		{
			this._i = AeccAlignmentSCGroup_object as AeccXLandLib.IAeccAlignmentSCGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic SpiralIn => this._i.SpiralIn;

		///<summary>
		///
		///</summary>
		public dynamic ArcOut => this._i.ArcOut;
	}
}
