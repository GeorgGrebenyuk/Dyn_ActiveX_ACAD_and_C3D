namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentCSGroup 
	{
		public Autodesk.AECC.Interop.Land.IAeccAlignmentCSGroup _i;
		internal AeccAlignmentCSGroup(object AeccAlignmentCSGroup_object) 
		{
			this._i = AeccAlignmentCSGroup_object as Autodesk.AECC.Interop.Land.IAeccAlignmentCSGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic ArcIn => this._i.ArcIn;

		///<summary>
		///
		///</summary>
		public dynamic SpiralOut => this._i.SpiralOut;
	}
}
