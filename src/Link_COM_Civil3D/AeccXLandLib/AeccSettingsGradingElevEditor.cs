namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsGradingElevEditor 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsGradingElevEditor _i;
		internal AeccSettingsGradingElevEditor(object AeccSettingsGradingElevEditor_object) 
		{
			this._i = AeccSettingsGradingElevEditor_object as Autodesk.AECC.Interop.Land.IAeccSettingsGradingElevEditor;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic RaiseLowerIncrement => this._i.RaiseLowerIncrement;

		///<summary>
		///
		///</summary>
		public dynamic ShowGradeBreaksOnly => this._i.ShowGradeBreaksOnly;
	}
}
