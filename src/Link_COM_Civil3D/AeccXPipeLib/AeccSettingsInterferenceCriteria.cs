namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsInterferenceCriteria 
	{
		public AeccXPipeLib.IAeccSettingsInterferenceCriteria _i;
		internal AeccSettingsInterferenceCriteria(object AeccSettingsInterferenceCriteria_object) 
		{
			this._i = AeccSettingsInterferenceCriteria_object as AeccXPipeLib.IAeccSettingsInterferenceCriteria;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Apply3DProximityCheck => this._i.Apply3DProximityCheck;

		///<summary>
		///
		///</summary>
		public dynamic Distance => this._i.Distance;

		///<summary>
		///
		///</summary>
		public dynamic ScaleFactor => this._i.ScaleFactor;

		///<summary>
		///
		///</summary>
		public dynamic UseDistanceScale => this._i.UseDistanceScale;
	}
}
