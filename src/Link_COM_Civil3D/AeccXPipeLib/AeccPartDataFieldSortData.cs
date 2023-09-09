namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPartDataFieldSortData 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccPartDataFieldSortData _i;
		internal AeccPartDataFieldSortData(object AeccPartDataFieldSortData_object) 
		{
			this._i = AeccPartDataFieldSortData_object as Autodesk.AECC.Interop.Pipe.IAeccPartDataFieldSortData;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic ContextPriority => this._i.ContextPriority;

		///<summary>
		///
		///</summary>
		public void Set_ContextPriority(dynamic pnContextPriority) 
		{
			this._i.ContextPriority = pnContextPriority;
		}

		///<summary>
		///
		///</summary>
		public string SortGroup => this._i.SortGroup;

		///<summary>
		///
		///</summary>
		public void Set_SortGroup(string pbstrSortGroup) 
		{
			this._i.SortGroup = pbstrSortGroup;
		}

		///<summary>
		///
		///</summary>
		public bool IndexPriority => this._i.IndexPriority;

		///<summary>
		///
		///</summary>
		public void Set_IndexPriority(bool pbIndexPriority) 
		{
			this._i.IndexPriority = pbIndexPriority;
		}
	}
}
