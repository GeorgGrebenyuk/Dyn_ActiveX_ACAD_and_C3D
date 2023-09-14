namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadHyperlinks 
	{
		public Autodesk.AutoCAD.Interop.Common.IAcadHyperlinks _i;
		internal AcadHyperlinks(object AcadHyperlinks_object) 
		{
			this._i = AcadHyperlinks_object as Autodesk.AutoCAD.Interop.Common.IAcadHyperlinks;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Item(dynamic Index) 
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
		public dynamic Application => this._i.Application;

		
	}
}
