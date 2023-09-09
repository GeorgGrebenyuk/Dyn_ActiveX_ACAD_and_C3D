namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSheet 
	{
		public AeccXLandLib.IAeccSheet _i;
		internal AeccSheet(object AeccSheet_object) 
		{
			this._i = AeccSheet_object as AeccXLandLib.IAeccSheet;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
