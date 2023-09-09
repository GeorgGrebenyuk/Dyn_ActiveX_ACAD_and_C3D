namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadPlaneSurface 
	{
		public AXDBLib.IAcadPlaneSurface _i;
		internal AcadPlaneSurface(object AcadPlaneSurface_object) 
		{
			this._i = AcadPlaneSurface_object as AXDBLib.IAcadPlaneSurface;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
