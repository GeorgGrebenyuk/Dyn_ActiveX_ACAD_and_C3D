namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadPlaneSurface 
	{
		public Autodesk.AutoCAD.Interop.Common.IAcadPlaneSurface _i;
		internal AcadPlaneSurface(object AcadPlaneSurface_object) 
		{
			this._i = AcadPlaneSurface_object as Autodesk.AutoCAD.Interop.Common.IAcadPlaneSurface;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
