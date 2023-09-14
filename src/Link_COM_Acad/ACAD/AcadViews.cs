namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadViews 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadViews _i;
		internal AcadViews(object AcadViews_object) 
		{
			this._i = AcadViews_object as Autodesk.AutoCAD.Interop.Common.AcadViews;
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
