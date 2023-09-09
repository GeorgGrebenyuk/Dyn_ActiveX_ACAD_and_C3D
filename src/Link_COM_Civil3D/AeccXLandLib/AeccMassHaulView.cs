namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccMassHaulView 
	{
		public AeccXLandLib.IAeccMassHaulView _i;
		internal AeccMassHaulView(object AeccMassHaulView_object) 
		{
			this._i = AeccMassHaulView_object as AeccXLandLib.IAeccMassHaulView;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
