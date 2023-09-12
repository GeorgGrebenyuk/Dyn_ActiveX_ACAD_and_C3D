namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadBlocks 
	{
		public Autodesk.AutoCAD.Interop.Common.IAcadBlocks _i;
		internal AcadBlocks(object AcadBlocks_object) 
		{
			this._i = AcadBlocks_object as Autodesk.AutoCAD.Interop.Common.IAcadBlocks;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public AcadBlock Item(object Index) 
		{
			return new AcadBlock(this._i.Item(Index));
		}

		///<summary>
		///
		///</summary>
		public int Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public AcadBlock Add(object InsertionPoint,string Name) 
		{
			return new AcadBlock(this._i.Add(InsertionPoint,Name));
		}
	}
}
