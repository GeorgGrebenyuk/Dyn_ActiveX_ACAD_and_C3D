namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccInterferenceCheckCriteria 
	{
		public AeccXPipeLib.IAeccInterferenceCheckCriteria _i;
		internal AeccInterferenceCheckCriteria(object AeccInterferenceCheckCriteria_object) 
		{
			this._i = AeccInterferenceCheckCriteria_object as AeccXPipeLib.IAeccInterferenceCheckCriteria;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public bool ApplyProximity => this._i.ApplyProximity;

		///<summary>
		///
		///</summary>
		public void Set_ApplyProximity(bool pbApplyProximity) 
		{
			this._i.ApplyProximity = pbApplyProximity;
		}

		///<summary>
		///
		///</summary>
		public dynamic UseDistanceOrScaleFactor => this._i.UseDistanceOrScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_UseDistanceOrScaleFactor(AeccXPipeLib.AeccProximityDistanceScaleFactorOptions pUseDistanceOrScaleFactor) 
		{
			this._i.UseDistanceOrScaleFactor = pUseDistanceOrScaleFactor;
		}

		///<summary>
		///
		///</summary>
		public double CriteriaDistance => this._i.CriteriaDistance;

		///<summary>
		///
		///</summary>
		public void Set_CriteriaDistance(double pdCriteriaDistance) 
		{
			this._i.CriteriaDistance = pdCriteriaDistance;
		}

		///<summary>
		///
		///</summary>
		public double ScaleFactor => this._i.ScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_ScaleFactor(double pdScaleFactor) 
		{
			this._i.ScaleFactor = pdScaleFactor;
		}
	}
}
