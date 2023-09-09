namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSampleLineLabelGroups 
	{
		public Autodesk.AECC.Interop.Land.IAeccSampleLineLabelGroups _i;
		internal AeccSampleLineLabelGroups(object AeccSampleLineLabelGroups_object) 
		{
			this._i = AeccSampleLineLabelGroups_object as Autodesk.AECC.Interop.Land.IAeccSampleLineLabelGroups;
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
