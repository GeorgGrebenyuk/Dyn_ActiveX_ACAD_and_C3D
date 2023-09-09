namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileViewLabels 
	{
		public Autodesk.AECC.Interop.Land.IAeccProfileViewLabels _i;
		internal AeccProfileViewLabels(object AeccProfileViewLabels_object) 
		{
			this._i = AeccProfileViewLabels_object as Autodesk.AECC.Interop.Land.IAeccProfileViewLabels;
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
