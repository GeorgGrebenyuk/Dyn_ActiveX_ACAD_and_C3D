namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccRoadwayStyleSet 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccRoadwayStyleSet _i;
		internal AeccRoadwayStyleSet(object AeccRoadwayStyleSet_object) 
		{
			this._i = AeccRoadwayStyleSet_object as Autodesk.AECC.Interop.Roadway.IAeccRoadwayStyleSet;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count(Autodesk.AECC.Interop.Roadway.AeccRoadwayStyleType nStyleType) 
		{
			return this._i.Count(nStyleType);
		}

		///<summary>
		///
		///</summary>
		public dynamic Item(Autodesk.AECC.Interop.Roadway.AeccRoadwayStyleType nStyleType,Autodesk.AECC.Interop.Roadway.AeccRoadwayStyleItemType pItemType,string strCode) 
		{
			return this._i.Item(nStyleType,pItemType,strCode);
		}

		///<summary>
		///
		///</summary>
		public dynamic Add(Autodesk.AECC.Interop.Roadway.AeccRoadwayStyleType nStyleType,string strCode,dynamic pICodeStyle) 
		{
			return this._i.Add(nStyleType,strCode,pICodeStyle);
		}

		///<summary>
		///
		///</summary>
		public void Remove(Autodesk.AECC.Interop.Roadway.AeccRoadwayStyleType nStyleType,string strCode) 
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
