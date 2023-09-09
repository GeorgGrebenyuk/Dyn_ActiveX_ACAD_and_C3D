namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelStyleLineComponents 
	{
		public Autodesk.AECC.Interop.Land.IAeccLabelStyleLineComponents _i;
		internal AeccLabelStyleLineComponents(object AeccLabelStyleLineComponents_object) 
		{
			this._i = AeccLabelStyleLineComponents_object as Autodesk.AECC.Interop.Land.IAeccLabelStyleLineComponents;
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
