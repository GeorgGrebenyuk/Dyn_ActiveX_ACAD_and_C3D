namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCatchmentArea 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsCatchmentArea _i;
		internal AeccSettingsCatchmentArea(object AeccSettingsCatchmentArea_object) 
		{
			this._i = AeccSettingsCatchmentArea_object as Autodesk.AECC.Interop.Land.IAeccSettingsCatchmentArea;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic CatchmentLayer => this._i.CatchmentLayer;

		///<summary>
		///
		///</summary>
		public dynamic CatchmentMarker => this._i.CatchmentMarker;

		///<summary>
		///
		///</summary>
		public dynamic CatchmentMarkerStyle => this._i.CatchmentMarkerStyle;

		///<summary>
		///
		///</summary>
		public dynamic CatchmentObjectType => this._i.CatchmentObjectType;
	}
}
