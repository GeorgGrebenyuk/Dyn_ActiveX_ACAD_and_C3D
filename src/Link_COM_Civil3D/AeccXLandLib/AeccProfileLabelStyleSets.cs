namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileLabelStyleSets 
	{
		public Autodesk.AECC.Interop.Land.IAeccProfileLabelStyleSets _i;
		internal AeccProfileLabelStyleSets(object AeccProfileLabelStyleSets_object) 
		{
			this._i = AeccProfileLabelStyleSets_object as Autodesk.AECC.Interop.Land.IAeccProfileLabelStyleSets;
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
		public dynamic Add(string Name) 
		{
			return this._i.Add(Name);
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
