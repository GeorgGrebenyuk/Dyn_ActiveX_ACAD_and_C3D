namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccMassHaulView 
	{
		public Autodesk.AECC.Interop.Land.IAeccMassHaulView _i;
		internal AeccMassHaulView(object AeccMassHaulView_object) 
		{
			this._i = AeccMassHaulView_object as Autodesk.AECC.Interop.Land.IAeccMassHaulView;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
