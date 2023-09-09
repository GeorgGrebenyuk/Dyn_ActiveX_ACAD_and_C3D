namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsIntersection 
	{
		public AeccXLandLib.IAeccSettingsIntersection _i;
		internal AeccSettingsIntersection(object AeccSettingsIntersection_object) 
		{
			this._i = AeccSettingsIntersection_object as AeccXLandLib.IAeccSettingsIntersection;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AmbientSettings => this._i.AmbientSettings;
	}
}
