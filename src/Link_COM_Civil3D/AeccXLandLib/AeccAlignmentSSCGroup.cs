namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentSSCGroup 
	{
		public Autodesk.AECC.Interop.Land.IAeccAlignmentSSCGroup _i;
		internal AeccAlignmentSSCGroup(object AeccAlignmentSSCGroup_object) 
		{
			this._i = AeccAlignmentSSCGroup_object as Autodesk.AECC.Interop.Land.IAeccAlignmentSSCGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Spiral1 => this._i.Spiral1;

		///<summary>
		///
		///</summary>
		public dynamic Spiral2 => this._i.Spiral2;

		///<summary>
		///
		///</summary>
		public dynamic Arc => this._i.Arc;
	}
}
