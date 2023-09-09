namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateGrading 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsCreateGrading _i;
		internal AeccSettingsCreateGrading(object AeccSettingsCreateGrading_object) 
		{
			this._i = AeccSettingsCreateGrading_object as Autodesk.AECC.Interop.Land.IAeccSettingsCreateGrading;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic TransitionRegionLength => this._i.TransitionRegionLength;
	}
}
