namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsFeatureLineWeedOptions 
	{
		public AeccXLandLib.IAeccSettingsFeatureLineWeedOptions _i;
		internal AeccSettingsFeatureLineWeedOptions(object AeccSettingsFeatureLineWeedOptions_object) 
		{
			this._i = AeccSettingsFeatureLineWeedOptions_object as AeccXLandLib.IAeccSettingsFeatureLineWeedOptions;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic ApplyAngleFactor => this._i.ApplyAngleFactor;

		///<summary>
		///
		///</summary>
		public dynamic AngleFactor => this._i.AngleFactor;

		///<summary>
		///
		///</summary>
		public dynamic ApplyGradeFactor => this._i.ApplyGradeFactor;

		///<summary>
		///
		///</summary>
		public dynamic GradeFactor => this._i.GradeFactor;

		///<summary>
		///
		///</summary>
		public dynamic ApplyLengthFactor => this._i.ApplyLengthFactor;

		///<summary>
		///
		///</summary>
		public dynamic LengthFactor => this._i.LengthFactor;

		///<summary>
		///
		///</summary>
		public dynamic ClosePointRemoval => this._i.ClosePointRemoval;

		///<summary>
		///
		///</summary>
		public dynamic ClosePointDistance => this._i.ClosePointDistance;
	}
}
