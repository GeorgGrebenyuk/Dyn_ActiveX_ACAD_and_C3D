namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateSurfaceWaterdrop 
	{
		public AeccXLandLib.IAeccSettingsCreateSurfaceWaterdrop _i;
		internal AeccSettingsCreateSurfaceWaterdrop(object AeccSettingsCreateSurfaceWaterdrop_object) 
		{
			this._i = AeccSettingsCreateSurfaceWaterdrop_object as AeccXLandLib.IAeccSettingsCreateSurfaceWaterdrop;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic PlaceMarkerStartPt => this._i.PlaceMarkerStartPt;

		///<summary>
		///
		///</summary>
		public dynamic StartPtMarkerStyle => this._i.StartPtMarkerStyle;

		///<summary>
		///
		///</summary>
		public dynamic PathLayer => this._i.PathLayer;

		///<summary>
		///
		///</summary>
		public dynamic PathObjectType => this._i.PathObjectType;
	}
}
