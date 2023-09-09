namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyDirection 
	{
		public AeccXSurveyLib.IAeccSurveyDirection _i;
		internal AeccSurveyDirection(object AeccSurveyDirection_object) 
		{
			this._i = AeccSurveyDirection_object as AeccXSurveyLib.IAeccSurveyDirection;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic FromPointNumber => this._i.FromPointNumber;

		///<summary>
		///
		///</summary>
		public dynamic ToPointNumber => this._i.ToPointNumber;

		///<summary>
		///
		///</summary>
		public double Direction => this._i.Direction;

		///<summary>
		///
		///</summary>
		public void Set_Direction(double pdDirection) 
		{
			this._i.Direction = pdDirection;
		}

		///<summary>
		///
		///</summary>
		public dynamic DirectionType => this._i.DirectionType;

		///<summary>
		///
		///</summary>
		public void Set_DirectionType(AeccXSurveyLib.AeccSurveyDirectionType pDirectionType) 
		{
			this._i.DirectionType = pDirectionType;
		}

		///<summary>
		///
		///</summary>
		public dynamic Network => this._i.Network;

		///<summary>
		///
		///</summary>
		public dynamic Project => this._i.Project;
	}
}
