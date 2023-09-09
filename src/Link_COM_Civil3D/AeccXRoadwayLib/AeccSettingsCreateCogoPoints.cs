namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateCogoPoints 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccSettingsCreateCogoPoints _i;
		internal AeccSettingsCreateCogoPoints(object AeccSettingsCreateCogoPoints_object) 
		{
			this._i = AeccSettingsCreateCogoPoints_object as Autodesk.AECC.Interop.Roadway.IAeccSettingsCreateCogoPoints;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
