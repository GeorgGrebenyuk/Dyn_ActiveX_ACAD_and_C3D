using System.Collections.Generic;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadHyperlinks 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadHyperlinks _i;
		internal AcadHyperlinks(object AcadHyperlinks_object) 
		{
			this._i = AcadHyperlinks_object as Autodesk.AutoCAD.Interop.Common.AcadHyperlinks;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

        ///<summary>
        ///
        ///</summary>
        private dynamic Item(dynamic Index) 
		{
			return this._i.Item(Index);
		}

		///<summary>
		///
		///</summary>
		public int Count => this._i.Count;

        public List<AcadHyperlink> GetHyperlinks()
        {
            List<AcadHyperlink> gr = new List<AcadHyperlink>();
            foreach (var g in this._i)
            {
                gr.Add(new AcadHyperlink(g));
            }
            return gr;
        }


    }
}
