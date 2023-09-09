namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAddToProject 
	{
		public AeccXLandLib.IAeccSettingsAddToProject _i;
		internal AeccSettingsAddToProject(object AeccSettingsAddToProject_object) 
		{
			this._i = AeccSettingsAddToProject_object as AeccXLandLib.IAeccSettingsAddToProject;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
