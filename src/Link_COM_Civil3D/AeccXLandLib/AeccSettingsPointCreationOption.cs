namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsPointCreationOption 
	{
		public AeccXLandLib.IAeccSettingsPointCreationOption _i;
		internal AeccSettingsPointCreationOption(object AeccSettingsPointCreationOption_object) 
		{
			this._i = AeccSettingsPointCreationOption_object as AeccXLandLib.IAeccSettingsPointCreationOption;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic LocalCoordinates => this._i.LocalCoordinates;

		///<summary>
		///
		///</summary>
		public dynamic GridCoordinates => this._i.GridCoordinates;

		///<summary>
		///
		///</summary>
		public dynamic GeoCoordinates => this._i.GeoCoordinates;

		///<summary>
		///
		///</summary>
		public dynamic PromptForElevation => this._i.PromptForElevation;

		///<summary>
		///
		///</summary>
		public dynamic PromptForPointNames => this._i.PromptForPointNames;

		///<summary>
		///
		///</summary>
		public dynamic PromptForDescriptions => this._i.PromptForDescriptions;

		///<summary>
		///
		///</summary>
		public dynamic DefaultElevation => this._i.DefaultElevation;

		///<summary>
		///
		///</summary>
		public dynamic DefaultDescription => this._i.DefaultDescription;

		///<summary>
		///
		///</summary>
		public dynamic MatchOnDescriptionParameter => this._i.MatchOnDescriptionParameter;

		///<summary>
		///
		///</summary>
		public dynamic DisableDecriptionKeys => this._i.DisableDecriptionKeys;

		///<summary>
		///
		///</summary>
		public dynamic EchoCoordinatesToCommandLine => this._i.EchoCoordinatesToCommandLine;
	}
}
