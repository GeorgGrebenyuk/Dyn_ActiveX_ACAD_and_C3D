using Autodesk.AutoCAD.Interop.Common;

namespace DynAXDBLib 
{

    ///<summary>
    ///The render material characteristics
    ///</summary>
    public class AcadMaterial 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadMaterial _i;
		internal AcadMaterial(object AcadMaterial_object) 
		{
			this._i = AcadMaterial_object as Autodesk.AutoCAD.Interop.Common.AcadMaterial;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        ///<summary>
        /// Create new Material or return existed
        ///</summary>
        public AcadMaterial (AcadMaterials AcadMaterials, string Name)
        {
            for (int i = 0; i < AcadMaterials._i.Count; i++)
            {
                var obj = AcadMaterials._i.Item(i);
                if (obj.Name == Name) this._i = obj;
            }
            this._i = AcadMaterials._i.Add(Name);
        }

        ///<summary>
        ///Specifies the description of an object
        ///</summary>
        public string Description => this._i.Description;

        ///<summary>
        ///Specifies the description of an object
        ///</summary>
        public void Set_Description(string bstrDes) 
		{
			this._i.Description = bstrDes;
		}

        ///<summary>
        ///Specifies the name of the object
        ///</summary>
        public string Name => this._i.Name;

        ///<summary>
        ///Specifies the name of the object
        ///</summary>
        public void Set_Name(string bstrName) 
		{
			this._i.Name = bstrName;
		}
	}
}
