namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccViewFrameStyle 
	{
		public AeccXLandLib.IAeccViewFrameStyle _i;
		internal AeccViewFrameStyle(object AeccViewFrameStyle_object) 
		{
			this._i = AeccViewFrameStyle_object as AeccXLandLib.IAeccViewFrameStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic ViewFrameBorderPlan => this._i.ViewFrameBorderPlan;
	}
}
