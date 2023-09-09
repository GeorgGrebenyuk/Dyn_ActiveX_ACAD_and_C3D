namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccMatchLine 
	{
		public AeccXLandLib.IAeccMatchLine _i;
		internal AeccMatchLine(object AeccMatchLine_object) 
		{
			this._i = AeccMatchLine_object as AeccXLandLib.IAeccMatchLine;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
