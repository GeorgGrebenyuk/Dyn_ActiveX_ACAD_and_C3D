namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSampleLineGroups 
	{
		public Autodesk.AECC.Interop.Land.IAeccSampleLineGroups _i;
		internal AeccSampleLineGroups(object AeccSampleLineGroups_object) 
		{
			this._i = AeccSampleLineGroups_object as Autodesk.AECC.Interop.Land.IAeccSampleLineGroups;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Item(object Index) 
		{
			return this._i.Item(Index);
		}

		///<summary>
		///
		///</summary>
		public dynamic Add(string Name,string Layer,dynamic GroupPlotStyle,dynamic SampleLineStyle,dynamic SampleLineLabelStyle) 
		{
			return this._i.Add(Name,Layer,GroupPlotStyle,SampleLineStyle,SampleLineLabelStyle);
		}

		///<summary>
		///
		///</summary>
		public void Remove(object Index) 
		{
			this._i.Remove(Index);
		}
	}
}
