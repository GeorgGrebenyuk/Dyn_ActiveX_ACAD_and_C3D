namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsGradingTools 
	{
		public AeccXLandLib.IAeccSettingsGradingTools _i;
		internal AeccSettingsGradingTools(object AeccSettingsGradingTools_object) 
		{
			this._i = AeccSettingsGradingTools_object as AeccXLandLib.IAeccSettingsGradingTools;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic GradingCriteriaSet => this._i.GradingCriteriaSet;

		///<summary>
		///
		///</summary>
		public dynamic GradingCriteria => this._i.GradingCriteria;
	}
}
