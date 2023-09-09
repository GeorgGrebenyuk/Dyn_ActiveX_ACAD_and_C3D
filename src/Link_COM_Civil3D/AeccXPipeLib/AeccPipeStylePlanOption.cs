namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPipeStylePlanOption 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccPipeStylePlanOption _i;
		internal AeccPipeStylePlanOption(object AeccPipeStylePlanOption_object) 
		{
			this._i = AeccPipeStylePlanOption_object as Autodesk.AECC.Interop.Pipe.IAeccPipeStylePlanOption;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
