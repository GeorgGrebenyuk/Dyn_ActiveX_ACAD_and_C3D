namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadViewports 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadViewports _i;
		internal AcadViewports(object AcadViewports_object) 
		{
			this._i = AcadViewports_object as Autodesk.AutoCAD.Interop.Common.AcadViewports;
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
		public int Count => this._i.Count;


	}
}
