namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateSubFromPline 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccSettingsCreateSubFromPline _i;
		internal AeccSettingsCreateSubFromPline(object AeccSettingsCreateSubFromPline_object) 
		{
			this._i = AeccSettingsCreateSubFromPline_object as Autodesk.AECC.Interop.Roadway.IAeccSettingsCreateSubFromPline;
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
