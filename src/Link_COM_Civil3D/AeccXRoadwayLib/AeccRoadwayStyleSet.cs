namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccRoadwayStyleSet 
	{
		public AeccXRoadwayLib.IAeccRoadwayStyleSet _i;
		internal AeccRoadwayStyleSet(object AeccRoadwayStyleSet_object) 
		{
			this._i = AeccRoadwayStyleSet_object as AeccXRoadwayLib.IAeccRoadwayStyleSet;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count(AeccXRoadwayLib.AeccRoadwayStyleType nStyleType) 
		{
			return this._i.Count(nStyleType);
		}

		///<summary>
		///
		///</summary>
		public dynamic Item(AeccXRoadwayLib.AeccRoadwayStyleType nStyleType,AeccXRoadwayLib.AeccRoadwayStyleItemType pItemType,string strCode) 
		{
			return this._i.Item(nStyleType,pItemType,strCode);
		}

		///<summary>
		///
		///</summary>
		public dynamic Add(AeccXRoadwayLib.AeccRoadwayStyleType nStyleType,string strCode,dynamic pICodeStyle) 
		{
			return this._i.Add(nStyleType,strCode,pICodeStyle);
		}

		///<summary>
		///
		///</summary>
		public void Remove(AeccXRoadwayLib.AeccRoadwayStyleType nStyleType,string strCode) 
		{
			this._i.Remove(nStyleType,strCode);
		}

		///<summary>
		///
		///</summary>
		public void InitAsCurrent() 
		{
			this._i.InitAsCurrent();
		}
	}
}
