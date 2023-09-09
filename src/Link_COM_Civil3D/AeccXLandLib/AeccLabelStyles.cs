namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelStyles 
	{
		public AeccXLandLib.IAeccLabelStyles _i;
		internal AeccLabelStyles(object AeccLabelStyles_object) 
		{
			this._i = AeccLabelStyles_object as AeccXLandLib.IAeccLabelStyles;
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
		public dynamic Type => this._i.Type;

		///<summary>
		///
		///</summary>
		public void Remove(object val) 
		{
			this._i.Remove(val);
		}

		///<summary>
		///
		///</summary>
		public dynamic LabelStyleDefaults => this._i.LabelStyleDefaults;
	}
}
