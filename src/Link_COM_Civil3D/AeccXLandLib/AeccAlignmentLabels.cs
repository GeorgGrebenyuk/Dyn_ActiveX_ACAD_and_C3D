namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentLabels 
	{
		public AeccXLandLib.IAeccAlignmentLabels _i;
		internal AeccAlignmentLabels(object AeccAlignmentLabels_object) 
		{
			this._i = AeccAlignmentLabels_object as AeccXLandLib.IAeccAlignmentLabels;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Item(dynamic Index) 
		{
			return this._i.Item(Index);
		}

		///<summary>
		///
		///</summary>
		public void Remove(dynamic Index) 
		{
			this._i.Remove(Index);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddStationOffsetLabel(object LabelStyle,object MarkerStyle,double Station,double Offset) 
		{
			return this._i.AddStationOffsetLabel(LabelStyle,MarkerStyle,Station,Offset);
		}
	}
}
