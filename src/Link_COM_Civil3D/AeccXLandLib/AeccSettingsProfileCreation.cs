namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsProfileCreation 
	{
		public AeccXLandLib.IAeccSettingsProfileCreation _i;
		internal AeccSettingsProfileCreation(object AeccSettingsProfileCreation_object) 
		{
			this._i = AeccSettingsProfileCreation_object as AeccXLandLib.IAeccSettingsProfileCreation;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic DefaultVerticalCurve => this._i.DefaultVerticalCurve;

		///<summary>
		///
		///</summary>
		public dynamic ParabolicSagVerticalConstraint => this._i.ParabolicSagVerticalConstraint;

		///<summary>
		///
		///</summary>
		public dynamic ParabolicCrestVerticalConstraint => this._i.ParabolicCrestVerticalConstraint;

		///<summary>
		///
		///</summary>
		public dynamic ParabolicCrestCurveLength => this._i.ParabolicCrestCurveLength;

		///<summary>
		///
		///</summary>
		public dynamic ParabolicCrestCurveKValue => this._i.ParabolicCrestCurveKValue;

		///<summary>
		///
		///</summary>
		public dynamic ParabolicSagCurveLength => this._i.ParabolicSagCurveLength;

		///<summary>
		///
		///</summary>
		public dynamic ParabolicSagCurveKValue => this._i.ParabolicSagCurveKValue;

		///<summary>
		///
		///</summary>
		public dynamic CircularCrestCurveRadius => this._i.CircularCrestCurveRadius;

		///<summary>
		///
		///</summary>
		public dynamic CircularSagCurveRadius => this._i.CircularSagCurveRadius;

		///<summary>
		///
		///</summary>
		public dynamic AsymmetricalCrestCurveLength1 => this._i.AsymmetricalCrestCurveLength1;

		///<summary>
		///
		///</summary>
		public dynamic AsymmetricalCrestCurveLength2 => this._i.AsymmetricalCrestCurveLength2;

		///<summary>
		///
		///</summary>
		public dynamic AsymmetricalSagCurveLength1 => this._i.AsymmetricalSagCurveLength1;

		///<summary>
		///
		///</summary>
		public dynamic AsymmetricalSagCurveLength2 => this._i.AsymmetricalSagCurveLength2;

		///<summary>
		///
		///</summary>
		public dynamic PassingEyeHeight => this._i.PassingEyeHeight;

		///<summary>
		///
		///</summary>
		public dynamic PassingObjectHeight => this._i.PassingObjectHeight;

		///<summary>
		///
		///</summary>
		public dynamic StoppingEyeHeight => this._i.StoppingEyeHeight;

		///<summary>
		///
		///</summary>
		public dynamic StoppingObjectHeight => this._i.StoppingObjectHeight;

		///<summary>
		///
		///</summary>
		public dynamic HeadlightAngle => this._i.HeadlightAngle;

		///<summary>
		///
		///</summary>
		public dynamic HeadlightHeight => this._i.HeadlightHeight;
	}
}
