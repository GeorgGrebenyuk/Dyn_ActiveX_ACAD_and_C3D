namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAssemblyInsertionDefaults 
	{
		public AeccXRoadwayLib.IAeccSettingsAssemblyInsertionDefaults _i;
		internal AeccSettingsAssemblyInsertionDefaults(object AeccSettingsAssemblyInsertionDefaults_object) 
		{
			this._i = AeccSettingsAssemblyInsertionDefaults_object as AeccXRoadwayLib.IAeccSettingsAssemblyInsertionDefaults;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic FreqAlongTangents => this._i.FreqAlongTangents;

		///<summary>
		///
		///</summary>
		public dynamic FreqAlongCurves => this._i.FreqAlongCurves;

		///<summary>
		///
		///</summary>
		public dynamic FreqAlongSpirals => this._i.FreqAlongSpirals;

		///<summary>
		///
		///</summary>
		public dynamic FreqAlongProfileCurves => this._i.FreqAlongProfileCurves;

		///<summary>
		///
		///</summary>
		public dynamic HorizGeomPoints => this._i.HorizGeomPoints;

		///<summary>
		///
		///</summary>
		public dynamic SuperelevCriticalPoints => this._i.SuperelevCriticalPoints;

		///<summary>
		///
		///</summary>
		public dynamic ProfileGeomPoints => this._i.ProfileGeomPoints;

		///<summary>
		///
		///</summary>
		public dynamic ProfileHighLowPoints => this._i.ProfileHighLowPoints;
	}
}
