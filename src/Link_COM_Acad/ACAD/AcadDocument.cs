
using Autodesk.AutoCAD.Interop.Common;

namespace DynAXDBLib
{

    ///<summary>
    ///
    ///</summary>
    public class AcadDocument
    {
        public Autodesk.AutoCAD.Interop.AcadDocument _i;
        /// <summary>
        /// Получает активный документ (проект)
        /// </summary>
        /// <param name="Application"></param>

        public AcadDocument(AcadApplication AcadApplication)
        {
            this._i = AcadApplication._i.ActiveDocument;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="AcadDocument_object"></param>
        public AcadDocument(object AcadDocument_object)
        {
            this._i = AcadDocument_object as Autodesk.AutoCAD.Interop.AcadDocument;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        public void SendCommand(string command) => this._i.SendCommand(command);
        /// <summary>
        /// 
        /// </summary>
        public string FullName => this._i.FullName;
        public void AuditInfo(bool FixErr) => this._i.AuditInfo(FixErr);
        public void Save() => this._i.Save();
        public void PurgeAll() => this._i.PurgeAll();
        public object GetVariable(string Name) => this._i.GetVariable(Name);
        public void SetVariable(string Name, object Value) => this._i.SetVariable(Name, Value);
        public void Regen(object WhichViewports) => this._i.Regen((AcRegenType)WhichViewports);
        public AcadDatabase Database => new AcadDatabase(this._i.Database);
    }
}