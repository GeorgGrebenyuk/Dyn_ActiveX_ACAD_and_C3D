namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyNetworkEntity 
	{
		public AeccXSurveyLib.IAeccSurveyNetworkEntity _i;
		internal AeccSurveyNetworkEntity(object AeccSurveyNetworkEntity_object) 
		{
			this._i = AeccSurveyNetworkEntity_object as AeccXSurveyLib.IAeccSurveyNetworkEntity;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic SurveyNetwork => this._i.SurveyNetwork;
	}
}
