namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAbbreviationGeneral 
	{
		public AeccXLandLib.IAeccSettingsAbbreviationGeneral _i;
		internal AeccSettingsAbbreviationGeneral(object AeccSettingsAbbreviationGeneral_object) 
		{
			this._i = AeccSettingsAbbreviationGeneral_object as AeccXLandLib.IAeccSettingsAbbreviationGeneral;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string Infinity => this._i.Infinity;

		///<summary>
		///
		///</summary>
		public void Set_Infinity(string pVal) 
		{
			this._i.Infinity = pVal;
		}

		///<summary>
		///
		///</summary>
		public string Left => this._i.Left;

		///<summary>
		///
		///</summary>
		public void Set_Left(string pVal) 
		{
			this._i.Left = pVal;
		}

		///<summary>
		///
		///</summary>
		public string Right => this._i.Right;

		///<summary>
		///
		///</summary>
		public void Set_Right(string pVal) 
		{
			this._i.Right = pVal;
		}
	}
}
