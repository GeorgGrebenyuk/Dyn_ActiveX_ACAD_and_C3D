namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsTransparentCommand 
	{
		public AeccXLandLib.IAeccSettingsTransparentCommand _i;
		internal AeccSettingsTransparentCommand(object AeccSettingsTransparentCommand_object) 
		{
			this._i = AeccSettingsTransparentCommand_object as AeccXLandLib.IAeccSettingsTransparentCommand;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic PromptFor3dPoints => this._i.PromptFor3dPoints;

		///<summary>
		///
		///</summary>
		public dynamic PromptForYBeforeX => this._i.PromptForYBeforeX;

		///<summary>
		///
		///</summary>
		public dynamic PromptForEastThenNorth => this._i.PromptForEastThenNorth;

		///<summary>
		///
		///</summary>
		public dynamic PromptForLongThenLat => this._i.PromptForLongThenLat;

		///<summary>
		///
		///</summary>
		public dynamic GradeInputFormat => this._i.GradeInputFormat;

		///<summary>
		///
		///</summary>
		public dynamic SlopeInputFormat => this._i.SlopeInputFormat;
	}
}
