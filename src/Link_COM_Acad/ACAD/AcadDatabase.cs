using System;
using System.Collections.Generic;
using System.Linq;
using dr = Autodesk.DesignScript.Runtime;

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
		/// <summary>
		/// Getting AcadDatabase from Document
		/// </summary>
		/// <param name="AcadDocument"></param>
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
        /// Create a copy of each object in objects list and return AcadIdPair objects (old and new ObjectId)
        ///</summary>
        [dr.MultiReturn(new[] { "Copied_entities", "Result_AcadIdPairs" })]
        public Dictionary<string, object> CopyObjects(List<AcadEntity> Objects, AcadBlock Owner) 
		{
			List<AcadEntity> copied_ents;
			object IdPairs_raw = new object[Objects.Count];
            var ents = this._i.CopyObjects(Objects.Select(o=>o._i).ToArray(),Owner._i, ref IdPairs_raw);

			return new Dictionary<string, object>()
			{
				{"Copied_entities", ((Array)ents).Cast<object>().Select(e=> new AcadEntity(e)).ToList() },
                {"Result_AcadIdPairs", ((Array)IdPairs_raw).Cast<object>().Select(e=> new AcadIdPair(e)).ToList() }
            };
		}

		///<summary>
		///
		///</summary>
		public AcadGroups Groups => new AcadGroups(this._i.Groups);

		///<summary>
		///
		///</summary>
		public AcadDimStyles DimStyles => new AcadDimStyles(this._i.DimStyles);

		///<summary>
		///
		///</summary>
		public AcadLayers Layers => new AcadLayers(this._i.Layers);

		///<summary>
		///
		///</summary>
		public AcadLineTypes Linetypes => new AcadLineTypes(this._i.Linetypes);

		///<summary>
		///
		///</summary>
		public AcadDictionaries Dictionaries => new AcadDictionaries(this._i.Dictionaries);

		///<summary>
		///
		///</summary>
		public AcadRegisteredApplications RegisteredApplications => 
			new AcadRegisteredApplications(this._i.RegisteredApplications);

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
		public AcadViews Views => new AcadViews(this._i.Views);

		///<summary>
		///
		///</summary>
		public AcadViewports Viewports => new AcadViewports(this._i.Viewports);

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
		public double[] Limits => ((Array)this._i.Limits).Cast<double>().ToArray();

		///<summary>
		///
		///</summary>
		public void Set_Limits(double[] Limits) 
		{
			this._i.Limits = Limits;
		}

        ///<summary>
        /// Get an AcadEntity by it's Handle (any DynamoObject.Handle)
        ///</summary>
        public AcadEntity HandleToObject(string Handle) 
		{
			return new AcadEntity(this._i.HandleToObject(Handle));
		}

        ///<summary>
        /// Get an AcadEntity by it's ObjectId (from f.e. Python-script with AutoCAD .NET API)
        ///</summary>
        public AcadEntity ObjectIdToObject(long ObjectID) 
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
		public AcadPlotConfigurations PlotConfigurations => new AcadPlotConfigurations(this._i.PlotConfigurations);

		///<summary>
		///
		///</summary>
		public AcadDatabasePreferences Preferences => new AcadDatabasePreferences(this._i.Preferences);

		///<summary>
		///
		///</summary>
		public AcadSummaryInfo SummaryInfo => new AcadSummaryInfo(this._i.SummaryInfo);

		///<summary>
		///
		///</summary>
		public AcadSectionManager SectionManager => new AcadSectionManager(this._i.SectionManager);

		///<summary>
		///
		///</summary>
		public AcadMaterials Materials => new AcadMaterials(this._i.Materials);
	}
}
