namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsViewFrameGroup 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsViewFrameGroup _i;
		internal AeccSettingsViewFrameGroup(object AeccSettingsViewFrameGroup_object) 
		{
			this._i = AeccSettingsViewFrameGroup_object as Autodesk.AECC.Interop.Land.IAeccSettingsViewFrameGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AmbientSettings => this._i.AmbientSettings;
	}
}
