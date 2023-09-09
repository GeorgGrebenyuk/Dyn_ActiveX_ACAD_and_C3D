namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateFeatureLines 
	{
		public AeccXLandLib.IAeccSettingsCreateFeatureLines _i;
		internal AeccSettingsCreateFeatureLines(object AeccSettingsCreateFeatureLines_object) 
		{
			this._i = AeccSettingsCreateFeatureLines_object as AeccXLandLib.IAeccSettingsCreateFeatureLines;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic FeatureLineCreation => this._i.FeatureLineCreation;
	}
}
