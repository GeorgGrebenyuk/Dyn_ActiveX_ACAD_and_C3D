namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileViewStyle 
	{
		public AeccXLandLib.IAeccProfileViewStyle _i;
		internal AeccProfileViewStyle(object AeccProfileViewStyle_object) 
		{
			this._i = AeccProfileViewStyle_object as AeccXLandLib.IAeccProfileViewStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic GraphStyle => this._i.GraphStyle;

		///<summary>
		///
		///</summary>
		public dynamic TopAxis => this._i.TopAxis;

		///<summary>
		///
		///</summary>
		public dynamic BottomAxis => this._i.BottomAxis;

		///<summary>
		///
		///</summary>
		public dynamic LeftAxis => this._i.LeftAxis;

		///<summary>
		///
		///</summary>
		public dynamic RightAxis => this._i.RightAxis;

		///<summary>
		///
		///</summary>
		public dynamic HorizontalGeometryDisplayStyle2d => this._i.HorizontalGeometryDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic GridAtHGPDisplayStyle2d => this._i.GridAtHGPDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic HorizontalGeometryDisplayStylePlan => this._i.HorizontalGeometryDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic GridAtHGPDisplayStylePlan => this._i.GridAtHGPDisplayStylePlan;
	}
}
