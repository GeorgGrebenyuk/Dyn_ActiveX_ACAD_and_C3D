namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentCSSGroup 
	{
		public Autodesk.AECC.Interop.Land.IAeccAlignmentCSSGroup _i;
		internal AeccAlignmentCSSGroup(object AeccAlignmentCSSGroup_object) 
		{
			this._i = AeccAlignmentCSSGroup_object as Autodesk.AECC.Interop.Land.IAeccAlignmentCSSGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Arc => this._i.Arc;

		///<summary>
		///
		///</summary>
		public dynamic Spiral1 => this._i.Spiral1;

		///<summary>
		///
		///</summary>
		public dynamic Spiral2 => this._i.Spiral2;
	}
}
