namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateIntersection 
	{
		public AeccXLandLib.IAeccSettingsCreateIntersection _i;
		internal AeccSettingsCreateIntersection(object AeccSettingsCreateIntersection_object) 
		{
			this._i = AeccSettingsCreateIntersection_object as AeccXLandLib.IAeccSettingsCreateIntersection;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
