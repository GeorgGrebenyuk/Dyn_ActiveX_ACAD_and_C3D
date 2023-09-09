namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadObjectEvents 
	{
		public AXDBLib.IAcadObjectEvents _i;
		internal AcadObjectEvents(object AcadObjectEvents_object) 
		{
			this._i = AcadObjectEvents_object as AXDBLib.IAcadObjectEvents;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
