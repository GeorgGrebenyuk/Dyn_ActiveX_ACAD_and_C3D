using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynAXDBLib
{
    /// <summary>
    /// The collection of all selection sets in the drawing
    /// </summary>
    public class AcadSelectionSets
    {
        public Autodesk.AutoCAD.Interop.AcadSelectionSets _i;
        internal AcadSelectionSets(object AcadSelectionSets_object)
        {
            this._i = AcadSelectionSets_object as Autodesk.AutoCAD.Interop.AcadSelectionSets;
        }
        /// <summary>
        /// Get AcadSelectionSets from Document
        /// </summary>
        /// <param name="acadDocument"></param>
        public AcadSelectionSets(AcadDocument acadDocument)
        {
            this._i = acadDocument._i.SelectionSets;
        }
        public int Count => this._i.Count;
        /// <summary>
        /// Get all AcadSelectionSets
        /// </summary>
        /// <returns></returns>
        public List<AcadSelectionSet> GetSelectionSets()
        {
            List<AcadSelectionSet> es = new List<AcadSelectionSet>();
            foreach (var ent in this._i)
            {
                es.Add(new AcadSelectionSet(ent));
            }
            return es;
        }
    }
}
