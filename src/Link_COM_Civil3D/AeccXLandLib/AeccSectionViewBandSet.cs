namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionViewBandSet 
	{
		public Autodesk.AECC.Interop.Land.IAeccSectionViewBandSet _i;
		internal AeccSectionViewBandSet(object AeccSectionViewBandSet_object) 
		{
			this._i = AeccSectionViewBandSet_object as Autodesk.AECC.Interop.Land.IAeccSectionViewBandSet;
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
		public dynamic Add(dynamic pBandStyle,dynamic pISection1,dynamic pISections) 
		{
			return this._i.Add(pBandStyle,pISection1,pISections);
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
		public void Import(dynamic pBandStyleSet) 
		{
			this._i.Import(pBandStyleSet);
		}

		///<summary>
		///
		///</summary>
		public void Export(dynamic pBandStyleSet) 
		{
			this._i.Export(pBandStyleSet);
		}

		///<summary>
		///
		///</summary>
		public void Swap(dynamic BandSetItemIndex1,dynamic BandSetItemIndex2) 
		{
			this._i.Swap(BandSetItemIndex1,BandSetItemIndex2);
		}

		///<summary>
		///
		///</summary>
		public dynamic Insert(dynamic Index,dynamic pBandStyle,dynamic pISection1,dynamic pISections) 
		{
			return this._i.Insert(Index,pBandStyle,pISection1,pISections);
		}
	}
}
