namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPipeStylePlanOption 
	{
		public AeccXPipeLib.IAeccPipeStylePlanOption _i;
		internal AeccPipeStylePlanOption(object AeccPipeStylePlanOption_object) 
		{
			this._i = AeccPipeStylePlanOption_object as AeccXPipeLib.IAeccPipeStylePlanOption;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
