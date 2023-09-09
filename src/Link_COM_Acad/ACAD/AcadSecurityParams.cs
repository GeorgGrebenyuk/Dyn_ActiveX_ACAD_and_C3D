namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadSecurityParams 
	{
		public AXDBLib.IAcadSecurityParams _i;
		internal AcadSecurityParams(object AcadSecurityParams_object) 
		{
			this._i = AcadSecurityParams_object as AXDBLib.IAcadSecurityParams;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Action(dynamic pOperations) 
		{
			this._i.Action = pOperations;
		}

		///<summary>
		///
		///</summary>
		public dynamic Action => this._i.Action;

		///<summary>
		///
		///</summary>
		public void Set_Password(string pSecret) 
		{
			this._i.Password = pSecret;
		}

		///<summary>
		///
		///</summary>
		public string Password => this._i.Password;

		///<summary>
		///
		///</summary>
		public void Set_ProviderType(dynamic pProvType) 
		{
			this._i.ProviderType = pProvType;
		}

		///<summary>
		///
		///</summary>
		public dynamic ProviderType => this._i.ProviderType;

		///<summary>
		///
		///</summary>
		public void Set_ProviderName(string pProvName) 
		{
			this._i.ProviderName = pProvName;
		}

		///<summary>
		///
		///</summary>
		public string ProviderName => this._i.ProviderName;

		///<summary>
		///
		///</summary>
		public void Set_Algorithm(dynamic pAlgId) 
		{
			this._i.Algorithm = pAlgId;
		}

		///<summary>
		///
		///</summary>
		public dynamic Algorithm => this._i.Algorithm;

		///<summary>
		///
		///</summary>
		public void Set_KeyLength(dynamic pKeyLen) 
		{
			this._i.KeyLength = pKeyLen;
		}

		///<summary>
		///
		///</summary>
		public dynamic KeyLength => this._i.KeyLength;

		///<summary>
		///
		///</summary>
		public void Set_Subject(string pCertSubject) 
		{
			this._i.Subject = pCertSubject;
		}

		///<summary>
		///
		///</summary>
		public string Subject => this._i.Subject;

		///<summary>
		///
		///</summary>
		public void Set_Issuer(string pCertIssuer) 
		{
			this._i.Issuer = pCertIssuer;
		}

		///<summary>
		///
		///</summary>
		public string Issuer => this._i.Issuer;

		///<summary>
		///
		///</summary>
		public void Set_SerialNumber(string pSerialNum) 
		{
			this._i.SerialNumber = pSerialNum;
		}

		///<summary>
		///
		///</summary>
		public string SerialNumber => this._i.SerialNumber;

		///<summary>
		///
		///</summary>
		public void Set_Comment(string pText) 
		{
			this._i.Comment = pText;
		}

		///<summary>
		///
		///</summary>
		public string Comment => this._i.Comment;

		///<summary>
		///
		///</summary>
		public void Set_TimeServer(string pTimeServerName) 
		{
			this._i.TimeServer = pTimeServerName;
		}

		///<summary>
		///
		///</summary>
		public string TimeServer => this._i.TimeServer;
	}
}
