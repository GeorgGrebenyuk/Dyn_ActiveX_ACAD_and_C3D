using Autodesk.DesignScript.Geometry;
namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadBlockReference 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadBlockReference _i;
		/// <summary>
		/// Use only with py-script
		/// </summary>
		/// <param name="AcadBlockReference_object"></param>
		/// <exception cref="System.Exception"></exception>
        public AcadBlockReference(object AcadBlockReference_object) 
		{
			this._i = AcadBlockReference_object as Autodesk.AutoCAD.Interop.Common.AcadBlockReference;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Try cast from AcadEntity
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <exception cref="System.Exception"></exception>
        public AcadBlockReference(AcadEntity AcadEntity)
        {
            this._i = AcadEntity._i as Autodesk.AutoCAD.Interop.Common.AcadBlockReference;
            if (this._i == null) throw new System.Exception("Invalid casting");
        }
		/////<summary>
		/////
		/////</summary>
		//public AcadBlockReference InsertBlock(object InsertionPoint, string Name, double Xscale, double Yscale, double Zscale, double Rotation, object Password)
		//{
		//	try
		//	{
		//              return new AcadBlockReference(this._i.InsertBlock(InsertionPoint, Name, Xscale, Yscale, Zscale, Rotation, Password));
		//          }
		//	catch (System.Exception ex) { throw ex; }
		//}

		///<summary>
		///
		///</summary>
		public Point InsertionPoint => Technical.PointByDoubleArray(this._i.InsertionPoint);

		///<summary>
		///
		///</summary>
		public void Set_InsertionPoint(object insPoint) 
		{
			this._i.InsertionPoint = insPoint;
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
		public object Normal => this._i.Normal;

		///<summary>
		///
		///</summary>
		public void Set_Normal(object Normal) 
		{
			this._i.Normal = Normal;
		}

		///<summary>
		///
		///</summary>
		public double Rotation => this._i.Rotation;

		///<summary>
		///
		///</summary>
		public void Set_Rotation(double rotAngle) 
		{
			this._i.Rotation = rotAngle;
		}

		///<summary>
		///
		///</summary>
		public double XScaleFactor => this._i.XScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_XScaleFactor(double ScaleFactor) 
		{
			this._i.XScaleFactor = ScaleFactor;
		}

		///<summary>
		///
		///</summary>
		public double YScaleFactor => this._i.YScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_YScaleFactor(double ScaleFactor) 
		{
			this._i.YScaleFactor = ScaleFactor;
		}

		///<summary>
		///
		///</summary>
		public double ZScaleFactor => this._i.ZScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_ZScaleFactor(double ScaleFactor) 
		{
			this._i.ZScaleFactor = ScaleFactor;
		}

		///<summary>
		///
		///</summary>
		public dynamic Explode => this._i.Explode();

		///<summary>
		///
		///</summary>
		public object GetAttributes => this._i.GetAttributes();

		///<summary>
		///
		///</summary>
		public object GetConstantAttributes => this._i.GetConstantAttributes();

		///<summary>
		///
		///</summary>
		public bool HasAttributes => this._i.HasAttributes;

		///<summary>
		///
		///</summary>
		public string EffectiveName => this._i.EffectiveName;

		///<summary>
		///
		///</summary>
		public bool IsDynamicBlock => this._i.IsDynamicBlock;

		///<summary>
		///
		///</summary>
		public object GetDynamicBlockProperties => this._i.GetDynamicBlockProperties();

		///<summary>
		///
		///</summary>
		public void ResetBlock() 
		{
			this._i.ResetBlock();
		}

		///<summary>
		///
		///</summary>
		public void ConvertToAnonymousBlock() 
		{
			this._i.ConvertToAnonymousBlock();
		}

		///<summary>
		///
		///</summary>
		public void ConvertToStaticBlock(string newBlockName) 
		{
			this._i.ConvertToStaticBlock(newBlockName);
		}

		///<summary>
		///
		///</summary>
		public double XEffectiveScaleFactor => this._i.XEffectiveScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_XEffectiveScaleFactor(double ScaleFactor) 
		{
			this._i.XEffectiveScaleFactor = ScaleFactor;
		}

		///<summary>
		///
		///</summary>
		public double YEffectiveScaleFactor => this._i.YEffectiveScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_YEffectiveScaleFactor(double ScaleFactor) 
		{
			this._i.YEffectiveScaleFactor = ScaleFactor;
		}

		///<summary>
		///
		///</summary>
		public double ZEffectiveScaleFactor => this._i.ZEffectiveScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_ZEffectiveScaleFactor(double ScaleFactor) 
		{
			this._i.ZEffectiveScaleFactor = ScaleFactor;
		}

		///<summary>
		///
		///</summary>
		public string InsUnits => this._i.InsUnits;

		///<summary>
		///
		///</summary>
		public double InsUnitsFactor => this._i.InsUnitsFactor;
	}
}
