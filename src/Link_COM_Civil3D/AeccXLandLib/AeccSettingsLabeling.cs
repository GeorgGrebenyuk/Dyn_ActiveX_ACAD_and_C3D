namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsLabeling 
	{
		public AeccXLandLib.IAeccSettingsLabeling _i;
		internal AeccSettingsLabeling(object AeccSettingsLabeling_object) 
		{
			this._i = AeccSettingsLabeling_object as AeccXLandLib.IAeccSettingsLabeling;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic LabelingPromptMethod => this._i.LabelingPromptMethod;
	}
}
