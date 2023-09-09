namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyObject 
	{
		public AeccXSurveyLib.IAeccSurveyObject _i;
		internal AeccSurveyObject(object AeccSurveyObject_object) 
		{
			this._i = AeccSurveyObject_object as AeccXSurveyLib.IAeccSurveyObject;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic ID => this._i.ID;

		///<summary>
		///
		///</summary>
		public dynamic Revision => this._i.Revision;

		///<summary>
		///
		///</summary>
		public void Save() 
		{
			this._i.Save();
		}

		///<summary>
		///
		///</summary>
		public void Reload() 
		{
			this._i.Reload();
		}
	}
}
