using System;
using System.Collections.Generic;
using System.Linq;
using dr = Autodesk.DesignScript.Runtime;

namespace DynAXDBLib 
{

    ///<summary>
    /// The contents of an XRef block
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
        ///Gets the ModelSpace collection for the document
        ///</summary>
        public AcadBlock ModelSpace => new AcadBlock( this._i.ModelSpace);

        ///<summary>
        ///Gets the PaperSpace collection for the document
        ///</summary>
        public AcadBlock PaperSpace => new AcadBlock(this._i.PaperSpace);

        ///<summary>
        ///Gets the Blocks collection for the drawing
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
        ///Gets the Groups collection for the document
        ///</summary>
        public AcadGroups Groups => new AcadGroups(this._i.Groups);

        ///<summary>
        ///Gets the DimStyles collection for the document
        ///</summary>
        public AcadDimStyles DimStyles => new AcadDimStyles(this._i.DimStyles);

        ///<summary>
        ///Gets the Layers collection for the document.
        ///</summary>
        public AcadLayers Layers => new AcadLayers(this._i.Layers);

        ///<summary>
        ///Gets the Linetypes collection for the document
        ///</summary>
        public AcadLineTypes Linetypes => new AcadLineTypes(this._i.Linetypes);

        ///<summary>
        ///Gets the Dictionaries collection for the document
        ///</summary>
        public AcadDictionaries Dictionaries => new AcadDictionaries(this._i.Dictionaries);

        ///<summary>
        ///Gets the RegisteredApplications collection for the document
        ///</summary>
        public AcadRegisteredApplications RegisteredApplications => 
			new AcadRegisteredApplications(this._i.RegisteredApplications);

        ///<summary>
        ///Gets the TextStyles collection for the document
        ///</summary>
        public AcadTextStyles TextStyles => new AcadTextStyles(this._i.TextStyles);

        ///<summary>
        ///Gets the UCSs collection for the document
        ///</summary>
        public AcadUCSs UserCoordinateSystems => new AcadUCSs(this._i.UserCoordinateSystems);

        ///<summary>
        ///Gets the Views collection for the document
        ///</summary>
        public AcadViews Views => new AcadViews(this._i.Views);

        ///<summary>
        ///Gets the Viewports collection for the document. 
        ///</summary>
        public AcadViewports Viewports => new AcadViewports(this._i.Viewports);

        ///<summary>
        ///Specifies the elevation setting in model space. The current elevation is the Z value that is used whenever a 3D point is expected but only the X and Y values are supplied. The current elevation is maintained separately in model space and paper space
        ///</summary>
        public double ElevationModelSpace => this._i.ElevationModelSpace;

        ///<summary>
        ///Specifies the elevation setting in model space. The current elevation is the Z value that is used whenever a 3D point is expected but only the X and Y values are supplied. The current elevation is maintained separately in model space and paper space
        ///</summary>
        public void Set_ElevationModelSpace(double Elevation) 
		{
			this._i.ElevationModelSpace = Elevation;
		}

        ///<summary>
        ///Specifies the elevation setting in paper space. The current elevation is the Z value that is used whenever a 3D point is expected but only the X and Y values are supplied. The current elevation is maintained separately in model space and paper space
        ///</summary>
        public double ElevationPaperSpace => this._i.ElevationPaperSpace;

        ///<summary>
        ///Specifies the elevation setting in paper space. The current elevation is the Z value that is used whenever a 3D point is expected but only the X and Y values are supplied. The current elevation is maintained separately in model space and paper space
        ///</summary>
        public void Set_ElevationPaperSpace(double Elevation) 
		{
			this._i.ElevationPaperSpace = Elevation;
		}

        ///<summary>
        ///Specifies the drawing limits
        ///</summary>
        public double[] Limits => ((Array)this._i.Limits).Cast<double>().ToArray();

        ///<summary>
        ///Specifies the drawing limits
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
        ///Gets the Layouts collection for the document
        ///</summary>
        public AcadLayouts Layouts => new AcadLayouts(this._i.Layouts);

        ///<summary>
        ///Gets the PlotConfigurations collection for the document.
        ///</summary>
        public AcadPlotConfigurations PlotConfigurations => new AcadPlotConfigurations(this._i.PlotConfigurations);

        ///<summary>
        ///Gets the Preferences object
        ///</summary>
        public AcadDatabasePreferences Preferences => new AcadDatabasePreferences(this._i.Preferences);

        ///<summary>
        ///Specifies the properties of a drawing
        ///</summary>
        public AcadSummaryInfo SummaryInfo => new AcadSummaryInfo(this._i.SummaryInfo);

        ///<summary>
        ///Returns the section manager object
        ///</summary>
        public AcadSectionManager SectionManager => new AcadSectionManager(this._i.SectionManager);

        ///<summary>
        ///Specifies the Materials of a drawing
        ///</summary>
        public AcadMaterials Materials => new AcadMaterials(this._i.Materials);
	}
}
