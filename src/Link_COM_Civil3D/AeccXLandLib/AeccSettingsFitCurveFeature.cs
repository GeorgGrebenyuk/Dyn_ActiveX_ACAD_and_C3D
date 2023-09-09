namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsFitCurveFeature 
	{
		public AeccXLandLib.IAeccSettingsFitCurveFeature _i;
		internal AeccSettingsFitCurveFeature(object AeccSettingsFitCurveFeature_object) 
		{
			this._i = AeccSettingsFitCurveFeature_object as AeccXLandLib.IAeccSettingsFitCurveFeature;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Tolerance => this._i.Tolerance;

		///<summary>
		///
		///</summary>
		public dynamic MinimumNumberSegments => this._i.MinimumNumberSegments;
	}
}
