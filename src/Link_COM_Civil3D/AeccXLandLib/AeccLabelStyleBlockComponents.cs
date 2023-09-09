namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelStyleBlockComponents 
	{
		public Autodesk.AECC.Interop.Land.IAeccLabelStyleBlockComponents _i;
		internal AeccLabelStyleBlockComponents(object AeccLabelStyleBlockComponents_object) 
		{
			this._i = AeccLabelStyleBlockComponents_object as Autodesk.AECC.Interop.Land.IAeccLabelStyleBlockComponents;
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
