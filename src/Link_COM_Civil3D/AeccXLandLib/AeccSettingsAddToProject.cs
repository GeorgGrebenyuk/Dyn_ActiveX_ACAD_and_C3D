namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAddToProject 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsAddToProject _i;
		internal AeccSettingsAddToProject(object AeccSettingsAddToProject_object) 
		{
			this._i = AeccSettingsAddToProject_object as Autodesk.AECC.Interop.Land.IAeccSettingsAddToProject;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
