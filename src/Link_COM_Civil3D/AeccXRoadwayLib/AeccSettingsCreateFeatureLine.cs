namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateFeatureLine 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccSettingsCreateFeatureLine _i;
		internal AeccSettingsCreateFeatureLine(object AeccSettingsCreateFeatureLine_object) 
		{
			this._i = AeccSettingsCreateFeatureLine_object as Autodesk.AECC.Interop.Roadway.IAeccSettingsCreateFeatureLine;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
