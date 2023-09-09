namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsResetAnchorPipe 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccSettingsResetAnchorPipe _i;
		internal AeccSettingsResetAnchorPipe(object AeccSettingsResetAnchorPipe_object) 
		{
			this._i = AeccSettingsResetAnchorPipe_object as Autodesk.AECC.Interop.Pipe.IAeccSettingsResetAnchorPipe;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
