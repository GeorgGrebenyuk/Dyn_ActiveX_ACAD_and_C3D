namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentSCSCSGroup 
	{
		public AeccXLandLib.IAeccAlignmentSCSCSGroup _i;
		internal AeccAlignmentSCSCSGroup(object AeccAlignmentSCSCSGroup_object) 
		{
			this._i = AeccAlignmentSCSCSGroup_object as AeccXLandLib.IAeccAlignmentSCSCSGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Spiral1 => this._i.Spiral1;

		///<summary>
		///
		///</summary>
		public dynamic Arc1 => this._i.Arc1;

		///<summary>
		///
		///</summary>
		public dynamic Spiral2 => this._i.Spiral2;

		///<summary>
		///
		///</summary>
		public dynamic Arc2 => this._i.Arc2;

		///<summary>
		///
		///</summary>
		public dynamic Spiral3 => this._i.Spiral3;
	}
}
