
using Autodesk.AutoCAD.Interop.Common;

namespace DynAXDBLib
{

    ///<summary>
    /// An AutoCAD drawing
    ///</summary>
    public class AcadDocument
    {
        public Autodesk.AutoCAD.Interop.AcadDocument _i;

        /// <summary>
        ///  Get active document
        /// </summary>
        /// <param name="AcadApplication"></param>
        public AcadDocument(AcadApplication AcadApplication)
        {
            this._i = AcadApplication._i.ActiveDocument;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="AcadDocument_object"></param>
        internal AcadDocument(object AcadDocument_object)
        {
            this._i = AcadDocument_object as Autodesk.AutoCAD.Interop.AcadDocument;
        }

        /// <summary>
        /// Sends a command string from a VB or VBA application to the document for processing
        /// </summary>
        /// <param name="command"></param>
        public void SendCommand(string command) => this._i.SendCommand(command);

        /// <summary>
        /// Write some message in Acad prompt
        /// </summary>
        /// <param name="message"></param>
        public void WriteMessage(string message) => this._i.Utility.Prompt(message);

        /// <summary>
        /// Gets the name of the application or document, including the path
        /// </summary>
        public string FullName => this._i.FullName;

        /// <summary>
        /// Evaluates the integrity of the drawing
        /// </summary>
        /// <param name="FixErr"></param>
        public void AuditInfo(bool FixErr) => this._i.AuditInfo(FixErr);

        /// <summary>
        /// Saves a document or group of layer property settings; no longer supported for menu groups
        /// </summary>
        public void Save() => this._i.Save();

        /// <summary>
        /// Removes unused named references such as unused blocks or layers from the document
        /// </summary>
        public void PurgeAll() => this._i.PurgeAll();

        /// <summary>
        /// Gets the current setting of an AutoCAD system variable
        /// </summary>
        /// <param name="Name">The name of the variable to return. Must contain a valid system variable name (the case of the characters is not significant)</param>
        /// <returns></returns>
        public object GetVariable(string Name) => this._i.GetVariable(Name);

        /// <summary>
        /// Regenerates the entire drawing and recomputes the screen coordinates and view resolution for all objects
        /// </summary>
        /// <param name="WhichViewports">AcRegenType type</param>
        public void Regen(AcRegenType WhichViewports) => this._i.Regen((AcRegenType)WhichViewports);

        /// <summary>
        /// Gets the database in which the object belongs
        /// </summary>
        public AcadDatabase Database => new AcadDatabase(this._i.Database);

        /// <summary>
        /// Specifies the active dimension style
        /// </summary>
        public AcadDimStyle ActiveDimStyle => new AcadDimStyle(this._i.ActiveDimStyle);

        /// <summary>
        /// Specifies the active dimension style
        /// </summary>
        /// <param name="ActiveDimStyle"></param>
        public void Set_ActiveDimStyle(AcadDimStyle ActiveDimStyle) => this._i.ActiveDimStyle = ActiveDimStyle._i;

        /// <summary>
        /// Specifies the active layer
        /// </summary>
        public AcadLayer ActiveLayer => new AcadLayer(this._i.ActiveLayer);

        /// <summary>
        /// Specifies the active layer
        /// </summary>
        /// <param name="AcadLayer"></param>
        public void Set_ActiveLayer(AcadLayer AcadLayer) => this._i.ActiveLayer = AcadLayer._i;

        /// <summary>
        /// Specifies the active layout
        /// </summary>
        public AcadLayout ActiveLayout => new AcadLayout(this._i.ActiveLayout);

        /// <summary>
        /// Specifies the active layout
        /// </summary>
        /// <param name="AcadLayout"></param>
        public void Set_ActiveLayout(AcadLayout AcadLayout) => this._i.ActiveLayout = AcadLayout._i;

        /// <summary>
        /// Specifies the active line type
        /// </summary>
        public AcadLineType ActiveLinetype => new AcadLineType(this._i.ActiveLinetype);

        /// <summary>
        /// Specifies the active line type
        /// </summary>
        /// <param name="AcadLineType"></param>
        public void Set_ActiveLinetype(AcadLineType AcadLineType) => this._i.ActiveLinetype = AcadLineType._i;

        /// <summary>
        /// Specifies the current default material for this document
        /// </summary>
        public AcadMaterial ActiveMaterial => new AcadMaterial(this._i.ActiveMaterial);

        /// <summary>
        /// Specifies the current default material for this document
        /// </summary>
        /// <param name="AcadMaterial"></param>
        public void Set_ActiveMaterial(AcadMaterial AcadMaterial) => this._i.ActiveMaterial = AcadMaterial._i;

        /// <summary>
        /// Specifies the active paper space viewport for the drawing
        /// </summary>
        public AcadPViewport ActivePViewport => new AcadPViewport(this._i.ActivePViewport);

        /// <summary>
        /// Specifies the active paper space viewport for the drawing
        /// </summary>
        /// <param name="AcadPViewport"></param>
        public void Set_ActivePViewport(AcadPViewport AcadPViewport) => this._i.ActivePViewport = AcadPViewport._i;

        /// <summary>
        /// Toggles the active space between paper space and model space
        /// </summary>
        public AcActiveSpace ActiveSpace => this._i.ActiveSpace;

        /// <summary>
        /// Toggles the active space between paper space and model space
        /// </summary>
        /// <param name="ActiveSpace"></param>
        public void Set_ActiveSpace(AcActiveSpace ActiveSpace) => this._i.ActiveSpace = ActiveSpace;

        /// <summary>
        /// Specifies the active text style for the drawing
        /// </summary>
        public AcadTextStyle ActiveTextStyle => new AcadTextStyle(this._i.ActiveTextStyle);

        /// <summary>
        /// Specifies the active text style for the drawing
        /// </summary>
        /// <param name="AcadTextStyle"></param>
        public void Set_ActiveTextStyle(AcadTextStyle AcadTextStyle) => this._i.ActiveTextStyle = AcadTextStyle._i;

        /// <summary>
        /// Specifies the active UCS for the drawing
        /// </summary>
        public AcadUCS ActiveUCS => new AcadUCS(this._i.ActiveUCS);

        /// <summary>
        /// Specifies the active UCS for the drawing
        /// </summary>
        /// <param name="AcadUCS"></param>
        public void Set_ActiveUCS(AcadUCS AcadUCS) => this._i.ActiveUCS = AcadUCS._i;

        /// <summary>
        /// Specifies the active viewport for the drawing
        /// </summary>
        public AcadViewport ActiveViewport => new AcadViewport(this._i.ActiveViewport);

        /// <summary>
        /// Specifies the active viewport for the drawing
        /// </summary>
        /// <param name="AcadViewport"></param>
        public void Set_ActiveViewport(AcadViewport AcadViewport) => this._i.ActiveViewport = AcadViewport._i;

        /// <summary>
        /// Gets the active selection set for the drawing
        /// </summary>
        public AcadSelectionSet ActiveSelectionSet => new AcadSelectionSet(this._i.ActiveSelectionSet);

    }
}