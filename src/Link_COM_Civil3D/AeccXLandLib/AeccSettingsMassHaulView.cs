namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsMassHaulView 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsMassHaulView _i;
		internal AeccSettingsMassHaulView(object AeccSettingsMassHaulView_object) 
		{
			this._i = AeccSettingsMassHaulView_object as Autodesk.AECC.Interop.Land.IAeccSettingsMassHaulView;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AmbientSettings => this._i.AmbientSettings;
	}
}
