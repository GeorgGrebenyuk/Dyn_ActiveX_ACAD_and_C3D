namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceTriangleStyle 
	{
		public AeccXLandLib.IAeccSurfaceTriangleStyle _i;
		internal AeccSurfaceTriangleStyle(object AeccSurfaceTriangleStyle_object) 
		{
			this._i = AeccSurfaceTriangleStyle_object as AeccXLandLib.IAeccSurfaceTriangleStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic DisplayStyle2d => this._i.DisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic DisplayStyle3d => this._i.DisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic DisplayStylePlan => this._i.DisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic DisplayStyleModel => this._i.DisplayStyleModel;
	}
}
