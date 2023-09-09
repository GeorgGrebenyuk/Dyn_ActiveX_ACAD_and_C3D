namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentSTSGroup 
	{
		public Autodesk.AECC.Interop.Land.IAeccAlignmentSTSGroup _i;
		internal AeccAlignmentSTSGroup(object AeccAlignmentSTSGroup_object) 
		{
			this._i = AeccAlignmentSTSGroup_object as Autodesk.AECC.Interop.Land.IAeccAlignmentSTSGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic SpiralIn => this._i.SpiralIn;

		///<summary>
		///
		///</summary>
		public dynamic Tangent => this._i.Tangent;

		///<summary>
		///
		///</summary>
		public dynamic SpiralOut => this._i.SpiralOut;
	}
}
