namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentSTGroup 
	{
		public Autodesk.AECC.Interop.Land.IAeccAlignmentSTGroup _i;
		internal AeccAlignmentSTGroup(object AeccAlignmentSTGroup_object) 
		{
			this._i = AeccAlignmentSTGroup_object as Autodesk.AECC.Interop.Land.IAeccAlignmentSTGroup;
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
