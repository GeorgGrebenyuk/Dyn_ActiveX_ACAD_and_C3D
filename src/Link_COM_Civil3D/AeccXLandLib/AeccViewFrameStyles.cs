namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccViewFrameStyles 
	{
		public Autodesk.AECC.Interop.Land.IAeccViewFrameStyles _i;
		internal AeccViewFrameStyles(object AeccViewFrameStyles_object) 
		{
			this._i = AeccViewFrameStyles_object as Autodesk.AECC.Interop.Land.IAeccViewFrameStyles;
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
