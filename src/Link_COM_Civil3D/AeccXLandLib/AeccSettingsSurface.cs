namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsSurface 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsSurface _i;
		internal AeccSettingsSurface(object AeccSettingsSurface_object) 
		{
			this._i = AeccSettingsSurface_object as Autodesk.AECC.Interop.Land.IAeccSettingsSurface;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic NameTemplate => this._i.NameTemplate;

		///<summary>
		///
		///</summary>
		public dynamic StyleSettings => this._i.StyleSettings;

		///<summary>
		///
		///</summary>
		public dynamic CreationSettings => this._i.CreationSettings;

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
