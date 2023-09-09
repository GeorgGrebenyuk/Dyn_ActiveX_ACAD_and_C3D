namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentSTGroup 
	{
		public AeccXLandLib.IAeccAlignmentSTGroup _i;
		internal AeccAlignmentSTGroup(object AeccAlignmentSTGroup_object) 
		{
			this._i = AeccAlignmentSTGroup_object as AeccXLandLib.IAeccAlignmentSTGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic SpiralIn => this._i.SpiralIn;

		///<summary>
		///
		///</summary>
		public dynamic TangentOut => this._i.TangentOut;
	}
}
