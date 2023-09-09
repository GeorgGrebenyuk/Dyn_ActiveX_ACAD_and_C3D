namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccRuntimeState 
	{
		public Autodesk.AECC.Interop.Land.IAeccRuntimeState _i;
		internal AeccRuntimeState(object AeccRuntimeState_object) 
		{
			this._i = AeccRuntimeState_object as Autodesk.AECC.Interop.Land.IAeccRuntimeState;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic ParamsBool => this._i.ParamsBool;

		///<summary>
		///
		///</summary>
		public dynamic ParamsLong => this._i.ParamsLong;

		///<summary>
		///
		///</summary>
		public dynamic ParamsDouble => this._i.ParamsDouble;

		///<summary>
		///
		///</summary>
		public dynamic ParamsString => this._i.ParamsString;

		///<summary>
		///
		///</summary>
		public dynamic ParamsSurface => this._i.ParamsSurface;

		///<summary>
		///
		///</summary>
		public dynamic ParamsAlignment => this._i.ParamsAlignment;

		///<summary>
		///
		///</summary>
		public dynamic ParamsProfile => this._i.ParamsProfile;
	}
}
