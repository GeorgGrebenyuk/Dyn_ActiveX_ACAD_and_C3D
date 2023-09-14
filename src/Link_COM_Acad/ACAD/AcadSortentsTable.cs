namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadSortentsTable 
	{
		public Autodesk.AutoCAD.Interop.Common.IAcadSortentsTable _i;
		internal AcadSortentsTable(object AcadSortentsTable_object) 
		{
			this._i = AcadSortentsTable_object as Autodesk.AutoCAD.Interop.Common.IAcadSortentsTable;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void MoveToBottom(object Objects) 
		{
			this._i.MoveToBottom(Objects);
		}

		///<summary>
		///
		///</summary>
		public void MoveToTop(object Objects) 
		{
			this._i.MoveToTop(Objects);
		}

		///<summary>
		///
		///</summary>
		public void MoveBelow(object Objects,dynamic Target) 
		{
			this._i.MoveBelow(Objects,Target);
		}

		///<summary>
		///
		///</summary>
		public void MoveAbove(object Objects,dynamic Target) 
		{
			this._i.MoveAbove(Objects,Target);
		}

		///<summary>
		///
		///</summary>
		public void SwapOrder(dynamic Object1,dynamic Object2) 
		{
			this._i.SwapOrder(Object1,Object2);
		}

		///<summary>
		///
		///</summary>
		public dynamic Block => this._i.Block();

		///<summary>
		///
		///</summary>
		public object GetFullDrawOrder(bool honorSortentsSysvar) 
		{
			object objects = null;
			this._i.GetFullDrawOrder(out objects, honorSortentsSysvar);
			return objects;
		}

		///<summary>
		///
		///</summary>
		public object GetRelativeDrawOrder(bool honorSortentsSysvar) 
		{
            object objects = null;
            this._i.GetRelativeDrawOrder(out objects, honorSortentsSysvar);
            return objects;
        }

		///<summary>
		///
		///</summary>
		public void SetRelativeDrawOrder(object Objects) 
		{
			this._i.SetRelativeDrawOrder(Objects);
		}
	}
}
