namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentLabelGroups 
	{
		public Autodesk.AECC.Interop.Land.IAeccAlignmentLabelGroups _i;
		internal AeccAlignmentLabelGroups(object AeccAlignmentLabelGroups_object) 
		{
			this._i = AeccAlignmentLabelGroups_object as Autodesk.AECC.Interop.Land.IAeccAlignmentLabelGroups;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

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
		public void Remove(dynamic Index) 
		{
			this._i.Remove(Index);
		}
	}
}
