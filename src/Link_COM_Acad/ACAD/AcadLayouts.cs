namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadLayouts 
	{
		public Autodesk.AutoCAD.Interop.Common.IAcadLayouts _i;
		internal AcadLayouts(object AcadLayouts_object) 
		{
			this._i = AcadLayouts_object as Autodesk.AutoCAD.Interop.Common.IAcadLayouts;
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
	}
}
