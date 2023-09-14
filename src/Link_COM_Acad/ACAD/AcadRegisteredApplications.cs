using System.Collections.Generic;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadRegisteredApplications 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadRegisteredApplications _i;
		internal AcadRegisteredApplications(object AcadRegisteredApplications_object) 
		{
			this._i = AcadRegisteredApplications_object as Autodesk.AutoCAD.Interop.Common.AcadRegisteredApplications;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		private dynamic Item(object Index) 
		{
			return this._i.Item(Index);
		}
        /// <summary>
        /// Get All RegisteredApplications
        /// </summary>
        /// <returns></returns>
        public List<AcadRegisteredApplication> GetRegisteredApplications()
        {
            List<AcadRegisteredApplication> objects = new List<AcadRegisteredApplication>();
            foreach (var obj in this._i)
            {
                objects.Add(new AcadRegisteredApplication(obj));
            }
            return objects;
        }
        ///<summary>
        ///
        ///</summary>
        public int Count => this._i.Count;

		
	}
}
