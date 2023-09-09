namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadShadowDisplay 
	{
		public AXDBLib.IAcadShadowDisplay _i;
		internal AcadShadowDisplay(object AcadShadowDisplay_object) 
		{
			this._i = AcadShadowDisplay_object as AXDBLib.IAcadShadowDisplay;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic ShadowDisplay => this._i.ShadowDisplay;

		///<summary>
		///
		///</summary>
		public void Set_ShadowDisplay(AXDBLib.AcShadowDisplayType ShadowDisplay) 
		{
			this._i.ShadowDisplay = ShadowDisplay;
		}

		///<summary>
		///
		///</summary>
		public dynamic EnableShadowDisplay => this._i.EnableShadowDisplay;
	}
}
