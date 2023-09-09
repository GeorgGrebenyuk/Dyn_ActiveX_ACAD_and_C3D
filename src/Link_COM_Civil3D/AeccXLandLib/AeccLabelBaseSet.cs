namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelBaseSet 
	{
		public Autodesk.AECC.Interop.Land.IAeccLabelBaseSet _i;
		internal AeccLabelBaseSet(object AeccLabelBaseSet_object) 
		{
			this._i = AeccLabelBaseSet_object as Autodesk.AECC.Interop.Land.IAeccLabelBaseSet;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Type => this._i.Type;

		///<summary>
		///
		///</summary>
		public void Remove(object vIndex) 
		{
			this._i.Remove(vIndex);
		}
	}
}
