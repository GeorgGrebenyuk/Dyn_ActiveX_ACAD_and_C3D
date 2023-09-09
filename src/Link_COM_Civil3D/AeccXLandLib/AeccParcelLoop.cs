namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParcelLoop 
	{
		public AeccXLandLib.IAeccParcelLoop _i;
		internal AeccParcelLoop(object AeccParcelLoop_object) 
		{
			this._i = AeccParcelLoop_object as AeccXLandLib.IAeccParcelLoop;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Item(dynamic nIndex) 
		{
			return this._i.Item(nIndex);
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;
	}
}
