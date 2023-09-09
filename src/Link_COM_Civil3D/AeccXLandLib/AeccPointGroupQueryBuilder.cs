namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPointGroupQueryBuilder 
	{
		public AeccXLandLib.IAeccPointGroupQueryBuilder _i;
		internal AeccPointGroupQueryBuilder(object AeccPointGroupQueryBuilder_object) 
		{
			this._i = AeccPointGroupQueryBuilder_object as AeccXLandLib.IAeccPointGroupQueryBuilder;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_IncludeAllPoints(bool rhs) 
		{
			this._i.IncludeAllPoints = rhs;
		}

		///<summary>
		///
		///</summary>
		public string ExcludeElevations => this._i.ExcludeElevations;

		///<summary>
		///
		///</summary>
		public void Set_ExcludeElevations(string pVal) 
		{
			this._i.ExcludeElevations = pVal;
		}

		///<summary>
		///
		///</summary>
		public string ExcludeFullDescriptions => this._i.ExcludeFullDescriptions;

		///<summary>
		///
		///</summary>
		public void Set_ExcludeFullDescriptions(string pVal) 
		{
			this._i.ExcludeFullDescriptions = pVal;
		}

		///<summary>
		///
		///</summary>
		public string ExcludeNames => this._i.ExcludeNames;

		///<summary>
		///
		///</summary>
		public void Set_ExcludeNames(string pVal) 
		{
			this._i.ExcludeNames = pVal;
		}

		///<summary>
		///
		///</summary>
		public string ExcludeNumbers => this._i.ExcludeNumbers;

		///<summary>
		///
		///</summary>
		public void Set_ExcludeNumbers(string pVal) 
		{
			this._i.ExcludeNumbers = pVal;
		}

		///<summary>
		///
		///</summary>
		public string ExcludeRawDescriptions => this._i.ExcludeRawDescriptions;

		///<summary>
		///
		///</summary>
		public void Set_ExcludeRawDescriptions(string pVal) 
		{
			this._i.ExcludeRawDescriptions = pVal;
		}

		///<summary>
		///
		///</summary>
		public string IncludeElevations => this._i.IncludeElevations;

		///<summary>
		///
		///</summary>
		public void Set_IncludeElevations(string pVal) 
		{
			this._i.IncludeElevations = pVal;
		}

		///<summary>
		///
		///</summary>
		public string IncludeFullDescriptions => this._i.IncludeFullDescriptions;

		///<summary>
		///
		///</summary>
		public void Set_IncludeFullDescriptions(string pVal) 
		{
			this._i.IncludeFullDescriptions = pVal;
		}

		///<summary>
		///
		///</summary>
		public string IncludeNames => this._i.IncludeNames;

		///<summary>
		///
		///</summary>
		public void Set_IncludeNames(string pVal) 
		{
			this._i.IncludeNames = pVal;
		}

		///<summary>
		///
		///</summary>
		public string IncludeNumbers => this._i.IncludeNumbers;

		///<summary>
		///
		///</summary>
		public void Set_IncludeNumbers(string pVal) 
		{
			this._i.IncludeNumbers = pVal;
		}

		///<summary>
		///
		///</summary>
		public string IncludeRawDescriptions => this._i.IncludeRawDescriptions;

		///<summary>
		///
		///</summary>
		public void Set_IncludeRawDescriptions(string pVal) 
		{
			this._i.IncludeRawDescriptions = pVal;
		}

		///<summary>
		///
		///</summary>
		public string IncludePointGroups => this._i.IncludePointGroups;

		///<summary>
		///
		///</summary>
		public void Set_IncludePointGroups(string pVal) 
		{
			this._i.IncludePointGroups = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UseCaseSensitiveMatching => this._i.UseCaseSensitiveMatching;

		///<summary>
		///
		///</summary>
		public void Set_UseCaseSensitiveMatching(bool pVal) 
		{
			this._i.UseCaseSensitiveMatching = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic QueryStatement => this._i.QueryStatement;

		///<summary>
		///
		///</summary>
		public void Clear() 
		{
			this._i.Clear();
		}
	}
}
