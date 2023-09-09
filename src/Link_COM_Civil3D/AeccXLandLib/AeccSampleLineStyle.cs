namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSampleLineStyle 
	{
		public Autodesk.AECC.Interop.Land.IAeccSampleLineStyle _i;
		internal AeccSampleLineStyle(object AeccSampleLineStyle_object) 
		{
			this._i = AeccSampleLineStyle_object as Autodesk.AECC.Interop.Land.IAeccSampleLineStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic LineDisplayStyle2d => this._i.LineDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic LineDisplayStyle3d => this._i.LineDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic VerticesDisplayStyle2d => this._i.VerticesDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic VerticesDisplayStyle3d => this._i.VerticesDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic LineDisplayStylePlan => this._i.LineDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic LineDisplayStyleModel => this._i.LineDisplayStyleModel;

		///<summary>
		///
		///</summary>
		public dynamic VerticesDisplayStylePlan => this._i.VerticesDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic VerticesDisplayStyleModel => this._i.VerticesDisplayStyleModel;
	}
}
