namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentDesignCheck 
	{
		public AeccXLandLib.IAeccAlignmentDesignCheck _i;
		internal AeccAlignmentDesignCheck(object AeccAlignmentDesignCheck_object) 
		{
			this._i = AeccAlignmentDesignCheck_object as AeccXLandLib.IAeccAlignmentDesignCheck;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public void Set_Name(string pValue) 
		{
			this._i.Name = pValue;
		}

		///<summary>
		///
		///</summary>
		public string Description => this._i.Description;

		///<summary>
		///
		///</summary>
		public void Set_Description(string pValue) 
		{
			this._i.Description = pValue;
		}

		///<summary>
		///
		///</summary>
		public string Expression => this._i.Expression;

		///<summary>
		///
		///</summary>
		public void Set_Expression(string pValue) 
		{
			this._i.Expression = pValue;
		}

		///<summary>
		///
		///</summary>
		public dynamic Type => this._i.Type;

		///<summary>
		///
		///</summary>
		public void Set_Type(AeccXLandLib.AeccAlignmentDesignCheckType pValue) 
		{
			this._i.Type = pValue;
		}

		///<summary>
		///
		///</summary>
		public dynamic Id => this._i.Id;
	}
}
