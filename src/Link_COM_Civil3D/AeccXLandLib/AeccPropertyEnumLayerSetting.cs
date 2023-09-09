namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumLayerSetting 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumLayerSetting _i;
		internal AeccPropertyEnumLayerSetting(object AeccPropertyEnumLayerSetting_object) 
		{
			this._i = AeccPropertyEnumLayerSetting_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumLayerSetting;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccLayerSettingType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
