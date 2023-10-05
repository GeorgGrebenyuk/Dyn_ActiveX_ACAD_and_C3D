using System.Collections.Generic;

namespace DynAXDBLib 
{

    ///<summary>
    /// The collection of all viewports in the drawing
    ///</summary>
    public class AcadViewports 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadViewports _i;
		internal AcadViewports(object AcadViewports_object) 
		{
			this._i = AcadViewports_object as Autodesk.AutoCAD.Interop.Common.AcadViewports;
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
        /// Get all viewports
        /// </summary>
        /// <returns></returns>
        public List<AcadViewport> GetAcadUCS()
        {
            List<AcadViewport> us = new List<AcadViewport>(0);
            foreach (var u in this._i)
            {
                us.Add(new AcadViewport(u));
            }
            return us;
        }
        ///<summary>
        ///
        ///</summary>
        public int Count => this._i.Count;


	}
}
