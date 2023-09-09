namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccCollectableObject 
	{
		public AeccXLandLib.IAeccCollectableObject _i;
		internal AeccCollectableObject(object AeccCollectableObject_object) 
		{
			this._i = AeccCollectableObject_object as AeccXLandLib.IAeccCollectableObject;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Name(string pVal) 
		{
			this._i.Name = pVal;
		}

		///<summary>
		///
		///</summary>
		public string Name => this._i.Name;
	}
}
