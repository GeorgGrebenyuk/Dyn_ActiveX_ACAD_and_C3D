using System.Collections.Generic;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadBlocks 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadBlocks _i;
		internal AcadBlocks(object AcadBlocks_object) 
		{
			this._i = AcadBlocks_object as Autodesk.AutoCAD.Interop.Common.AcadBlocks;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		private AcadBlock Item(object Index) 
		{
			return new AcadBlock(this._i.Item(Index));
		}
        public List<AcadBlock> GetObjects()
        {
            List<AcadBlock> es = new List<AcadBlock>();
            foreach (var ent in this._i)
            {
                es.Add(new AcadBlock(ent));
            }
            return es;
        }
        ///<summary>
        ///
        ///</summary>
        public int Count => this._i.Count;

	}
}
