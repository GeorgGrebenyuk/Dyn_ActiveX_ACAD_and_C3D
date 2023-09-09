namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPipes 
	{
		public AeccXPipeLib.IAeccPipes _i;
		internal AeccPipes(object AeccPipes_object) 
		{
			this._i = AeccPipes_object as AeccXPipeLib.IAeccPipes;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Add(string bstrPartFamilyGuid,dynamic piPartSizeFilter,object varStartPoint,object varEndPoint) 
		{
			return this._i.Add(bstrPartFamilyGuid,piPartSizeFilter,varStartPoint,varEndPoint);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddCurvedPipe(string bstrPartFamilyGuid,dynamic piPartSizeFilter,object varStartPoint,object varEndPoint,double dCurveRadius,bool bClockwise) 
		{
			return this._i.AddCurvedPipe(bstrPartFamilyGuid,piPartSizeFilter,varStartPoint,varEndPoint,dCurveRadius,bClockwise);
		}

		///<summary>
		///
		///</summary>
		public void Remove(object varIndexOrName) 
		{
			this._i.Remove(varIndexOrName);
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
	}
}
