namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccMatchLine 
	{
		public Autodesk.AECC.Interop.Land.IAeccMatchLine _i;
		internal AeccMatchLine(object AeccMatchLine_object) 
		{
			this._i = AeccMatchLine_object as Autodesk.AECC.Interop.Land.IAeccMatchLine;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
