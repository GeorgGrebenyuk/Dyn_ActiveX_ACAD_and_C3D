namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsProfileViewCreation 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsProfileViewCreation _i;
		internal AeccSettingsProfileViewCreation(object AeccSettingsProfileViewCreation_object) 
		{
			this._i = AeccSettingsProfileViewCreation_object as Autodesk.AECC.Interop.Land.IAeccSettingsProfileViewCreation;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic SpecifyProfileStationRange => this._i.SpecifyProfileStationRange;

		///<summary>
		///
		///</summary>
		public dynamic SpecifyProfileElevationRange => this._i.SpecifyProfileElevationRange;

		///<summary>
		///
		///</summary>
		public dynamic DisplayNetworkParts => this._i.DisplayNetworkParts;
	}
}
