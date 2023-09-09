namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionStyle 
	{
		public AeccXLandLib.IAeccSectionStyle _i;
		internal AeccSectionStyle(object AeccSectionStyle_object) 
		{
			this._i = AeccSectionStyle_object as AeccXLandLib.IAeccSectionStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic SegmentDisplayStyle2d => this._i.SegmentDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic SegmentDisplayStyle3d => this._i.SegmentDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic PointDisplayStyle2d => this._i.PointDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic PointDisplayStyle3d => this._i.PointDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic SegmentDisplayStyleSection => this._i.SegmentDisplayStyleSection;

		///<summary>
		///
		///</summary>
		public dynamic PointDisplayStyleSection => this._i.PointDisplayStyleSection;
	}
}
