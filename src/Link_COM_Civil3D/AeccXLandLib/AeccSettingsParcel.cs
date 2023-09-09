namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsParcel 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsParcel _i;
		internal AeccSettingsParcel(object AeccSettingsParcel_object) 
		{
			this._i = AeccSettingsParcel_object as Autodesk.AECC.Interop.Land.IAeccSettingsParcel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic StyleSettings => this._i.StyleSettings;

		///<summary>
		///
		///</summary>
		public dynamic AmbientSettings => this._i.AmbientSettings;

		///<summary>
		///
		///</summary>
		public dynamic LabelStyleDefaults => this._i.LabelStyleDefaults;
	}
}
