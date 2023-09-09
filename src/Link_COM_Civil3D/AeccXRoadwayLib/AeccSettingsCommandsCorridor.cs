namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCommandsCorridor 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccSettingsCommandsCorridor _i;
		internal AeccSettingsCommandsCorridor(object AeccSettingsCommandsCorridor_object) 
		{
			this._i = AeccSettingsCommandsCorridor_object as Autodesk.AECC.Interop.Roadway.IAeccSettingsCommandsCorridor;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic CorridorExtractSurfaces => this._i.CorridorExtractSurfaces;

		///<summary>
		///
		///</summary>
		public dynamic CreateAlignfromCorridor => this._i.CreateAlignfromCorridor;

		///<summary>
		///
		///</summary>
		public dynamic CreateCogoPoints => this._i.CreateCogoPoints;

		///<summary>
		///
		///</summary>
		public dynamic CreateCorridor => this._i.CreateCorridor;

		///<summary>
		///
		///</summary>
		public dynamic CreateFeatureLine => this._i.CreateFeatureLine;

		///<summary>
		///
		///</summary>
		public dynamic CreateGradingFeatureLine => this._i.CreateGradingFeatureLine;

		///<summary>
		///
		///</summary>
		public dynamic CreateProfileFromCorridor => this._i.CreateProfileFromCorridor;

		///<summary>
		///
		///</summary>
		public dynamic CreateSimpleCorridor => this._i.CreateSimpleCorridor;

		///<summary>
		///
		///</summary>
		public dynamic ViewEditCorridorSection => this._i.ViewEditCorridorSection;
	}
}
