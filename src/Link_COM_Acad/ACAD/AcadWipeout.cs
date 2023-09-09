namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadWipeout 
	{
		public AXDBLib.IAcadWipeout _i;
		internal AcadWipeout(object AcadWipeout_object) 
		{
			this._i = AcadWipeout_object as AXDBLib.IAcadWipeout;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
