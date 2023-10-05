using System.Collections.Generic;

namespace DynAXDBLib 
{

    ///<summary>
    ///The collection of all layers in the drawing. There is no limit to the number of layers that you can create in your drawing. However, there can be only one instance of the Layers collection. The Layers collection is predefined for each drawing. You can make multiple references to it by using the Layers property. Once done with an object, the reference is automatically released
    ///</summary>
    public class AcadLayers 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadLayers _i;
		internal AcadLayers(object AcadLayers_object) 
		{
			this._i = AcadLayers_object as Autodesk.AutoCAD.Interop.Common.AcadLayers;
			if (this._i == null) throw new System.Exception("Invalid casting");
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
        ///Generates data specifying whether a layer is in use
        ///</summary>
        public void GenerateUsageData() 
		{
			this._i.GenerateUsageData();
		}
	}
}
