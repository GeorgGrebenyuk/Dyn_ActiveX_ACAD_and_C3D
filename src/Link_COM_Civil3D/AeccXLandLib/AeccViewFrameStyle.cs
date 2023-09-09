namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccViewFrameStyle 
	{
		public Autodesk.AECC.Interop.Land.IAeccViewFrameStyle _i;
		internal AeccViewFrameStyle(object AeccViewFrameStyle_object) 
		{
			this._i = AeccViewFrameStyle_object as Autodesk.AECC.Interop.Land.IAeccViewFrameStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic ViewFrameBorderPlan => this._i.ViewFrameBorderPlan;
	}
}
