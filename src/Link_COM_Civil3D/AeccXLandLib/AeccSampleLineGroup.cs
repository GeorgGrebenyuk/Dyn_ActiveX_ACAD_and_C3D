namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSampleLineGroup 
	{
		public AeccXLandLib.IAeccSampleLineGroup _i;
		internal AeccSampleLineGroup(object AeccSampleLineGroup_object) 
		{
			this._i = AeccSampleLineGroup_object as AeccXLandLib.IAeccSampleLineGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string DefaultLayer => this._i.DefaultLayer;

		///<summary>
		///
		///</summary>
		public void Set_DefaultLayer(string pVal) 
		{
			this._i.DefaultLayer = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic DefaultSampleLineLabelStyle => this._i.DefaultSampleLineLabelStyle;

		///<summary>
		///
		///</summary>
		public void Put_DefaultSampleLineLabelStyle(dynamic ppVal) 
		{
			this._i.DefaultSampleLineLabelStyle = ppVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic LabelGroups => this._i.LabelGroups;

		///<summary>
		///
		///</summary>
		public dynamic DefaultSampleLineStyle => this._i.DefaultSampleLineStyle;

		///<summary>
		///
		///</summary>
		public void Set_DefaultSampleLineStyle(object ppVal) 
		{
			this._i.DefaultSampleLineStyle = ppVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic SampleLines => this._i.SampleLines;

		///<summary>
		///
		///</summary>
		public dynamic SampledSurfaces => this._i.SampledSurfaces;

		///<summary>
		///
		///</summary>
		public dynamic Parent => this._i.Parent;

		///<summary>
		///
		///</summary>
		public void CreateSectionsAtSampleLines() 
		{
			this._i.CreateSectionsAtSampleLines();
		}

		///<summary>
		///
		///</summary>
		public void CreateSectionsAtSampleLine(dynamic SampleLine) 
		{
			this._i.CreateSectionsAtSampleLine(SampleLine);
		}
	}
}
