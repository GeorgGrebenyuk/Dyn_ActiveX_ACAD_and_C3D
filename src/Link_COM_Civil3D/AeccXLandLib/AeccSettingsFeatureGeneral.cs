namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsFeatureGeneral 
	{
		public AeccXLandLib.IAeccSettingsFeatureGeneral _i;
		internal AeccSettingsFeatureGeneral(object AeccSettingsFeatureGeneral_object) 
		{
			this._i = AeccSettingsFeatureGeneral_object as AeccXLandLib.IAeccSettingsFeatureGeneral;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AmbientSettings => this._i.AmbientSettings;

		///<summary>
		///
		///</summary>
		public dynamic StyleSettings => this._i.StyleSettings;
	}
}
