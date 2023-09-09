namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadDatabase 
	{
		public AXDBLib.IAcadDatabase _i;
		internal AcadDatabase(object AcadDatabase_object) 
		{
			this._i = AcadDatabase_object as AXDBLib.IAcadDatabase;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public AcadBlock ModelSpace => new AcadBlock( this._i.ModelSpace);

		///<summary>
		///
		///</summary>
        public AcadBlock PaperSpace => new AcadBlock(this._i.PaperSpace);

        ///<summary>
        ///
        ///</summary>
        public dynamic Blocks => this._i.Blocks;

		///<summary>
		///
		///</summary>
		public object CopyObjects(object Objects,object Owner,object IdPairs) 
		{
			return this._i.CopyObjects(Objects,Owner,IdPairs);
		}

		///<summary>
		///
		///</summary>
		public dynamic Groups => this._i.Groups;

		///<summary>
		///
		///</summary>
		public dynamic DimStyles => this._i.DimStyles;

		///<summary>
		///
		///</summary>
		public dynamic Layers => this._i.Layers;

		///<summary>
		///
		///</summary>
		public dynamic Linetypes => this._i.Linetypes;

		///<summary>
		///
		///</summary>
		public dynamic Dictionaries => this._i.Dictionaries;

		///<summary>
		///
		///</summary>
		public dynamic RegisteredApplications => this._i.RegisteredApplications;

		///<summary>
		///
		///</summary>
		public dynamic TextStyles => this._i.TextStyles;

		///<summary>
		///
		///</summary>
		public dynamic UserCoordinateSystems => this._i.UserCoordinateSystems;

		///<summary>
		///
		///</summary>
		public dynamic Views => this._i.Views;

		///<summary>
		///
		///</summary>
		public dynamic Viewports => this._i.Viewports;

		///<summary>
		///
		///</summary>
		public double ElevationModelSpace => this._i.ElevationModelSpace;

		///<summary>
		///
		///</summary>
		public void Set_ElevationModelSpace(double Elevation) 
		{
			this._i.ElevationModelSpace = Elevation;
		}

		///<summary>
		///
		///</summary>
		public double ElevationPaperSpace => this._i.ElevationPaperSpace;

		///<summary>
		///
		///</summary>
		public void Set_ElevationPaperSpace(double Elevation) 
		{
			this._i.ElevationPaperSpace = Elevation;
		}

		///<summary>
		///
		///</summary>
		public object Limits => this._i.Limits;

		///<summary>
		///
		///</summary>
		public void Set_Limits(object Limits) 
		{
			this._i.Limits = Limits;
		}

		///<summary>
		///
		///</summary>
		public dynamic HandleToObject(string Handle) 
		{
			return this._i.HandleToObject(Handle);
		}

		///<summary>
		///
		///</summary>
		public dynamic ObjectIdToObject(dynamic ObjectID) 
		{
			return this._i.ObjectIdToObject(ObjectID);
		}

		///<summary>
		///
		///</summary>
		public dynamic Layouts => this._i.Layouts;

		///<summary>
		///
		///</summary>
		public dynamic PlotConfigurations => this._i.PlotConfigurations;

		///<summary>
		///
		///</summary>
		public dynamic Preferences => this._i.Preferences;

		///<summary>
		///
		///</summary>
		public dynamic SummaryInfo => this._i.SummaryInfo;

		///<summary>
		///
		///</summary>
		public dynamic SectionManager => this._i.SectionManager;

		///<summary>
		///
		///</summary>
		public dynamic Materials => this._i.Materials;
	}
}
