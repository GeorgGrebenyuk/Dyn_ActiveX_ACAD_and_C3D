namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentSCSGroup 
	{
		public Autodesk.AECC.Interop.Land.IAeccAlignmentSCSGroup _i;
		internal AeccAlignmentSCSGroup(object AeccAlignmentSCSGroup_object) 
		{
			this._i = AeccAlignmentSCSGroup_object as Autodesk.AECC.Interop.Land.IAeccAlignmentSCSGroup;
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
