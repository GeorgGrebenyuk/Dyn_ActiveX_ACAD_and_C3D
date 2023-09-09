namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsViewFrame 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsViewFrame _i;
		internal AeccSettingsViewFrame(object AeccSettingsViewFrame_object) 
		{
			this._i = AeccSettingsViewFrame_object as Autodesk.AECC.Interop.Land.IAeccSettingsViewFrame;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AmbientSettings => this._i.AmbientSettings;
	}
}
