namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadPlotConfigurations 
	{
		public AXDBLib.IAcadPlotConfigurations _i;
		internal AcadPlotConfigurations(object AcadPlotConfigurations_object) 
		{
			this._i = AcadPlotConfigurations_object as AXDBLib.IAcadPlotConfigurations;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Item(object Index) 
		{
			return this._i.Item(Index);
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Add(string Name,object ModelType) 
		{
			return this._i.Add(Name,ModelType);
		}
	}
}
