namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsGrading 
	{
		public AeccXLandLib.IAeccSettingsGrading _i;
		internal AeccSettingsGrading(object AeccSettingsGrading_object) 
		{
			this._i = AeccSettingsGrading_object as AeccXLandLib.IAeccSettingsGrading;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic NameTemplate => this._i.NameTemplate;

		///<summary>
		///
		///</summary>
		public dynamic GroupNameTemplate => this._i.GroupNameTemplate;

		///<summary>
		///
		///</summary>
		public dynamic GradeUnitSettings => this._i.GradeUnitSettings;

		///<summary>
		///
		///</summary>
		public dynamic SlopeUnitSettings => this._i.SlopeUnitSettings;

		///<summary>
		///
		///</summary>
		public dynamic CreationSettings => this._i.CreationSettings;

		///<summary>
		///
		///</summary>
		public dynamic StyleSettings => this._i.StyleSettings;

		///<summary>
		///
		///</summary>
		public dynamic AmbientSettings => this._i.AmbientSettings;
	}
}
