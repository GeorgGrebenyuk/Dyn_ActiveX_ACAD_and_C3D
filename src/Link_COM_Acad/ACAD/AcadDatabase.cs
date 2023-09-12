using System.Collections.Generic;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadDatabase 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadDatabase _i;
		internal AcadDatabase(object AcadDatabase_object) 
		{
			this._i = AcadDatabase_object as Autodesk.AutoCAD.Interop.Common.AcadDatabase;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
		public AcadDatabase (AcadDocument AcadDocument)
		{
			this._i = AcadDocument._i.Database;

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
        public AcadBlocks Blocks => new AcadBlocks(this._i.Blocks);

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
		public AcadGroups Groups => new AcadGroups(this._i.Groups);

		///<summary>
		///
		///</summary>
		public dynamic DimStyles => this._i.DimStyles;

		///<summary>
		///
		///</summary>
		public AcadLayers Layers => new AcadLayers(this._i.Layers);

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
		public AcadTextStyles TextStyles => new AcadTextStyles(this._i.TextStyles);

		///<summary>
		///
		///</summary>
		public AcadUCSs UserCoordinateSystems => new AcadUCSs(this._i.UserCoordinateSystems);

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
		public AcadEntity HandleToObject(string Handle) 
		{
			return new AcadEntity(this._i.HandleToObject(Handle));
		}

		///<summary>
		///
		///</summary>
		public AcadEntity ObjectIdToObject(dynamic ObjectID) 
		{
			return new AcadEntity(this._i.ObjectIdToObject(ObjectID));
		}

		///<summary>
		///
		///</summary>
		public AcadLayouts Layouts => new AcadLayouts(this._i.Layouts);

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
		public AcadSummaryInfo SummaryInfo => new AcadSummaryInfo(this._i.SummaryInfo);

		///<summary>
		///
		///</summary>
		public dynamic SectionManager => this._i.SectionManager;

		///<summary>
		///
		///</summary>
		public AcadMaterials Materials => new AcadMaterials(this._i.Materials);
	}
}
