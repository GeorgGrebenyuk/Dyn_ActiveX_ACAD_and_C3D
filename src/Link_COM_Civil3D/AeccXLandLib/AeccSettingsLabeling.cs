namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsLabeling 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsLabeling _i;
		internal AeccSettingsLabeling(object AeccSettingsLabeling_object) 
		{
			this._i = AeccSettingsLabeling_object as Autodesk.AECC.Interop.Land.IAeccSettingsLabeling;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic LabelingPromptMethod => this._i.LabelingPromptMethod;
	}
}
