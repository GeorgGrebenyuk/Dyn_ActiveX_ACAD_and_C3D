namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateSubFromPline 
	{
		public AeccXRoadwayLib.IAeccSettingsCreateSubFromPline _i;
		internal AeccSettingsCreateSubFromPline(object AeccSettingsCreateSubFromPline_object) 
		{
			this._i = AeccSettingsCreateSubFromPline_object as AeccXRoadwayLib.IAeccSettingsCreateSubFromPline;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic MidOrdinateDistance => this._i.MidOrdinateDistance;

		///<summary>
		///
		///</summary>
		public dynamic LinkCreation => this._i.LinkCreation;
	}
}
