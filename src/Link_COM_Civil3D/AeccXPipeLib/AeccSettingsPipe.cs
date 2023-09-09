namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsPipe 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccSettingsPipe _i;
		internal AeccSettingsPipe(object AeccSettingsPipe_object) 
		{
			this._i = AeccSettingsPipe_object as Autodesk.AECC.Interop.Pipe.IAeccSettingsPipe;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AmbientSettings => this._i.AmbientSettings;
	}
}
