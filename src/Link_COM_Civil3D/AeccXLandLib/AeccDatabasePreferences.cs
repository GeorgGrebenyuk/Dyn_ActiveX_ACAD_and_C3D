namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccDatabasePreferences 
	{
		public Autodesk.AECC.Interop.Land.IAeccDatabasePreferences _i;
		internal AeccDatabasePreferences(object AeccDatabasePreferences_object) 
		{
			this._i = AeccDatabasePreferences_object as Autodesk.AECC.Interop.Land.IAeccDatabasePreferences;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
