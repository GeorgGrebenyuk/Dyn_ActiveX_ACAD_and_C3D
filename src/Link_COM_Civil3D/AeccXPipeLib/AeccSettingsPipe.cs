namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsPipe 
	{
		public AeccXPipeLib.IAeccSettingsPipe _i;
		internal AeccSettingsPipe(object AeccSettingsPipe_object) 
		{
			this._i = AeccSettingsPipe_object as AeccXPipeLib.IAeccSettingsPipe;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AmbientSettings => this._i.AmbientSettings;
	}
}
