namespace DynAeccXBuildingSiteLib 
{

	///<summary>
	///
	///</summary>
	public class AeccBuildingSite 
	{
		public AeccXBuildingSiteLib.IAeccBuildingSite _i;
		internal AeccBuildingSite(object AeccBuildingSite_object) 
		{
			this._i = AeccBuildingSite_object as AeccXBuildingSiteLib.IAeccBuildingSite;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
