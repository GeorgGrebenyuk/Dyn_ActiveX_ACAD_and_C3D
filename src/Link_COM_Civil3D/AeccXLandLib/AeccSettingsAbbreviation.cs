namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAbbreviation 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsAbbreviation _i;
		internal AeccSettingsAbbreviation(object AeccSettingsAbbreviation_object) 
		{
			this._i = AeccSettingsAbbreviation_object as Autodesk.AECC.Interop.Land.IAeccSettingsAbbreviation;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AlignmentAbbreviations => this._i.AlignmentAbbreviations;

		///<summary>
		///
		///</summary>
		public dynamic ProfileAbbreviations => this._i.ProfileAbbreviations;

		///<summary>
		///
		///</summary>
		public dynamic AlignmentEnhancedAbbreviations => this._i.AlignmentEnhancedAbbreviations;

		///<summary>
		///
		///</summary>
		public dynamic SuperelevationAbbreviations => this._i.SuperelevationAbbreviations;
	}
}
