namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsComputeMaterials 
	{
		public AeccXRoadwayLib.IAeccSettingsComputeMaterials _i;
		internal AeccSettingsComputeMaterials(object AeccSettingsComputeMaterials_object) 
		{
			this._i = AeccSettingsComputeMaterials_object as AeccXRoadwayLib.IAeccSettingsComputeMaterials;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic ApplyCurveCorrection => this._i.ApplyCurveCorrection;

		///<summary>
		///
		///</summary>
		public dynamic CurveCorrectionTolerance => this._i.CurveCorrectionTolerance;
	}
}
