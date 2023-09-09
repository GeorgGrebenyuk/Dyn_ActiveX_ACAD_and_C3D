namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyLinetype 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyLinetype _i;
		internal AeccPropertyLinetype(object AeccPropertyLinetype_object) 
		{
			this._i = AeccPropertyLinetype_object as Autodesk.AECC.Interop.Land.IAeccPropertyLinetype;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
