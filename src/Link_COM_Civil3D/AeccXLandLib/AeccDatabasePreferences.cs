namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccDatabasePreferences 
	{
		public AeccXLandLib.IAeccDatabasePreferences _i;
		internal AeccDatabasePreferences(object AeccDatabasePreferences_object) 
		{
			this._i = AeccDatabasePreferences_object as AeccXLandLib.IAeccDatabasePreferences;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
