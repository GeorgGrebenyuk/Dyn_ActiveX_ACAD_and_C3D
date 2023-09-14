namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadRevolvedSurface 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadRevolvedSurface _i;
		internal AcadRevolvedSurface(object AcadRevolvedSurface_object) 
		{
			this._i = AcadRevolvedSurface_object as Autodesk.AutoCAD.Interop.Common.AcadRevolvedSurface;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public double RevolutionAngle => this._i.RevolutionAngle;

		///<summary>
		///
		///</summary>
		public void Set_RevolutionAngle(dynamic revAngle) 
		{
			this._i.RevolutionAngle = revAngle;
		}

		///<summary>
		///
		///</summary>
		public object AxisPosition => this._i.AxisPosition;

		///<summary>
		///
		///</summary>
		public void Set_AxisPosition(object AxisPosition) 
		{
			this._i.AxisPosition = AxisPosition;
		}

		///<summary>
		///
		///</summary>
		public object AxisDirection => this._i.AxisDirection;
	}
}
