namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyObservations 
	{
		public AeccXSurveyLib.IAeccSurveyObservations _i;
		internal AeccSurveyObservations(object AeccSurveyObservations_object) 
		{
			this._i = AeccSurveyObservations_object as AeccXSurveyLib.IAeccSurveyObservations;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Create(dynamic nPointNumber,AeccXSurveyLib.AeccSurveyAngleType AngleType,double dAngle,AeccXSurveyLib.AeccSurveyDistanceType DistanceType,double dDistance,AeccXSurveyLib.AeccSurveyVerticalType VerticalType,double dVertical,AeccXSurveyLib.AeccSurveyTargetType TargetType,double dTargetHeight,string bstrDescription) 
		{
			return this._i.Create(nPointNumber,AngleType,dAngle,DistanceType,dDistance,VerticalType,dVertical,TargetType,dTargetHeight,bstrDescription);
		}

		///<summary>
		///
		///</summary>
		public void Remove(object varId) 
		{
			this._i.Remove(varId);
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
