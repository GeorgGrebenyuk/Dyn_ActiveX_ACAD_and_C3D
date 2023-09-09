namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsGradingCreation 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsGradingCreation _i;
		internal AeccSettingsGradingCreation(object AeccSettingsGradingCreation_object) 
		{
			this._i = AeccSettingsGradingCreation_object as Autodesk.AECC.Interop.Land.IAeccSettingsGradingCreation;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic TransitionRegionLength => this._i.TransitionRegionLength;

		///<summary>
		///
		///</summary>
		public dynamic AutoConvertObjects => this._i.AutoConvertObjects;

		///<summary>
		///
		///</summary>
		public dynamic EraseSelectedObjects => this._i.EraseSelectedObjects;

		///<summary>
		///
		///</summary>
		public dynamic UseSelectedObjectLayers => this._i.UseSelectedObjectLayers;
	}
}
