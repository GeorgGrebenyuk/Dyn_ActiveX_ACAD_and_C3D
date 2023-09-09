namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentTSGroup 
	{
		public Autodesk.AECC.Interop.Land.IAeccAlignmentTSGroup _i;
		internal AeccAlignmentTSGroup(object AeccAlignmentTSGroup_object) 
		{
			this._i = AeccAlignmentTSGroup_object as Autodesk.AECC.Interop.Land.IAeccAlignmentTSGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic TangentIn => this._i.TangentIn;

		///<summary>
		///
		///</summary>
		public dynamic SpiralOut => this._i.SpiralOut;
	}
}
