namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionViewStyle 
	{
		public Autodesk.AECC.Interop.Land.IAeccSectionViewStyle _i;
		internal AeccSectionViewStyle(object AeccSectionViewStyle_object) 
		{
			this._i = AeccSectionViewStyle_object as Autodesk.AECC.Interop.Land.IAeccSectionViewStyle;
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
		public dynamic CenterAxis => this._i.CenterAxis;

		///<summary>
		///
		///</summary>
		public dynamic SampleLineVerticesDisplayStyle2d => this._i.SampleLineVerticesDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic SampleLineVerticesDisplayStylePlan => this._i.SampleLineVerticesDisplayStylePlan;
	}
}
