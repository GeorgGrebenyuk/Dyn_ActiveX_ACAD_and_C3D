namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSheet 
	{
		public Autodesk.AECC.Interop.Land.IAeccSheet _i;
		internal AeccSheet(object AeccSheet_object) 
		{
			this._i = AeccSheet_object as Autodesk.AECC.Interop.Land.IAeccSheet;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
