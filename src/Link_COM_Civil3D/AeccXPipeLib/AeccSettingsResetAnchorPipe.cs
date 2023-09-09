namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsResetAnchorPipe 
	{
		public AeccXPipeLib.IAeccSettingsResetAnchorPipe _i;
		internal AeccSettingsResetAnchorPipe(object AeccSettingsResetAnchorPipe_object) 
		{
			this._i = AeccSettingsResetAnchorPipe_object as AeccXPipeLib.IAeccSettingsResetAnchorPipe;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
