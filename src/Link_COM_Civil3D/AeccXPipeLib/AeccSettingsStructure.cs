namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsStructure 
	{
		public AeccXPipeLib.IAeccSettingsStructure _i;
		internal AeccSettingsStructure(object AeccSettingsStructure_object) 
		{
			this._i = AeccSettingsStructure_object as AeccXPipeLib.IAeccSettingsStructure;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AmbientSettings => this._i.AmbientSettings;
	}
}
