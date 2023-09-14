using Autodesk.DesignScript.Geometry;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadUCS 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadUCS _i;
		internal AcadUCS(object AcadUCS_object) 
		{
			this._i = AcadUCS_object as Autodesk.AutoCAD.Interop.Common.AcadUCS;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        ///<summary>
        ///Create new AcadUCS
        ///</summary>
        public AcadUCS(AcadUCSs AcadUCSs, Point Origin, Vector XAxisPoint, Vector YAxisPoint, string Name)
        {
            this._i =  AcadUCSs._i.Add(Technical.PointByDynPoint(Origin), 
				Technical.VectorByDynVector(XAxisPoint), Technical.VectorByDynVector(YAxisPoint), Name);
        }

        ///<summary>
        ///
        ///</summary>
        public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public void Set_Name(string bstrName) 
		{
			this._i.Name = bstrName;
		}

		///<summary>
		///
		///</summary>
		public Point Origin => Technical.PointByDoubleArray(this._i.Origin);

		///<summary>
		///
		///</summary>
		public void Set_Origin(Point Origin) 
		{
			this._i.Origin = Technical.PointByDynPoint(Origin);
		}

		///<summary>
		///
		///</summary>
		public Vector XVector => Technical.VectorByDoubleArray(this._i.XVector);

		///<summary>
		///
		///</summary>
		public void Set_XVector(Vector XVector) 
		{
			this._i.XVector = Technical.VectorByDynVector(XVector);
		}

		///<summary>
		///
		///</summary>
		public Vector YVector => Technical.VectorByDoubleArray(this._i.YVector);

        ///<summary>
        ///
        ///</summary>
        public void Set_YVector(Vector YVector) 
		{
			this._i.YVector = Technical.VectorByDynVector(YVector);
        }

		///<summary>
		///
		///</summary>
		public object GetUCSMatrix => this._i.GetUCSMatrix();
	}
}
