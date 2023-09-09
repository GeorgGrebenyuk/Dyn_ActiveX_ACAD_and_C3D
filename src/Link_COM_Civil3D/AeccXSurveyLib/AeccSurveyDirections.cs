namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyDirections 
	{
		public Autodesk.AECC.Interop.Survey.IAeccSurveyDirections _i;
		internal AeccSurveyDirections(object AeccSurveyDirections_object) 
		{
			this._i = AeccSurveyDirections_object as Autodesk.AECC.Interop.Survey.IAeccSurveyDirections;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Create(dynamic FromPointNumber,dynamic ToPointNumber,double Direction,Autodesk.AECC.Interop.Survey.AeccSurveyDirectionType DirectionType) 
		{
			return this._i.Create(FromPointNumber,ToPointNumber,Direction,DirectionType);
		}

		///<summary>
		///
		///</summary>
		public void Remove(object varIndex) 
		{
			this._i.Remove(varIndex);
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
