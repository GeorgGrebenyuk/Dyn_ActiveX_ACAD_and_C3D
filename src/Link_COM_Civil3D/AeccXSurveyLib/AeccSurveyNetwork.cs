namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyNetwork 
	{
		public Autodesk.AECC.Interop.Survey.IAeccSurveyNetwork _i;
		internal AeccSurveyNetwork(object AeccSurveyNetwork_object) 
		{
			this._i = AeccSurveyNetwork_object as Autodesk.AECC.Interop.Survey.IAeccSurveyNetwork;
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
		public bool AutomaticUpdate => this._i.AutomaticUpdate;

		///<summary>
		///
		///</summary>
		public void Set_AutomaticUpdate(bool pbAutomaticUpdate) 
		{
			this._i.AutomaticUpdate = pbAutomaticUpdate;
		}

		///<summary>
		///
		///</summary>
		public bool NeedsUpdate => this._i.NeedsUpdate;

		///<summary>
		///
		///</summary>
		public void Set_NeedsUpdate(bool pbNeedsUpdate) 
		{
			this._i.NeedsUpdate = pbNeedsUpdate;
		}

		///<summary>
		///
		///</summary>
		public object GetExtents => this._i.GetExtents;

		///<summary>
		///
		///</summary>
		public string Path => this._i.Path;

		///<summary>
		///
		///</summary>
		public object GetObservationsToPoint(dynamic nPointNumber) 
		{
			return this._i.GetObservationsToPoint(nPointNumber);
		}

		///<summary>
		///
		///</summary>
		public dynamic ControlPoints => this._i.ControlPoints;

		///<summary>
		///
		///</summary>
		public dynamic Directions => this._i.Directions;

		///<summary>
		///
		///</summary>
		public dynamic Setups => this._i.Setups;

		///<summary>
		///
		///</summary>
		public dynamic Traverses => this._i.Traverses;

		///<summary>
		///
		///</summary>
		public dynamic NonControlPoints => this._i.NonControlPoints;

		///<summary>
		///
		///</summary>
		public double GetDirection(dynamic nPointFrom,dynamic nPointTo) 
		{
			return this._i.GetDirection(nPointFrom,nPointTo);
		}

		///<summary>
		///
		///</summary>
		public object GetPointNumbers => this._i.GetPointNumbers;

		///<summary>
		///
		///</summary>
		public void UpdateNetwork(dynamic piDatabase) 
		{
			this._i.UpdateNetwork(piDatabase);
		}

		///<summary>
		///
		///</summary>
		public void SynchronizePoints(dynamic piDatabase,bool bInsert) 
		{
			this._i.SynchronizePoints(piDatabase,bInsert);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddToDrawing(dynamic piDatabase) 
		{
			return this._i.AddToDrawing(piDatabase);
		}

		///<summary>
		///
		///</summary>
		public bool IsInDrawing(dynamic piDatabase) 
		{
			return this._i.IsInDrawing(piDatabase);
		}

		///<summary>
		///
		///</summary>
		public void AddPointsToDrawing(dynamic piDatabase) 
		{
			this._i.AddPointsToDrawing(piDatabase);
		}

		///<summary>
		///
		///</summary>
		public dynamic LandXMLXPropertiesRoot => this._i.LandXMLXPropertiesRoot;

		///<summary>
		///
		///</summary>
		public dynamic UserDefinedXProperties => this._i.UserDefinedXProperties;
	}
}
