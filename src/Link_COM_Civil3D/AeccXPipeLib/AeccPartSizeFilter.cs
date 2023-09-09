namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPartSizeFilter 
	{
		public AeccXPipeLib.IAeccPartSizeFilter _i;
		internal AeccPartSizeFilter(object AeccPartSizeFilter_object) 
		{
			this._i = AeccPartSizeFilter_object as AeccXPipeLib.IAeccPartSizeFilter;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public void Set_Name(string pbstrName) 
		{
			this._i.Name = pbstrName;
		}

		///<summary>
		///
		///</summary>
		public dynamic PartDataRecord => this._i.PartDataRecord;
	}
}
