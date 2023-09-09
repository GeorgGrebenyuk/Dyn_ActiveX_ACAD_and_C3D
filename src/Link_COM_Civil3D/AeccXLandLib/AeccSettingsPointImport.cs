namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsPointImport 
	{
		public AeccXLandLib.IAeccSettingsPointImport _i;
		internal AeccSettingsPointImport(object AeccSettingsPointImport_object) 
		{
			this._i = AeccSettingsPointImport_object as AeccXLandLib.IAeccSettingsPointImport;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

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
		public dynamic PointNumbersExist => this._i.PointNumbersExist;

		///<summary>
		///
		///</summary>
		public dynamic PointNumbersAssigned => this._i.PointNumbersAssigned;

		///<summary>
		///
		///</summary>
		public dynamic ForceNames => this._i.ForceNames;

		///<summary>
		///
		///</summary>
		public dynamic PointNamesExist => this._i.PointNamesExist;
	}
}
