namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateFeatureLine 
	{
		public AeccXRoadwayLib.IAeccSettingsCreateFeatureLine _i;
		internal AeccSettingsCreateFeatureLine(object AeccSettingsCreateFeatureLine_object) 
		{
			this._i = AeccSettingsCreateFeatureLine_object as AeccXRoadwayLib.IAeccSettingsCreateFeatureLine;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
