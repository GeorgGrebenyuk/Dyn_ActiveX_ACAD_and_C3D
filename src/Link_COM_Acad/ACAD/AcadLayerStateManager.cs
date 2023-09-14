namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadLayerStateManager 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadLayerStateManager _i;
		internal AcadLayerStateManager(object AcadLayerStateManager_object) 
		{
			this._i = AcadLayerStateManager_object as Autodesk.AutoCAD.Interop.Common.AcadLayerStateManager;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void SetDatabase(dynamic iHostDb) 
		{
			this._i.SetDatabase(iHostDb);
		}

		///<summary>
		///
		///</summary>
		public void Set_Mask(string bsName,Autodesk.AutoCAD.Interop.Common.AcLayerStateMask eMask) 
		{
			this._i.Mask[bsName] = eMask;
		}

		///<summary>
		///
		///</summary>
		public dynamic Mask(string bsName) 
		{
			return this._i.Mask[bsName];
		}

		///<summary>
		///
		///</summary>
		public void Save(string bsName,Autodesk.AutoCAD.Interop.Common.AcLayerStateMask eMask) 
		{
			this._i.Save(bsName,eMask);
		}

		///<summary>
		///
		///</summary>
		public void Restore(string bsName) 
		{
			this._i.Restore(bsName);
		}

		///<summary>
		///
		///</summary>
		public void Delete(string bsName) 
		{
			this._i.Delete(bsName);
		}

		///<summary>
		///
		///</summary>
		public void Rename(string bsName,string bsNewName) 
		{
			this._i.Rename(bsName,bsNewName);
		}

		///<summary>
		///
		///</summary>
		public void Import(string bsFilename) 
		{
			this._i.Import(bsFilename);
		}

		///<summary>
		///
		///</summary>
		public void Export(string bsName,string bsFilename) 
		{
			this._i.Export(bsName,bsFilename);
		}
	}
}
