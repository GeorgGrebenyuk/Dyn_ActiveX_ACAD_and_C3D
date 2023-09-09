namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionViews 
	{
		public Autodesk.AECC.Interop.Land.IAeccSectionViews _i;
		internal AeccSectionViews(object AeccSectionViews_object) 
		{
			this._i = AeccSectionViews_object as Autodesk.AECC.Interop.Land.IAeccSectionViews;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

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
		public dynamic Add(string Name,string Layer,object Origin,dynamic Style,dynamic BandStyleSet) 
		{
			return this._i.Add(Name,Layer,Origin,Style,BandStyleSet);
		}

		///<summary>
		///
		///</summary>
		public void Remove(object val) 
		{
			this._i.Remove(val);
		}
	}
}
