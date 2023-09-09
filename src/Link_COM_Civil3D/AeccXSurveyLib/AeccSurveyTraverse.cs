namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyTraverse 
	{
		public Autodesk.AECC.Interop.Survey.IAeccSurveyTraverse _i;
		internal AeccSurveyTraverse(object AeccSurveyTraverse_object) 
		{
			this._i = AeccSurveyTraverse_object as Autodesk.AECC.Interop.Survey.IAeccSurveyTraverse;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public void Set_Name(string pbstrName) 
		{
			this._i.Name = pbstrName;
		}

		///<summary>
		///
		///</summary>
		public string Description => this._i.Description;

		///<summary>
		///
		///</summary>
		public void Set_Description(string pbstrDescription) 
		{
			this._i.Description = pbstrDescription;
		}

		///<summary>
		///
		///</summary>
		public dynamic Project => this._i.Project;

		///<summary>
		///
		///</summary>
		public dynamic Network => this._i.Network;

		///<summary>
		///
		///</summary>
		public dynamic InitialStationPointNumber => this._i.InitialStationPointNumber;

		///<summary>
		///
		///</summary>
		public void Set_InitialStationPointNumber(dynamic pnInitialStation) 
		{
			this._i.InitialStationPointNumber = pnInitialStation;
		}

		///<summary>
		///
		///</summary>
		public dynamic InitialBacksightPointNumber => this._i.InitialBacksightPointNumber;

		///<summary>
		///
		///</summary>
		public void Set_InitialBacksightPointNumber(dynamic pnInitialBacksight) 
		{
			this._i.InitialBacksightPointNumber = pnInitialBacksight;
		}

		///<summary>
		///
		///</summary>
		public dynamic FinalForesightPointNumber => this._i.FinalForesightPointNumber;

		///<summary>
		///
		///</summary>
		public void Set_FinalForesightPointNumber(dynamic pnFinalForesight) 
		{
			this._i.FinalForesightPointNumber = pnFinalForesight;
		}

		///<summary>
		///
		///</summary>
		public object StationPointNumbers => this._i.StationPointNumbers;

		///<summary>
		///
		///</summary>
		public void Set_StationPointNumbers(object pvarStationPoints) 
		{
			this._i.StationPointNumbers = pvarStationPoints;
		}
	}
}
