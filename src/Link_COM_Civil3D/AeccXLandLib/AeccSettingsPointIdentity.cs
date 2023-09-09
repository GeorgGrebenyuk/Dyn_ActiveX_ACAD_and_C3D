namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsPointIdentity 
	{
		public AeccXLandLib.IAeccSettingsPointIdentity _i;
		internal AeccSettingsPointIdentity(object AeccSettingsPointIdentity_object) 
		{
			this._i = AeccSettingsPointIdentity_object as AeccXLandLib.IAeccSettingsPointIdentity;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic NextPointNumber => this._i.NextPointNumber;

		///<summary>
		///
		///</summary>
		public dynamic UseSequentialNumbering => this._i.UseSequentialNumbering;

		///<summary>
		///
		///</summary>
		public dynamic PointNumberOffset => this._i.PointNumberOffset;

		///<summary>
		///
		///</summary>
		public dynamic SequencePointNumbersFrom => this._i.SequencePointNumbersFrom;

		///<summary>
		///
		///</summary>
		public dynamic PointNumbersSupplied => this._i.PointNumbersSupplied;

		///<summary>
		///
		///</summary>
		public dynamic ForceNames => this._i.ForceNames;

		///<summary>
		///
		///</summary>
		public dynamic PointNumbersExist => this._i.PointNumbersExist;

		///<summary>
		///
		///</summary>
		public dynamic PointNamesExist => this._i.PointNamesExist;

		///<summary>
		///
		///</summary>
		public dynamic PointNumbersAssigned => this._i.PointNumbersAssigned;
	}
}
