namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccUserDefinedPropertyClassifications 
	{
		public Autodesk.AECC.Interop.Land.IAeccUserDefinedPropertyClassifications _i;
		internal AeccUserDefinedPropertyClassifications(object AeccUserDefinedPropertyClassifications_object) 
		{
			this._i = AeccUserDefinedPropertyClassifications_object as Autodesk.AECC.Interop.Land.IAeccUserDefinedPropertyClassifications;
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
		public void Remove(object Index) 
		{
			this._i.Remove(Index);
		}
	}
}
