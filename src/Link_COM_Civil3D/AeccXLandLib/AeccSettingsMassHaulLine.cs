namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsMassHaulLine 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsMassHaulLine _i;
		internal AeccSettingsMassHaulLine(object AeccSettingsMassHaulLine_object) 
		{
			this._i = AeccSettingsMassHaulLine_object as Autodesk.AECC.Interop.Land.IAeccSettingsMassHaulLine;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AmbientSettings => this._i.AmbientSettings;
	}
}
