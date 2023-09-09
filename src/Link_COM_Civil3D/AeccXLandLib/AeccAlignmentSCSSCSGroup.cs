namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentSCSSCSGroup 
	{
		public Autodesk.AECC.Interop.Land.IAeccAlignmentSCSSCSGroup _i;
		internal AeccAlignmentSCSSCSGroup(object AeccAlignmentSCSSCSGroup_object) 
		{
			this._i = AeccAlignmentSCSSCSGroup_object as Autodesk.AECC.Interop.Land.IAeccAlignmentSCSSCSGroup;
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
		public dynamic Spiral3 => this._i.Spiral3;

		///<summary>
		///
		///</summary>
		public dynamic Arc2 => this._i.Arc2;

		///<summary>
		///
		///</summary>
		public dynamic Spiral4 => this._i.Spiral4;
	}
}
