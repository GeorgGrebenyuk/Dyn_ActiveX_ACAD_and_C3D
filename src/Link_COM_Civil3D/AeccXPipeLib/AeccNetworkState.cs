namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccNetworkState 
	{
		public AeccXPipeLib.IAeccNetworkState _i;
		internal AeccNetworkState(object AeccNetworkState_object) 
		{
			this._i = AeccNetworkState_object as AeccXPipeLib.IAeccNetworkState;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public bool IsLayoutUpStream => this._i.IsLayoutUpStream;

		///<summary>
		///
		///</summary>
		public dynamic CurrentPipe => this._i.CurrentPipe;

		///<summary>
		///
		///</summary>
		public dynamic CurrentStructure => this._i.CurrentStructure;

		///<summary>
		///
		///</summary>
		public void SetErrorMsgOnCurrentPart(string bstrParamKey,string bstrValue) 
		{
			this._i.SetErrorMsgOnCurrentPart(bstrParamKey,bstrValue);
		}

		///<summary>
		///
		///</summary>
		public void SetBoolOnCurrentPart(string bstrParamKey,dynamic bValue) 
		{
			this._i.SetBoolOnCurrentPart(bstrParamKey,bValue);
		}

		///<summary>
		///
		///</summary>
		public void SetLongOnCurrentPart(string bstrParamKey,dynamic nValue) 
		{
			this._i.SetLongOnCurrentPart(bstrParamKey,nValue);
		}

		///<summary>
		///
		///</summary>
		public void SetDoubleOnCurrentPart(string bstrParamKey,double dblValue) 
		{
			this._i.SetDoubleOnCurrentPart(bstrParamKey,dblValue);
		}

		///<summary>
		///
		///</summary>
		public void SetStringOnCurrentPart(string bstrParamKey,string bstrValue) 
		{
			this._i.SetStringOnCurrentPart(bstrParamKey,bstrValue);
		}

		///<summary>
		///
		///</summary>
		public void SetPointOnCurrentPart(string bstrParamKey,object pPoint) 
		{
			this._i.SetPointOnCurrentPart(bstrParamKey,pPoint);
		}

		///<summary>
		///
		///</summary>
		public void SetAlignmentOnCurrentPart(string bstrParamKey,dynamic ppVal) 
		{
			this._i.SetAlignmentOnCurrentPart(bstrParamKey,ppVal);
		}

		///<summary>
		///
		///</summary>
		public void SetProfileOnCurrentPart(string bstrParamKey,dynamic ppVal) 
		{
			this._i.SetProfileOnCurrentPart(bstrParamKey,ppVal);
		}

		///<summary>
		///
		///</summary>
		public void SetSurfaceOnCurrentPart(string bstrParamKey,dynamic ppVal) 
		{
			this._i.SetSurfaceOnCurrentPart(bstrParamKey,ppVal);
		}

		///<summary>
		///
		///</summary>
		public double LastPipeElevation => this._i.LastPipeElevation;

		///<summary>
		///
		///</summary>
		public void Set_LastPipeElevation(double pPoint) 
		{
			this._i.LastPipeElevation = pPoint;
		}

		///<summary>
		///
		///</summary>
		public bool IsBreakingPipe => this._i.IsBreakingPipe;

		///<summary>
		///
		///</summary>
		public bool IsConnectingToStructure => this._i.IsConnectingToStructure;

		///<summary>
		///
		///</summary>
		public bool IsInlayoutMode => this._i.IsInlayoutMode;

		///<summary>
		///
		///</summary>
		public bool IsCurrentPartBeingAdd => this._i.IsCurrentPartBeingAdd;

		///<summary>
		///
		///</summary>
		public string RuleResourceString(string resourceId) 
		{
			return this._i.RuleResourceString(resourceId);
		}
	}
}
