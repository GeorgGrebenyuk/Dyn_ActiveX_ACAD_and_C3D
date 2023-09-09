namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCurveTessellationOption 
	{
		public AeccXLandLib.IAeccSettingsCurveTessellationOption _i;
		internal AeccSettingsCurveTessellationOption(object AeccSettingsCurveTessellationOption_object) 
		{
			this._i = AeccSettingsCurveTessellationOption_object as AeccXLandLib.IAeccSettingsCurveTessellationOption;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic TessellateCurve => this._i.TessellateCurve;

		///<summary>
		///
		///</summary>
		public dynamic MidOrdinateTolerance => this._i.MidOrdinateTolerance;
	}
}
