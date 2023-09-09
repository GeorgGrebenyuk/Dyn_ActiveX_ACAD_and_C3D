namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPartDataRecord 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccPartDataRecord _i;
		internal AeccPartDataRecord(object AeccPartDataRecord_object) 
		{
			this._i = AeccPartDataRecord_object as Autodesk.AECC.Interop.Pipe.IAeccPartDataRecord;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Item(object pos) 
		{
			return this._i.Item(pos);
		}

		///<summary>
		///
		///</summary>
		public dynamic Append(object vContext,dynamic nIndex) 
		{
			return this._i.Append(vContext,nIndex);
		}

		///<summary>
		///
		///</summary>
		public void Remove(object varName) 
		{
			this._i.Remove(varName);
		}

		///<summary>
		///
		///</summary>
		public dynamic Find(string bstrName) 
		{
			return this._i.Find(bstrName);
		}

		///<summary>
		///
		///</summary>
		public dynamic FindByContext(object varContext) 
		{
			return this._i.FindByContext(varContext);
		}

		///<summary>
		///
		///</summary>
		public dynamic FindByContextAndIndex(object varContext,dynamic nIndex) 
		{
			return this._i.FindByContextAndIndex(varContext,nIndex);
		}

		///<summary>
		///
		///</summary>
		public string ParamNames => this._i.ParamNames;

		///<summary>
		///
		///</summary>
		public dynamic Insert(object varInsertBeforeIndexOrName,object varContext,dynamic nIndex) 
		{
			return this._i.Insert(varInsertBeforeIndexOrName,varContext,nIndex);
		}

		///<summary>
		///
		///</summary>
		private void HiddenField_Clean() 
		{
			
		}
	}
}
