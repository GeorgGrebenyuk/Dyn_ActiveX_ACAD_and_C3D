namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCommandsViewFrameGroup 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsCommandsViewFrameGroup _i;
		internal AeccSettingsCommandsViewFrameGroup(object AeccSettingsCommandsViewFrameGroup_object) 
		{
			this._i = AeccSettingsCommandsViewFrameGroup_object as Autodesk.AECC.Interop.Land.IAeccSettingsCommandsViewFrameGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic CreateSheetsSettings => this._i.CreateSheetsSettings;

		///<summary>
		///
		///</summary>
		public dynamic CreateViewFrames => this._i.CreateViewFrames;
	}
}
