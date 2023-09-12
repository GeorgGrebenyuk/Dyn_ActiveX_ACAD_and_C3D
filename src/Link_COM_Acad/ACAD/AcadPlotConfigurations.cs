using System.Collections.Generic;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadPlotConfigurations 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadPlotConfigurations _i;
		internal AcadPlotConfigurations(object AcadPlotConfigurations_object) 
		{
			this._i = AcadPlotConfigurations_object as Autodesk.AutoCAD.Interop.Common.AcadPlotConfigurations;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public AcadPlotConfigurations Item(object Index) 
		{
			return new AcadPlotConfigurations(this._i.Item(Index));
		}
		public List<AcadPlotConfigurations> GetAll()
		{
			List<AcadPlotConfigurations> cs = new List<AcadPlotConfigurations>();
			foreach (var c in this._i)
			{
				cs.Add(new AcadPlotConfigurations(c));
			}
			return cs;
		}
		///<summary>
		///
		///</summary>
		public int Count => this._i.Count;

		
	}
}
