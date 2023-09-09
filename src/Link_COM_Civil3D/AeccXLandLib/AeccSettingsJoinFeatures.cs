namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsJoinFeatures 
	{
		public AeccXLandLib.IAeccSettingsJoinFeatures _i;
		internal AeccSettingsJoinFeatures(object AeccSettingsJoinFeatures_object) 
		{
			this._i = AeccSettingsJoinFeatures_object as AeccXLandLib.IAeccSettingsJoinFeatures;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Tolerance => this._i.Tolerance;
	}
}
