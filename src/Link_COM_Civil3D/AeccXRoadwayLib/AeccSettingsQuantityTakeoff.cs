namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsQuantityTakeoff 
	{
		public AeccXRoadwayLib.IAeccSettingsQuantityTakeoff _i;
		internal AeccSettingsQuantityTakeoff(object AeccSettingsQuantityTakeoff_object) 
		{
			this._i = AeccSettingsQuantityTakeoff_object as AeccXRoadwayLib.IAeccSettingsQuantityTakeoff;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic MaterialNameTemplate => this._i.MaterialNameTemplate;

		///<summary>
		///
		///</summary>
		public dynamic QuantityTakeoffCriteria => this._i.QuantityTakeoffCriteria;

		///<summary>
		///
		///</summary>
		public dynamic AmbientSettings => this._i.AmbientSettings;
	}
}
