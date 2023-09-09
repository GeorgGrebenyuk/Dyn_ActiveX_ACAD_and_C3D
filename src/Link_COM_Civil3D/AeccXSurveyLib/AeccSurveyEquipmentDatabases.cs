namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyEquipmentDatabases 
	{
		public AeccXSurveyLib.IAeccSurveyEquipmentDatabases _i;
		internal AeccSurveyEquipmentDatabases(object AeccSurveyEquipmentDatabases_object) 
		{
			this._i = AeccSurveyEquipmentDatabases_object as AeccXSurveyLib.IAeccSurveyEquipmentDatabases;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Create(string bstrName) 
		{
			return this._i.Create(bstrName);
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Item(dynamic nIndex) 
		{
			return this._i.Item(nIndex);
		}

		///<summary>
		///
		///</summary>
		public dynamic FindItem(object varIndex) 
		{
			return this._i.FindItem(varIndex);
		}
	}
}
