namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadLayers 
	{
		public Autodesk.AutoCAD.Interop.Common.IAcadLayers _i;
		internal AcadLayers(object AcadLayers_object) 
		{
			this._i = AcadLayers_object as Autodesk.AutoCAD.Interop.Common.IAcadLayers;
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
		public dynamic Add(string Name) 
		{
			return this._i.Add(Name);
		}

		///<summary>
		///
		///</summary>
		public void GenerateUsageData() 
		{
			this._i.GenerateUsageData();
		}
	}
}
