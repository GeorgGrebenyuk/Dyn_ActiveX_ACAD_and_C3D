namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateIntersection 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsCreateIntersection _i;
		internal AeccSettingsCreateIntersection(object AeccSettingsCreateIntersection_object) 
		{
			this._i = AeccSettingsCreateIntersection_object as Autodesk.AECC.Interop.Land.IAeccSettingsCreateIntersection;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
