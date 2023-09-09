namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPointImportOptions 
	{
		public AeccXLandLib.IAeccPointImportOptions _i;
		internal AeccPointImportOptions(object AeccPointImportOptions_object) 
		{
			this._i = AeccPointImportOptions_object as AeccXLandLib.IAeccPointImportOptions;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_UsePointGroup(bool UsePointGroup) 
		{
			this._i.UsePointGroup = UsePointGroup;
		}

		///<summary>
		///
		///</summary>
		public bool UsePointGroup => this._i.UsePointGroup;

		///<summary>
		///
		///</summary>
		public void Set_PointGroup(string PointGroup) 
		{
			this._i.PointGroup = PointGroup;
		}

		///<summary>
		///
		///</summary>
		public string PointGroup => this._i.PointGroup;

		///<summary>
		///
		///</summary>
		public void Set_PointDuplicateResolution(AeccXLandLib.AeccPointDuplicateResolutionType DuplicateResol) 
		{
			this._i.PointDuplicateResolution = DuplicateResol;
		}

		///<summary>
		///
		///</summary>
		public dynamic PointDuplicateResolution => this._i.PointDuplicateResolution;

		///<summary>
		///
		///</summary>
		public void Set_AddOffsetFrom(dynamic Offset) 
		{
			this._i.AddOffsetFrom = Offset;
		}

		///<summary>
		///
		///</summary>
		public dynamic AddOffsetFrom => this._i.AddOffsetFrom;

		///<summary>
		///
		///</summary>
		public void Set_SequenceFrom(dynamic Sequence) 
		{
			this._i.SequenceFrom = Sequence;
		}

		///<summary>
		///
		///</summary>
		public dynamic SequenceFrom => this._i.SequenceFrom;
	}
}
