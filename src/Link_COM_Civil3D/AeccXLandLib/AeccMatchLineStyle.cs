namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccMatchLineStyle 
	{
		public Autodesk.AECC.Interop.Land.IAeccMatchLineStyle _i;
		internal AeccMatchLineStyle(object AeccMatchLineStyle_object) 
		{
			this._i = AeccMatchLineStyle_object as Autodesk.AECC.Interop.Land.IAeccMatchLineStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic LinesPlan => this._i.LinesPlan;

		///<summary>
		///
		///</summary>
		public dynamic MatchLineMaskPlan => this._i.MatchLineMaskPlan;

		///<summary>
		///
		///</summary>
		public dynamic MatchLineMaskHatchPlan => this._i.MatchLineMaskHatchPlan;
	}
}
