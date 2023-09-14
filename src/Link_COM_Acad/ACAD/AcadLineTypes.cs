using System.Collections.Generic;

namespace DynAXDBLib 
{

	///<summary>
	///
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
        

		///<summary>
		/// Load Linetype definition from file
		///</summary>
		public void Load(string Name,string FileName) 
		{
			this._i.Load(Name,FileName);
		}
	}
}
