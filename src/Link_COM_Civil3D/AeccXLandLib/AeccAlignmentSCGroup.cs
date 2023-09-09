namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentSCGroup 
	{
		public Autodesk.AECC.Interop.Land.IAeccAlignmentSCGroup _i;
		internal AeccAlignmentSCGroup(object AeccAlignmentSCGroup_object) 
		{
			this._i = AeccAlignmentSCGroup_object as Autodesk.AECC.Interop.Land.IAeccAlignmentSCGroup;
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
