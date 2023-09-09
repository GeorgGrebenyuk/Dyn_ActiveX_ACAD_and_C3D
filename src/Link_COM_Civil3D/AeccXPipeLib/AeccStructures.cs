namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccStructures 
	{
		public AeccXPipeLib.IAeccStructures _i;
		internal AeccStructures(object AeccStructures_object) 
		{
			this._i = AeccStructures_object as AeccXPipeLib.IAeccStructures;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Add(string bstrPartFamilyGuid,dynamic piPartSizeFilter,object varLocation,double dRotation) 
		{
			return this._i.Add(bstrPartFamilyGuid,piPartSizeFilter,varLocation,dRotation);
		}

		///<summary>
		///
		///</summary>
		public void Remove(object varIndexOrName) 
		{
			this._i.Remove(varIndexOrName);
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
	}
}
