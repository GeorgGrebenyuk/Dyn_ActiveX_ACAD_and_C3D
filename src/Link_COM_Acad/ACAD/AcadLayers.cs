using System.Collections.Generic;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadLayers 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadLayers _i;
		internal AcadLayers(object AcadLayers_object) 
		{
			this._i = AcadLayers_object as Autodesk.AutoCAD.Interop.Common.AcadLayers;
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
		/// Get all layers in document
		/// </summary>
		/// <returns></returns>
        public List<AcadLayer> GetLayers ()
        {
            List<AcadLayer> ls = new List<AcadLayer>();
            foreach (var l in this._i)
            {
                ls.Add(new AcadLayer(l));
            }
            return ls;
        }

        ///<summary>
        ///
        ///</summary>
        public int Count => this._i.Count;


		///<summary>
		///
		///</summary>
		public void GenerateUsageData() 
		{
			this._i.GenerateUsageData();
		}
	}
}
