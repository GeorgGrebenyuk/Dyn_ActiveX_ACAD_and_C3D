namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateProfileFromCorridor 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccSettingsCreateProfileFromCorridor _i;
		internal AeccSettingsCreateProfileFromCorridor(object AeccSettingsCreateProfileFromCorridor_object) 
		{
			this._i = AeccSettingsCreateProfileFromCorridor_object as Autodesk.AECC.Interop.Roadway.IAeccSettingsCreateProfileFromCorridor;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic CriteriaBasedDesignOptions => this._i.CriteriaBasedDesignOptions;
	}
}
