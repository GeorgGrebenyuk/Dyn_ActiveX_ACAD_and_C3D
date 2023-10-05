using System.Collections.Generic;

namespace DynAXDBLib 
{

    ///<summary>
    /// The collection of all linetypes in the drawing
    ///</summary>
    public class AcadLineTypes 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadLineTypes _i;
		internal AcadLineTypes(object AcadLineTypes_object) 
		{
			this._i = AcadLineTypes_object as Autodesk.AutoCAD.Interop.Common.AcadLineTypes;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
		///<summary>
		///
		///</summary>
		public int Count => this._i.Count;
        /// <summary>
        /// Get All LineTypes
        /// </summary>
        /// <returns></returns>
        public List<AcadLineType> GetLineTypes()
        {
            List<AcadLineType> objects = new List<AcadLineType>();
            foreach (var obj in this._i)
            {
                objects.Add(new AcadLineType(obj));
            }
            return objects;
        }


        /// <summary>
        /// Loads a menu group from a customization (CUIx) file or the definition of a linetype from a library (LIN) file
        /// </summary>
        /// <param name="Name">The name of the linetype to load</param>
        /// <param name="FileName">The name of the file the linetype is in</param>
        public void Load(string Name,string FileName) 
		{
			this._i.Load(Name,FileName);
		}
	}
}
