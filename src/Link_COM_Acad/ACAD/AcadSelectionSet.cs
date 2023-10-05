using Autodesk.DesignScript.Geometry;
using System.Collections.Generic;
using System.Linq;

namespace DynAXDBLib
{
    /// <summary>
    /// A group of one or more AutoCAD objects specified for processing as a single unit
    /// </summary>
    public class AcadSelectionSet
    {
        public Autodesk.AutoCAD.Interop.AcadSelectionSet _i;
        internal AcadSelectionSet(object AcadSelectionSet_object)
        {
            this._i = AcadSelectionSet_object as Autodesk.AutoCAD.Interop.AcadSelectionSet;
        }
        /// <summary>
        /// Create new SelectionSet
        /// </summary>
        /// <param name="AcadSelectionSets"></param>
        /// <param name="Name"></param>
        public AcadSelectionSet(AcadSelectionSets AcadSelectionSets, string Name)
        {
            for (int i = 0; i < AcadSelectionSets._i.Count; i++)
            {
                var obj = AcadSelectionSets._i.Item(i);
                if (obj.Name == Name) this._i = obj;
            }
            this._i = AcadSelectionSets._i.Add(Name);
        }

        /// <summary>
        /// Get all selected items
        /// </summary>
        /// <returns></returns>
        public List<AcadEntity> GetItems()
        {
            List<AcadEntity> es = new List<AcadEntity>();
            foreach (var ent in this._i)
            {
                es.Add(new AcadEntity(ent));
            }
            return es;
        }

        /// <summary>
        /// Specifies the name of the selection set
        /// </summary>

        public string Name => this._i.Name;


        /// <summary>
        /// Adds one or more objects to the specified selection set
        /// </summary>
        /// <param name="Objects">An array of objects to add to the selection set</param>
        public void AddItems(List<AcadEntity> Objects)
        {
            this._i.AddItems(Objects.Select(a => a._i).ToArray());
        }

        /// <summary>
        /// Removes specified items from the group or selection set
        /// </summary>
        /// <param name="Objects">An array of objects to add to the selection set</param>
        public void RemoveItems(List<AcadEntity> Objects)
        {
            this._i.RemoveItems(Objects.Select(a => a._i).ToArray());
        }

        /// <summary>
        /// Deletes a selection set object, but not the objects in the selection set. While the selection set itself will not exist after the call to the Delete method, the items previously in the selection set will still exist.
        /// </summary>
        public void Delete()
        {
            this._i.Delete();
        }

        /// <summary>
        /// Empties the selection set. The selection set will still exist, but will not contain any items. The items that previously resided in the selection still exist, but they no longer reside in the selection set.
        /// </summary>
        public void Clear()
        {
            this._i.Clear();
        }

        /// <summary>
        /// Deletes all items in a selection set. The selection set still exists, but will not contain any items. The items that previously resided in the selection set no longer exist
        /// </summary>
        public void Erase()
        {
            this._i.Erase();
        }

        /// <summary>
        /// Selects objects and places them into a selection set
        /// </summary>
        /// <param name="AcadSelectionSet">AcadSelectionSet instance</param>
        /// <param name="acSelect">AcSelect enum </param>
        /// <param name="Point1">The 3D WCS coordinates, or array of coordinates, specifying Point1. See the mode definitions for the proper use of Point1</param>
        /// <param name="Point2">The 3D WCS coordinates specifying Point2. See the mode definitions for the proper use of Point2</param>
        /// <param name="FilterType">A DXF group code specifying the type of filter to use</param>
        /// <param name="FilterData">The value to filter on</param>
        public static void Select(dynamic AcadSelectionSet, Autodesk.AutoCAD.Interop.Common.AcSelect acSelect, Point Point1, Point Point2, 
            object FilterType, object FilterData)
        {
            AcadSelectionSet._i.Select(acSelect, Technical.PointByDynPoint(Point1), Technical.PointByDynPoint(Point2), FilterType, FilterData);
        }

        /// <summary>
        /// Selects all drawings objects and places them into a selection set
        /// </summary>
        /// <param name="AcadSelectionSet">AcadSelectionSet instance</param>
        public static void SelectAll(dynamic AcadSelectionSet)
        {
            AcadSelectionSet._i.Select(Autodesk.AutoCAD.Interop.Common.AcSelect.acSelectionSetAll);
        }

        /// <summary>
        /// Prompts the user to pick an object from the screen
        /// </summary>
        /// <param name="AcadSelectionSet">AcadSelectionSet instance</param>
        public static void SelectOnScreen(dynamic AcadSelectionSet)
        {
            AcadSelectionSet._i.SelectOnScreen();
        }

        /// <summary>
        /// Selects an object passing through a given point and places it into a selection set
        /// </summary>
        /// <param name="AcadSelectionSet">AcadSelectionSet instance</param>
        /// <param name="point">The 3D UCS coordinates specifying the point to use for the selection</param>
        /// <param name="FilterType">A DXF group code specifying the type of filter to use</param>
        /// <param name="FilterData">The value to filter on</param>
        public static void SelectAtPoint(dynamic AcadSelectionSet, Point point, object FilterType, object FilterData)
        {
            AcadSelectionSet._i.SelectAtPoint(Technical.PointByDynPoint(point), FilterType, FilterData);
        }

        /// <summary>
        /// Selects objects within a fence and adds them to the selection set
        /// </summary>
        /// <param name="acSelect">AcSelect enum </param>
        /// <param name="AcadSelectionSet">AcadSelectionSet instance</param>
        /// <param name="points">An array of 3D WCS coordinates specifying the selection fence</param>
        /// <param name="FilterType">A DXF group code specifying the type of filter to use</param>
        /// <param name="FilterData">The value to filter on</param>
        public static void SelectByPolygon(dynamic AcadSelectionSet, Autodesk.AutoCAD.Interop.Common.AcSelect acSelect, List<Point> points, object FilterType, object FilterData)
        {
            AcadSelectionSet._i.SelectAtPoint(Technical.PointsByDynPoints(points, false), FilterType, FilterData);
        }
    }
}
